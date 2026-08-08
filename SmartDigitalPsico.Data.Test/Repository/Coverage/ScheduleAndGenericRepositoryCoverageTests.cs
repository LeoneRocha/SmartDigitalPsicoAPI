using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Data.Repository.Schedule;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.Repository.Coverage;

[TestFixture]
public class ScheduleAndGenericRepositoryCoverageTests : BaseTests
{
    // Cenário: pacotes de agenda com sobreposição, subject distinto e pacote desabilitado.
    // Objetivo: validar filtros de overlap, token, conflito e metadados dos itens.
    [Test]
    public async Task ScheduleQueries_FilterPackagesAndStampItemMetadata()
    {
        // Arrange
        var now = DateTime.UtcNow.Date.AddHours(10);
        var selected = Package("tenant", "owner", "subject", "one", now, now.AddHours(2), now, now.AddHours(1));
        var otherSubject = Package("tenant", "owner", "other", "two", now, now.AddHours(2), now.AddMinutes(30), now.AddHours(1));
        var disabled = Package("tenant", "owner", "subject", "disabled", now, now.AddHours(2), now, now.AddHours(1));
        disabled.Enable = false;
        _mockContext!.ScheduleCalendars.AddRange(selected, otherSubject, disabled);
        await _mockContext.SaveChangesAsync();
        var repository = new ScheduleCalendarRepository(_mockContext);

        // Act
        var overlapping = await repository.GetOverlappingByOwnerAsync("tenant", "owner", now.AddMinutes(15), now.AddHours(1));
        var byToken = await repository.GetByTokenAsync("one", "owner", "subject");
        var tokenWithoutSubject = await repository.GetByTokenFromStartAsync("one", "owner", null, now);
        var conflicts = await repository.GetConflictingItemsAsync("tenant", "owner", now.AddMinutes(15), now.AddHours(1));
        var item = await repository.GetItemAsync("tenant", "owner", "subject", now);
        var ownerItems = await repository.GetItemsForOwnerAsync("tenant", "owner", now.AddMinutes(15), now.AddHours(1));
        var subjectItems = await repository.GetItemsForOwnerSubjectAsync("tenant", "owner", "subject", now, now.AddHours(1));

        // Assert
        overlapping.Should().HaveCount(2);
        byToken.Should().ContainSingle();
        tokenWithoutSubject.Should().ContainSingle();
        conflicts.Should().HaveCount(2);
        item.Should().NotBeNull();
        item!.PackageId.Should().Be(selected.Id);
        item.OwnerKey.Should().Be("owner");
        item.SubjectKey.Should().Be("subject");
        item.TokenRecurrence.Should().Be("one");
        ownerItems.Should().HaveCount(2);
        subjectItems.Should().ContainSingle();
        (await repository.HasConflictAsync("tenant", "owner", now)).Should().BeTrue();
        (await repository.GetByUniqueTokenAsync("one"))!.Id.Should().Be(selected.Id);
    }

    // Cenário: inclusão e exclusão em lote de pacotes de agenda.
    // Objetivo: garantir que AddRange e DeleteRange persistem e removem corretamente.
    [Test]
    public async Task ScheduleMutations_AddAndDeleteRanges()
    {
        // Arrange
        var now = DateTime.UtcNow;
        var package = Package("tenant", "owner", null, "range", now, now.AddHours(1), now, now.AddMinutes(30));
        var repository = new ScheduleCalendarRepository(_mockContext!);

        // Act
        await repository.AddRangeAsync([package]);

        // Assert
        (await repository.GetByUniqueTokenAsync("range")).Should().NotBeNull();

        await repository.DeleteRangeAsync([package]);
        (await repository.GetByUniqueTokenAsync("range")).Should().BeNull();
        (await repository.HasConflictAsync("tenant", "owner", now)).Should().BeFalse();
    }

    // Cenário: ScheduleData nulo, EndDateTime nulo e subjectKey em branco.
    // Objetivo: cobrir ramos restantes de HasConflict/GetItem/GetItems/StampPackageMetadata.
    [Test]
    public async Task ScheduleQueries_NullScheduleDataAndEndDate_CoversRemainingBranches()
    {
        // Arrange
        var now = DateTime.UtcNow.Date.AddHours(10);
        // InMemory rejeita ScheduleData null; desliga null-checks neste contexto.
        var options = new DbContextOptionsBuilder<SmartDigitalPsicoDataContextMySql>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString(), b => b.EnableNullChecks(false))
            .Options;
        await using var context = new SmartDigitalPsicoDataContextMySql(options);
        var nullData = Package("tenant", "owner", "subject", "null-data", now, now.AddHours(2), now, now.AddHours(1));
        nullData.ScheduleData = null!;
        var nullEnd = Package("tenant", "owner", "subject", "null-end", now, now.AddHours(2), now, now);
        nullEnd.ScheduleData =
        [
            new ScheduleCalendarItem
            {
                Title = "n",
                StartDateTime = now,
                EndDateTime = null,
                TokenRecurrence = "  ",
                RecurrenceDays = null!
            }
        ];
        context.ScheduleCalendars.AddRange(nullData, nullEnd);
        await context.SaveChangesAsync();
        var repository = new ScheduleCalendarRepository(context);

        // Act
        var conflict = await repository.HasConflictAsync("tenant", "owner", now);
        var itemAnySubject = await repository.GetItemAsync("tenant", "owner", null, now);
        var itemBlankSubject = await repository.GetItemAsync("tenant", "owner", " ", now);
        var subjectItems = await repository.GetItemsForOwnerSubjectAsync("tenant", "owner", null, now, now.AddHours(1));
        var blankSubjectItems = await repository.GetItemsForOwnerSubjectAsync("tenant", "owner", "  ", now, now.AddHours(1));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            conflict.Should().BeTrue();
            itemAnySubject.Should().NotBeNull();
            itemAnySubject!.TokenRecurrence.Should().Be("null-end");
            itemBlankSubject.Should().NotBeNull();
            subjectItems.Should().NotBeEmpty();
            blankSubjectItems.Should().NotBeEmpty();
        }

        // Extra: EndDateTime preenchido e filtro por janela (ramos ?? EndDateTime).
        var closed = Package("tenant", "owner", "subject", "closed-end", now, now.AddHours(3), now, now.AddHours(2));
        closed.ScheduleData =
        [
            new ScheduleCalendarItem
            {
                Title = "closed",
                StartDateTime = now,
                EndDateTime = now.AddHours(2),
                TokenRecurrence = "closed"
            }
        ];
        context.ScheduleCalendars.Add(closed);
        await context.SaveChangesAsync();
        var midConflict = await repository.HasConflictAsync("tenant", "owner", now.AddMinutes(30));
        var beforeConflict = await repository.HasConflictAsync("tenant", "owner", now.AddHours(-1));
        var windowItems = await repository.GetItemsForOwnerSubjectAsync("tenant", "owner", "subject", now, now.AddHours(1));
        midConflict.Should().BeTrue();
        beforeConflict.Should().BeFalse();
        windowItems.Should().NotContain(i => i.TokenRecurrence == "closed");
    }

    // Cenário: conflito parcial, token em branco e filtro de overlap em ExpandOverlappingItems.
    // Objetivo: cobrir ramos restantes de HasConflict/GetItems/StampPackageMetadata.
    [Test]
    public async Task ScheduleQueries_PartialOverlapAndBlankToken_CoversRemainingBranches()
    {
        // Arrange
        var now = DateTime.UtcNow.Date.AddHours(10);
        var partial = Package("tenant", "owner", "subject", "partial", now, now.AddHours(4), now.AddMinutes(30), now.AddHours(1));
        partial.ScheduleData =
        [
            new ScheduleCalendarItem
            {
                Title = "partial",
                StartDateTime = now.AddMinutes(30),
                EndDateTime = now.AddHours(1),
                TokenRecurrence = "   "
            }
        ];
        var nonOverlap = Package("tenant", "owner", "subject", "outside", now, now.AddHours(4), now.AddHours(3), now.AddHours(4));
        _mockContext!.ScheduleCalendars.AddRange(partial, nonOverlap);
        await _mockContext.SaveChangesAsync();
        var repository = new ScheduleCalendarRepository(_mockContext);

        // Act
        var conflictPartial = await repository.HasConflictAsync("tenant", "owner", now.AddMinutes(45));
        var ownerItems = await repository.GetItemsForOwnerAsync("tenant", "owner", now, now.AddHours(2));
        var expanded = await repository.GetConflictingItemsAsync("tenant", "owner", now.AddMinutes(15), now.AddHours(2));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            conflictPartial.Should().BeTrue();
            ownerItems.Should().NotBeEmpty();
            ownerItems.Should().Contain(i => i.TokenRecurrence == "partial");
            expanded.Should().NotBeEmpty();
        }
    }

    // Cenário: operações CRUD e variantes de consulta do GenericRepository.
    // Objetivo: cobrir Create, Exists, Find*, Update, EnableOrDisable e Delete.
    [Test]
    public async Task GenericRepository_CoversCrudAndQueryVariants()
    {
        // Arrange
        var repository = new ApplicationCacheLogRepository(_mockContext!);

        // Act
        var created = await repository.Create(new ApplicationCacheLog { CacheId = "cache-1", CacheKey = "key" });

        // Assert
        (await repository.Exists(created.Id)).Should().BeTrue();
        (await repository.FindAll()).Should().ContainSingle();
        (await repository.FindByID(created.Id)).Id.Should().Be(created.Id);
        (await repository.FindByID(created.Id, _ => { })).Id.Should().Be(created.Id);
        (await repository.FindByID(created.Id, [])).Id.Should().Be(created.Id);
        (await repository.FindAsync(created.Id, []))!.Id.Should().Be(created.Id);
        (await repository.FindByCustomWhere(x => x.CacheId == "cache-1")).Should().ContainSingle();
        (await repository.FindByCustomWhereWithIncludes(x => x.CacheKey == "key")).Should().ContainSingle();
        (await repository.GetCount(x => x.CacheId == "cache-1")).Should().Be(1);
        await repository.FindExistsByID(created.Id);

        created.CacheKey = "updated";
        (await repository.Update(created)).CacheKey.Should().Be("updated");
        (await repository.EnableOrDisable(created.Id)).Should().BeTrue();
        (await repository.Delete(created.Id)).Should().BeTrue();
        (await repository.Exists(created.Id)).Should().BeFalse();
        (await repository.Delete(999999)).Should().BeTrue();
        await Assert.ThatAsync(async () => await repository.Update(new ApplicationCacheLog { Id = 999999 }), Throws.TypeOf<InvalidOperationException>());
    }

    private static ScheduleCalendar Package(string tenant, string owner, string? subject, string token, DateTime start, DateTime end, DateTime itemStart, DateTime itemEnd) =>
        new()
        {
            TenantKey = tenant,
            OwnerKey = owner,
            SubjectKey = subject,
            UniqueToken = token,
            Enable = true,
            StartPeriod = start,
            EndPeriod = end,
            ScheduleData =
            [
                new ScheduleCalendarItem
                {
                    Title = token,
                    StartDateTime = itemStart,
                    EndDateTime = itemEnd,
                    TokenRecurrence = string.Empty
                }
            ]
        };

    private sealed class ApplicationCacheLogRepository : SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<ApplicationCacheLog>
    {
        public ApplicationCacheLogRepository(SmartDigitalPsico.Core.SDK.Data.Context.Interface.IEntityDataContext context)
            : base(context)
        {
        }
    }
}
