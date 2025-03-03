using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class LeavesMockData
    {
        private const string LanguagePtBR = "pt-BR";

        public static Leaves[] GetMock()
        {
            var currentYear = DateTime.Now.Year;

            // Lista dos principais feriados no Brasil
            var holidays = new List<Leaves>
        {
            // Ano Novo
            new Leaves
            {
                Id = 1,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 1, 1, 0, 0, 0, DateTimeKind.Local),
                Description = "Ano Novo",
                Language = LanguagePtBR,
                IsRecurring = true
            },
            // Carnaval (exemplo de data variável: terça-feira de Carnaval em 2025)
            new Leaves
            {
                Id = 2,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 2, 25, 0, 0, 0, DateTimeKind.Local),
                Description = "Carnaval",
                Language = LanguagePtBR,
                IsRecurring = true
            },
            // Sexta-feira Santa (exemplo de data variável em 2025)
            new Leaves
            {
                Id = 3,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 4, 18, 0, 0, 0, DateTimeKind.Local),
                Description = "Sexta-feira Santa",
                Language = LanguagePtBR,
                IsRecurring = true
            },
            // Tiradentes
            new Leaves
            {
                Id = 4,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 4, 21, 0, 0, 0, DateTimeKind.Local),
                Description = "Tiradentes",
                Language = LanguagePtBR,
                IsRecurring = true
            },
            // Dia do Trabalho
            new Leaves
            {
                Id = 5,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 5, 1, 0, 0, 0, DateTimeKind.Local),
                Description = "Dia do Trabalho",
                Language = LanguagePtBR,
                IsRecurring = true
            },
            // Corpus Christi (exemplo de data variável em 2025)
            new Leaves
            {
                Id = 6,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 6, 19, 0, 0, 0, DateTimeKind.Local),
                Description = "Corpus Christi",
                Language = LanguagePtBR,
                IsRecurring = true
            },
            // Independência do Brasil
            new Leaves
            {
                Id = 7,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 9, 7, 0, 0, 0, DateTimeKind.Local),
                Description = "Independência do Brasil",
                Language = LanguagePtBR,
                IsRecurring = true
            },
            // Nossa Senhora Aparecida
            new Leaves
            {
                Id = 8,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 10, 12, 0, 0, 0, DateTimeKind.Local),
                Description = "Nossa Senhora Aparecida",
                Language = LanguagePtBR,
                IsRecurring = true
            },
            // Finados
            new Leaves
            {
                Id = 9,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 11, 2, 0, 0, 0, DateTimeKind.Local),
                Description = "Finados",
                Language = LanguagePtBR,
                IsRecurring = true
            },
            // Proclamação da República
            new Leaves
            {
                Id = 10,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 11, 15, 0, 0, 0, DateTimeKind.Local),
                Description = "Proclamação da República",
                Language = LanguagePtBR,
                IsRecurring = true
            },
            // Natal
            new Leaves
            {
                Id = 11,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 12, 25, 0, 0, 0, DateTimeKind.Local),
                Description = "Natal",
                Language = LanguagePtBR,
                IsRecurring = true
            }
        };

            return holidays.ToArray();
        }
    }

}
