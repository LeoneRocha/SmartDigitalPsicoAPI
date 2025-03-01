using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class LeavesMockData
    {
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
                StartDate = new DateTime(currentYear, 1, 1),
                Description = "Ano Novo",
                Language = "pt-BR",
                IsRecurring = true
            },
            // Carnaval (exemplo de data variável: terça-feira de Carnaval em 2025)
            new Leaves
            {
                Id = 2,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(2025, 2, 25),
                Description = "Carnaval",
                Language = "pt-BR",
                IsRecurring = true
            },
            // Sexta-feira Santa (exemplo de data variável em 2025)
            new Leaves
            {
                Id = 3,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(2025, 4, 18),
                Description = "Sexta-feira Santa",
                Language = "pt-BR",
                IsRecurring = true
            },
            // Tiradentes
            new Leaves
            {
                Id = 4,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 4, 21),
                Description = "Tiradentes",
                Language = "pt-BR",
                IsRecurring = true
            },
            // Dia do Trabalho
            new Leaves
            {
                Id = 5,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 5, 1),
                Description = "Dia do Trabalho",
                Language = "pt-BR",
                IsRecurring = true
            },
            // Corpus Christi (exemplo de data variável em 2025)
            new Leaves
            {
                Id = 6,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(2025, 6, 19),
                Description = "Corpus Christi",
                Language = "pt-BR",
                IsRecurring = true
            },
            // Independência do Brasil
            new Leaves
            {
                Id = 7,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 9, 7),
                Description = "Independência do Brasil",
                Language = "pt-BR",
                IsRecurring = true
            },
            // Nossa Senhora Aparecida
            new Leaves
            {
                Id = 8,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 10, 12),
                Description = "Nossa Senhora Aparecida",
                Language = "pt-BR",
                IsRecurring = true
            },
            // Finados
            new Leaves
            {
                Id = 9,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 11, 2),
                Description = "Finados",
                Language = "pt-BR",
                IsRecurring = true
            },
            // Proclamação da República
            new Leaves
            {
                Id = 10,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 11, 15),
                Description = "Proclamação da República",
                Language = "pt-BR",
                IsRecurring = true
            },
            // Natal
            new Leaves
            {
                Id = 11,
                Enable = true,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                StartDate = new DateTime(currentYear, 12, 25),
                Description = "Natal",
                Language = "pt-BR",
                IsRecurring = true
            }
        };

            return holidays.ToArray();
        }
    }

}
