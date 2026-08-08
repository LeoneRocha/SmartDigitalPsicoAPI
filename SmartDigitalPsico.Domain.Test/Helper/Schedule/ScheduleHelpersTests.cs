using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers.Medical;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.Test.Helper.Schedule;

[TestFixture]
public class ScheduleHelpersTests
{
    // Cenário: Uma chave de tenant contém espaços externos.
    // Objetivo: Retornar a chave obrigatória sem espaços externos.
    [Test]
    public void RequireTenant_ValidTenant_ReturnsTrimmedValue()
    {
        // Arrange
        const string tenant = " sdp ";
        // Act
        var result = ScheduleKeyHelper.RequireTenant(tenant);
        // Assert
        result.Should().Be("sdp");
    }

    // Cenário: Uma chave de tenant não foi informada.
    // Objetivo: Rejeitar a chave obrigatória.
    [TestCase(null)]
    [TestCase("")]
    [TestCase("  ")]
    public void RequireTenant_MissingTenant_ThrowsArgumentException(string? tenant)
    {
        // Arrange
        // Act
        var action = () => ScheduleKeyHelper.RequireTenant(tenant);
        // Assert
        action.Should().Throw<ArgumentException>();
    }

    // Cenário: Uma chave de agenda é construída e lida pelos prefixos atual e legado.
    // Objetivo: Preservar o identificador e aceitar compatibilidade legada.
    [Test]
    public void MedicalScheduleKeys_ValidAndLegacyKeys_ParsesIdentifiers()
    {
        // Arrange
        var medicalKey = MedicalScheduleKeyHelper.ForMedical(15);
        var patientKey = MedicalScheduleKeyHelper.ForPatient(20);
        // Act
        var medicalParsed = MedicalScheduleKeyHelper.TryParseMedicalId(medicalKey, out var medicalId);
        var legacyParsed = MedicalScheduleKeyHelper.TryParsePatientId("patient:20", out var legacyPatientId);
        var patientParsed = MedicalScheduleKeyHelper.TryParsePatientId(patientKey, out var patientId);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            medicalParsed.Should().BeTrue();
            patientParsed.Should().BeTrue();
            legacyParsed.Should().BeTrue();
            medicalId.Should().Be(15);
            patientId.Should().Be(20);
            legacyPatientId.Should().Be(20);
        }
    }

    // Cenário: Uma chave possui prefixo ou sufixo inválido.
    // Objetivo: Informar que o identificador não pode ser lido.
    [TestCase("Other:2")]
    [TestCase("PatientId:x")]
    [TestCase(null)]
    public void TryParse_InvalidKey_ReturnsFalse(string? key)
    {
        // Arrange
        // Act
        var result = ScheduleKeyHelper.TryParse(key, "PatientId:", out var id);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Should().BeFalse();
            id.Should().Be(0);
        }
    }

    // Cenário: Dois períodos se cruzam, apenas encostam ou possuem fim ausente.
    // Objetivo: Distinguir sobreposição de adjacência.
    [Test]
    public void OverlapHelpers_DifferentPeriods_ReturnExpectedRelationship()
    {
        // Arrange
        var start = new DateTime(2025, 1, 1, 9, 0, 0);
        // Act
        var overlaps = ScheduleOverlapHelper.Overlaps(start, start.AddHours(1), start.AddMinutes(30), start.AddHours(2));
        var adjacent = ScheduleOverlapHelper.IsAdjacentOnly(start, start.AddHours(1), start.AddHours(1), start.AddHours(2));
        var adjacentEndBEqualsStartA = ScheduleOverlapHelper.IsAdjacentOnly(start.AddHours(1), start.AddHours(2), start, start.AddHours(1));
        var nullEndOverlaps = ScheduleOverlapHelper.Overlaps(start, null, start, null);
        var startOnlyRange = SchedulePeriodHelper.NormalizeRange(null, new DateTime(2025, 4, 5), 2024, 2);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            overlaps.Should().BeTrue();
            adjacent.Should().BeTrue();
            adjacentEndBEqualsStartA.Should().BeTrue();
            nullEndOverlaps.Should().BeFalse();
            startOnlyRange.Should().Be(SchedulePeriodHelper.GetMonthRange(2024, 2));
        }
    }

    // Cenário: Um intervalo mensal é normalizado e limites são solicitados.
    // Objetivo: Retornar o mês UTC e restringir ocorrências ao máximo.
    [Test]
    public void SchedulePeriodHelpers_MonthAndOccurrences_ReturnNormalizedValues()
    {
        // Arrange
        var explicitStart = new DateTime(2025, 4, 2);
        var explicitEnd = explicitStart.AddDays(2);
        // Act
        var month = SchedulePeriodHelper.GetMonthRange(2024, 2);
        var explicitRange = SchedulePeriodHelper.NormalizeRange(explicitStart, explicitEnd, 2024, 2);
        var defaultRange = SchedulePeriodHelper.NormalizeRange(explicitStart, null, 2024, 2);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            month.Start.Should().Be(new DateTime(2024, 2, 1, 0, 0, 0, DateTimeKind.Utc));
            month.End.Should().Be(new DateTime(2024, 3, 1, 0, 0, 0, DateTimeKind.Utc));
            explicitRange.Should().Be((explicitStart, explicitEnd));
            defaultRange.Should().Be(month);
            SchedulePeriodHelper.CapOccurrences(0).Should().Be(500);
            SchedulePeriodHelper.CapOccurrences(900).Should().Be(500);
            SchedulePeriodHelper.CapOccurrences(3).Should().Be(3);
        }
    }

    // Cenário: São geradas ocorrências para todos os tipos de recorrência.
    // Objetivo: Materializar datas, duração e limites corretamente.
    [Test]
    public void Materialize_BoundedRecurrences_ReturnsExpectedIntervals()
    {
        // Arrange
        var start = new DateTime(2025, 1, 31, 9, 0, 0);
        RecurrenceMaterializeRequest Request(ERecurrenceCalendarType type) => new()
        {
            StartDateTime = start, EndDateTime = start.AddHours(1), RecurrenceType = type, RecurrenceCount = 2, MaxOccurrences = 10
        };
        // Act
        var none = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest { StartDateTime = start, EndDateTime = start.AddHours(1) });
        var daily = RecurrenceMaterializer.Materialize(Request(ERecurrenceCalendarType.Daily));
        var weekly = RecurrenceMaterializer.Materialize(Request(ERecurrenceCalendarType.Weekly));
        var monthly = RecurrenceMaterializer.Materialize(Request(ERecurrenceCalendarType.Monthly));
        var yearly = RecurrenceMaterializer.Materialize(Request(ERecurrenceCalendarType.Yearly));
        // Assert
        using (Assert.EnterMultipleScope())
        {
            none.Should().ContainSingle().Which.EndDateTime.Should().Be(start.AddHours(1));
            daily.Select(x => x.StartDateTime).Should().BeEquivalentTo([start, start.AddDays(1)], o => o.WithStrictOrdering());
            weekly.Select(x => x.StartDateTime).Should().BeEquivalentTo([start, start.AddDays(7)], o => o.WithStrictOrdering());
            monthly.Select(x => x.StartDateTime).Should().BeEquivalentTo([start, new DateTime(2025, 2, 28, 9, 0, 0)], o => o.WithStrictOrdering());
            yearly.Select(x => x.StartDateTime).Should().BeEquivalentTo([start, start.AddYears(1)], o => o.WithStrictOrdering());
        }
    }

    // Cenário: A janela de trabalho contém horários ocupados e passados.
    // Objetivo: Gerar slots disponíveis de forma sequencial e paralela.
    [Test]
    public void Generate_WorkingWindow_ReturnsAvailabilityAndPastStatus()
    {
        // Arrange
        var window = new TimeSlotWindow { Date = new DateTime(2025, 1, 1), StartWorkingTime = TimeSpan.FromHours(9), EndWorkingTime = TimeSpan.FromHours(11), Interval = TimeSpan.FromHours(1) };
        var busy = new List<(DateTime Start, DateTime End)> { (window.Date.AddHours(10), window.Date.AddHours(11)) };
        // Act
        var sequential = TimeSlotGenerator.Generate(window, busy, window.Date.AddHours(9).AddMinutes(30), false);
        var invalid = TimeSlotGenerator.Generate(new TimeSlotWindow { Date = window.Date, Interval = TimeSpan.Zero }, [], DateTime.UtcNow);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            sequential.Should().HaveCount(24);
            sequential[9].IsAvailable.Should().BeTrue();
            sequential[9].IsPast.Should().BeTrue();
            sequential[10].IsAvailable.Should().BeFalse();
            invalid.Should().BeEmpty();
        }
    }

    // Cenário: recorrências possuem filtros, limites e intervalos inválidos.
    // Objetivo: materializar somente ocorrências permitidas em todos os fluxos de agenda.
    [Test]
    public void Materialize_FilteredAndUnboundedRecurrences_ReturnsExpectedOccurrences()
    {
        // Arrange
        var start = new DateTime(2025, 1, 6, 9, 0, 0); // Monday

        // Act
        var dailyFiltered = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = start, EndDateTime = start.AddHours(1), RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceDays = [DayOfWeek.Monday], RecurrenceEndDate = start.AddDays(8), MaxOccurrences = 10
        });
        var weekly = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = start, EndDateTime = start.AddHours(1), RecurrenceType = ERecurrenceCalendarType.Weekly,
            RecurrenceDays = [DayOfWeek.Monday, DayOfWeek.Wednesday], RecurrenceCount = 3, MaxOccurrences = 10
        });
        var monthlyFiltered = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = start, EndDateTime = start.AddHours(-1), RecurrenceType = ERecurrenceCalendarType.Monthly,
            RecurrenceDays = [DayOfWeek.Tuesday], RecurrenceCount = 1
        });
        var yearlySingle = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = start, EndDateTime = start.AddHours(1), RecurrenceType = ERecurrenceCalendarType.Yearly
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            dailyFiltered.Select(item => item.StartDateTime.DayOfWeek).Should().OnlyContain(day => day == DayOfWeek.Monday);
            dailyFiltered.Should().HaveCount(2);
            weekly.Should().HaveCount(3);
            monthlyFiltered.Should().ContainSingle().Which.Should().Match<RecurrenceInterval>(
                item => item.StartDateTime.DayOfWeek == DayOfWeek.Tuesday && item.EndDateTime == item.StartDateTime);
            yearlySingle.Should().ContainSingle().Which.EndDateTime.Should().Be(start.AddHours(1));
        }
    }

    // Cenário: recorrências sem limites e com fim anterior à data inicial são solicitadas.
    // Objetivo: executar os fluxos sequenciais e os retornos antecipados do materializador.
    [Test]
    public void Materialize_SequentialAndExpiredRecurrences_ReturnsExpectedIntervals()
    {
        // Arrange
        var monday = new DateTime(2025, 1, 6, 9, 0, 0);

        // Act
        var daily = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Daily
        });
        var weekly = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Weekly,
            RecurrenceDays = [DayOfWeek.Sunday]
        });
        var expired = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = monday,
            EndDateTime = monday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Daily,
            RecurrenceEndDate = monday.AddDays(-1)
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            daily.Should().ContainSingle();
            weekly.Should().ContainSingle().Which.StartDateTime.Should().Be(monday.AddDays(6));
            expired.Should().BeEmpty();
        }
    }

    // Cenário: detalhes de conflito possuem chaves, título longo e valores ausentes.
    // Objetivo: produzir uma mensagem útil em todas as variações de apresentação.
    [Test]
    public void ScheduleConflictDetailHelper_ConflictingItems_ReturnsFormattedDetails()
    {
        // Arrange
        var start = new DateTime(2025, 1, 1, 9, 0, 0);
        var requested = new ScheduleCalendarItem { StartDateTime = start, SubjectKey = "PatientId:10" };
        var conflicting = new ScheduleCalendarItem
        {
            StartDateTime = start.AddHours(1),
            EndDateTime = start.AddHours(2),
            SubjectKey = "external",
            Title = new string('A', 81)
        };

        // Act
        var detailed = ScheduleConflictDetailHelper.Create(requested, null, conflicting, null);
        var missing = ScheduleConflictDetailHelper.Create(
            new ScheduleCalendarItem { StartDateTime = start },
            " ",
            new ScheduleCalendarItem { StartDateTime = start, Title = " " },
            null);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            detailed.ErrorCode.Should().Be(ScheduleConflictDetailHelper.ErrorCode);
            detailed.Message.Should().ContainAll("RequestedPatientId=10", "ExistingPatientId=external", "ExistingTitle=" + new string('A', 80) + "…");
            missing.Message.Should().ContainAll("RequestedPatientId=-", "ExistingPatientId=-", "ExistingTitle=-");
        }
    }

    // Cenário: slots suficientes permitem paralelismo e intervalo maior que o dia não gera slots.
    // Objetivo: exercitar as duas estratégias de geração e o retorno antecipado.
    [Test]
    public void Generate_ParallelAndOversizedInterval_ReturnsExpectedSlots()
    {
        // Arrange
        var date = new DateTime(2025, 1, 1);

        // Act
        var parallel = TimeSlotGenerator.Generate(new TimeSlotWindow
        {
            Date = date, StartWorkingTime = TimeSpan.Zero, EndWorkingTime = TimeSpan.FromDays(1), Interval = TimeSpan.FromHours(1)
        }, [], date.AddHours(-1));
        var oversized = TimeSlotGenerator.Generate(new TimeSlotWindow
        {
            Date = date, Interval = TimeSpan.FromDays(2)
        }, [], date);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            parallel.Should().HaveCount(24);
            parallel.Should().OnlyContain(slot => slot.IsAvailable && !slot.IsPast);
            oversized.Should().BeEmpty();
            ScheduleParallel.CpuCount.Should().BeGreaterThan(0);
            ScheduleParallel.MaxAvailableThreads.MaxDegreeOfParallelism.Should().Be(ScheduleParallel.CpuCount);
        }
    }

    // Cenário: recorrências não limitadas filtram a primeira data e avançam por mês e semana.
    // Objetivo: executar os caminhos sequenciais e os limites de materialização.
    [Test]
    public void Materialize_SequentialFilteredRecurrences_ReturnsOnlyEligibleIntervals()
    {
        // Arrange
        var wednesday = new DateTime(2025, 1, 8, 9, 0, 0);

        // Act
        var daily = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = wednesday, EndDateTime = wednesday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Daily, RecurrenceDays = [DayOfWeek.Thursday]
        });
        var weekly = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = wednesday, EndDateTime = wednesday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Weekly, RecurrenceDays = [DayOfWeek.Thursday],
            RecurrenceCount = 1
        });
        var monthly = RecurrenceMaterializer.Materialize(new RecurrenceMaterializeRequest
        {
            StartDateTime = wednesday, EndDateTime = wednesday.AddHours(1),
            RecurrenceType = ERecurrenceCalendarType.Monthly
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            daily.Should().BeEmpty();
            weekly.Should().ContainSingle().Which.StartDateTime.DayOfWeek.Should().Be(DayOfWeek.Thursday);
            monthly.Should().ContainSingle().Which.StartDateTime.Should().Be(wednesday);
        }
    }
}
