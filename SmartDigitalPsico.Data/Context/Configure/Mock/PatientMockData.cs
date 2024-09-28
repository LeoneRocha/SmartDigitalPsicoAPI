using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public class PatientMockData : EntityBaseConfiguration<Patient>
    {
        public PatientMockData(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<Patient> modelBuilder)
        {
            modelBuilder.HasData(GetMock());
        }
        public static Patient[] GetMock()
        {
            var newAddPatient = new Patient
            {
                Id = 1,
                Name = "Tiago Thales Mendes",
                Email = "tiago.thales.mendes@andrade.com",
                CreatedDate = DataHelper.GetDateTimeNow(),
                Enable = true,
                LastAccessDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                CreatedUserId = 2,
                AddressCep = "45675-970",
                AddressCity = "Aurelino Leal",
                AddressNeighborhood = "Centro",
                AddressState = "Bahia",
                AddressStreet = "Avenida Presidente Médici 264",
                Cpf = "947.846.605-42",
                DateOfBirth = new DateTime(1960, 03, 11, 0, 0, 0, DateTimeKind.Utc),
                Education = "Superior",
                EmergencyContactName = "Milena Isabelly Vanessa",
                EmergencyContactPhoneNumber = "(73) 98540-4268",
                MedicalId = 1,
                PhoneNumber = "(73) 2877-3408",
                Profession = "Professor",
                Rg = "13.809.283-7",
                GenderId = 1,
            };
            return [
                 newAddPatient
            ];
        }
    }
}