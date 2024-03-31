using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Configure
{
    public class PatientMockData : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> modelBuilder)
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
                DateOfBirth = new DateTime(1960, 03, 11),
                Education = "Superior",
                EmergencyContactName = "Milena Isabelly Vanessa",
                EmergencyContactPhoneNumber = "(73) 98540-4268",
                MedicalId = 1,
                PhoneNumber = "(73) 2877-3408",
                Profession = "Professor",
                Rg = "13.809.283-7",
                GenderId = (long)1,
            };
            return [
                 newAddPatient
            ];
        }
    }
}