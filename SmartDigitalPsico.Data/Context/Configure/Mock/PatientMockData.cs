﻿using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class PatientMockData
    {
        private const string AddressCitySP = "São Paulo";
        public static Patient[] GetMock()
        {
            var newAddPatient = new Patient
            {
                Id = 1,
                Name = "Tiago Thales Mendes",
                Email = "tiago.thales.mendes@andrade.com",
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                Enable = true,
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
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
                 newAddPatient,
                 // Paciente 2
            new Patient
            {
                Id = 2,
                Name = "Ana Luiza Ferreira",
                Email = "ana.luiza@domain.com",
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                Enable = true,
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                CreatedUserId = 2,
                AddressCep = "12345-678",
                AddressCity = AddressCitySP,
                AddressNeighborhood = "Jardins",
                AddressState = AddressCitySP,
                AddressStreet = "Rua das Flores, 123",
                Cpf = "123.456.789-00",
                DateOfBirth = new DateTime(1990, 05, 22, 0, 0, 0, DateTimeKind.Utc),
                Education = "Médio Completo",
                EmergencyContactName = "Carlos Ferreira",
                EmergencyContactPhoneNumber = "(11) 91234-5678",
                MedicalId = 1,
                PhoneNumber = "(11) 4002-8922",
                Profession = "Estudante",
                Rg = "12.345.678-9",
                GenderId = 2
            },

            // Paciente 3
            new Patient
            {
                Id = 3,
                Name = "José Henrique Silva",
                Email = "jose.henrique@domain.com",
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                Enable = true,
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                CreatedUserId = 2,
                AddressCep = "98765-432",
                AddressCity = "Rio de Janeiro",
                AddressNeighborhood = "Copacabana",
                AddressState = "Rio de Janeiro",
                AddressStreet = "Av. Atlântica, 456",
                Cpf = "987.654.321-99",
                DateOfBirth = new DateTime(1985, 08, 15, 0, 0, 0, DateTimeKind.Utc),
                Education = "Superior Completo",
                EmergencyContactName = "Mariana Silva",
                EmergencyContactPhoneNumber = "(21) 99876-5432",
                MedicalId = 1,
                PhoneNumber = "(21) 3000-7000",
                Profession = "Advogado",
                Rg = "98.765.432-1",
                GenderId = 1
            },

            // Paciente 4
            new Patient
            {
                Id = 4,
                Name = "Maria Clara Oliveira",
                Email = "maria.clara@domain.com",
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                Enable = true,
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                CreatedUserId = 2,
                AddressCep = "45678-123",
                AddressCity = "Belo Horizonte",
                AddressNeighborhood = "Savassi",
                AddressState = "Minas Gerais",
                AddressStreet = "Rua dos Ipês, 789",
                Cpf = "456.789.123-10",
                DateOfBirth = new DateTime(1975, 12, 01, 0, 0, 0, DateTimeKind.Utc),
                Education = "Pós-Graduação",
                EmergencyContactName = "Fernando Oliveira",
                EmergencyContactPhoneNumber = "(31) 97654-3210",
                MedicalId = 1,
                PhoneNumber = "(31) 4004-3003",
                Profession = "Arquiteta",
                Rg = "45.678.912-0",
                GenderId = 2
            },

            // Paciente 5
            new Patient
            {
                Id = 5,
                Name = "Gabriel Santos",
                Email = "gabriel.santos@domain.com",
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                Enable = true,
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                CreatedUserId = 2,
                AddressCep = "65432-789",
                AddressCity = "Curitiba",
                AddressNeighborhood = "Centro Cívico",
                AddressState = "Paraná",
                AddressStreet = "Av. Paraná, 987",
                Cpf = "654.321.987-88",
                DateOfBirth = new DateTime(2000, 07, 18, 0, 0, 0, DateTimeKind.Utc),
                Education = "Fundamental Completo",
                EmergencyContactName = "Lucas Santos",
                EmergencyContactPhoneNumber = "(41) 98432-1234",
                MedicalId = 1,
                PhoneNumber = "(41) 3020-8989",
                Profession = "Atendente",
                Rg = "65.432.198-7",
                GenderId = 1
            },
            new Patient
        {
            Id = 6,
            Name = "Laura Carolina Costa",
            Email = "laura.costa@example.com",
            CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
            Enable = true,
            LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
            ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
            CreatedUserId = 2,
            AddressCep = "89010-123",
            AddressCity = "Blumenau",
            AddressNeighborhood = "Centro",
            AddressState = "Santa Catarina",
            AddressStreet = "Rua das Flores, 45",
            Cpf = "456.123.789-09",
            DateOfBirth = new DateTime(1990, 6, 15, 0, 0, 0, DateTimeKind.Utc),
            Education = "Médio Completo",
            EmergencyContactName = "Ana Costa",
            EmergencyContactPhoneNumber = "(47) 99987-6543",
            MedicalId = 1,
            PhoneNumber = "(47) 3030-2020",
            Profession = "Estilista",
            Rg = "12.345.678-9",
            GenderId = 2
        },
        new Patient
        {
            Id = 7,
            Name = "Diego Rafael Almeida",
            Email = "diego.almeida@example.com",
            CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
            Enable = true,
            LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
            ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
            CreatedUserId = 2,
            AddressCep = "01310-100",
            AddressCity = AddressCitySP,
            AddressNeighborhood = "Bela Vista",
            AddressState = AddressCitySP,
            AddressStreet = "Avenida Paulista, 1500",
            Cpf = "123.456.789-00",
            DateOfBirth = new DateTime(1985, 11, 30, 0, 0, 0, DateTimeKind.Utc),
            Education = "Pós-Graduação",
            EmergencyContactName = "Marina Almeida",
            EmergencyContactPhoneNumber = "(11) 98888-1234",
            MedicalId = 1,
            PhoneNumber = "(11) 3111-4567",
            Profession = "Analista de Sistemas",
            Rg = "23.456.789-0",
            GenderId = 1
        }
            ];
        }
    }
}