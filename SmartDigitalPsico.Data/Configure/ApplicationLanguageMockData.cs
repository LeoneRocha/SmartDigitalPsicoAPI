using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Configure
{
    public class ApplicationLanguageMockData : IEntityTypeConfiguration<ApplicationLanguage>
    {
        public void Configure(EntityTypeBuilder<ApplicationLanguage> modelBuilder)
        {
            modelBuilder.HasData(GetMock());
        }

        public static ApplicationLanguage[] GetMock()
        {
            return [
              new ApplicationLanguage
            {
                Id = 1,
                Enable = true,
                Language = "pt-BR",
                Description = "Registro atualizado",
                LanguageKey = "RegisterUpdated",
                ResourceKey = "SharedResource",
                LanguageValue = "Registro atualizado",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 2,
                Enable = true,
                Language = "pt-BR",
                Description = "Default",
                LanguageKey = "Default_ptbr",
                ResourceKey = "ApplicationLanguage",
                LanguageValue = "Padrão",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 3,
                Enable = true,
                Language = "pt-BR",
                Description = "Registro encontrado",
                LanguageKey = "RegisterIsFound",
                ResourceKey = "SharedResource",
                LanguageValue = "Registro encontrado",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 4,
                Enable = true,
                Language = "pt-BR",
                Description = "Registro não encontrado",
                LanguageKey = "RegisterIsNotFound",
                ResourceKey = "SharedResource",
                LanguageValue = "Registro não encontrado",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 5,
                Enable = true,
                Language = "pt-BR",
                Description = "Registro existe",
                LanguageKey = "RegisterExist",
                ResourceKey = "SharedResource",
                LanguageValue = "Registro existe",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 6,
                Enable = true,
                Language = "pt-BR",
                Description = "Registro deletado",
                LanguageKey = "RegisterDeleted",
                ResourceKey = "SharedResource",
                LanguageValue = "Registro deletado",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 7,
                Enable = true,
                Language = "pt-BR",
                Description = "Registro localizado",
                LanguageKey = "RegisterFind",
                ResourceKey = "SharedResource",
                LanguageValue = "Registro localizado",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 8,
                Enable = true,
                Language = "pt-BR",
                Description = "Registros contabilizados",
                LanguageKey = "RegisterCounted",
                ResourceKey = "SharedResource",
                LanguageValue = "Registros contabilizados",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 9,
                Enable = true,
                Language = "pt-BR",
                Description = "Registro criado",
                LanguageKey = "RegisterCreated",
                ResourceKey = "SharedResource",
                LanguageValue = "Registro criado",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 10,
                Enable = true,
                Language = "pt-BR",
                Description = "A descrição não pode ser vazia",
                LanguageKey = "ErrorValidator_Description_Null",
                ResourceKey = "SharedResource",
                LanguageValue = "A descrição não pode ser vazia",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 11,
                Enable = true,
                Language = "pt-BR",
                Description = "O idoma não pode ser vazio",
                LanguageKey = "ErrorValidator_Language_Null",
                ResourceKey = "SharedResource",
                LanguageValue = "O idoma não pode ser vazio",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 12,
                Enable = true,
                Language = "pt-BR",
                Description = "O idoma não pode ultrapassar {MaxLength}",
                LanguageKey = "ErrorValidator_Language_MaximumLength",
                ResourceKey = "SharedResource",
                LanguageValue = "O idoma não pode ultrapassar {MaxLength}",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 13,
                Enable = true,
                Language = "pt-BR",
                Description = "Válido",
                LanguageKey = "LangValid",
                ResourceKey = "SharedResource",
                LanguageValue = "Válido",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 14,
                Enable = true,
                Language = "pt-BR",
                Description = "Ocorreram erros!",
                LanguageKey = "LangErrors",
                ResourceKey = "SharedResource",
                LanguageValue = "Ocorreram erros!",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 15,
                Enable = true,
                Language = "pt-BR",
                Description = "O medico deve ser informado.",
                LanguageKey = "ErrorValidator_MedicalId_Null",
                ResourceKey = "SharedResource",
                LanguageValue = "O medico deve ser informado.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 16,
                Enable = true,
                Language = "pt-BR",
                Description = "O medico informado não existe.",
                LanguageKey = "ErrorValidator_MedicalId_NotFound",
                ResourceKey = "SharedResource",
                LanguageValue = "O medico informado não existe.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 17,
                Enable = true,
                Language = "pt-BR",
                Description = "O medico infomado deve ser o mesmo logado. Medicos",
                LanguageKey = "ErrorValidator_Medical_Changed",
                ResourceKey = "SharedResource",
                LanguageValue = "O medico infomado deve ser o mesmo logado. Medicos nao podem criar arquivos de outro medico.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 18,
                Enable = true,
                Language = "pt-BR",
                Description = "O nome não pode ser vazio",
                LanguageKey = "ErrorValidator_Name_Null",
                ResourceKey = "SharedResource",
                LanguageValue = "O nome não pode ser vazio",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 19,
                Enable = true,
                Language = "pt-BR",
                Description = "O Login não pode ser vazio.",
                LanguageKey = "ErrorValidator_Login_Null",
                ResourceKey = "SharedResource",
                LanguageValue = "O Login não pode ser vazio.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 20,
                Enable = true,
                Language = "pt-BR",
                Description = "Login deve ser unico.",
                LanguageKey = "ErrorValidator_Login_Unique",
                ResourceKey = "SharedResource",
                LanguageValue = "Login deve ser unico.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 21,
                Enable = true,
                Language = "pt-BR",
                Description = "O Email não pode ser vazio",
                LanguageKey = "ErrorValidator_Email_Null",
                ResourceKey = "SharedResource",
                LanguageValue = "O Email não pode ser vazio",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 22,
                Enable = true,
                Language = "pt-BR",
                Description = "O Email é invalido.",
                LanguageKey = "ErrorValidator_Email_Invalid",
                ResourceKey = "SharedResource",
                LanguageValue = "O Email é invalido.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 23,
                Enable = true,
                Language = "pt-BR",
                Description = "O Email deve ser unico.",
                LanguageKey = "ErrorValidator_Email_Unique",
                ResourceKey = "SharedResource",
                LanguageValue = "O Email deve ser unico.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 24,
                Enable = true,
                Language = "pt-BR",
                Description = "O Credenciamento não pode ser vazio.",
                LanguageKey = "ErrorValidator_Accreditation_Null",
                ResourceKey = "SharedResource",
                LanguageValue = "O Credenciamento não pode ser vazio.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 25,
                Enable = true,
                Language = "pt-BR",
                Description = "O Credenciamento deve ser unico.",
                LanguageKey = "ErrorValidator_Accreditation_Unique",
                ResourceKey = "SharedResource",
                LanguageValue = "O Credenciamento deve ser unico.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 26,
                Enable = true,
                Language = "pt-BR",
                Description = "O medico infomado deve ser o mesmo logado. Medicos",
                LanguageKey = "ErrorValidator_MedicalCreated_Invalid",
                ResourceKey = "SharedResource",
                LanguageValue = "O medico infomado deve ser o mesmo logado. Medicos nao podem criar arquivos de outro medico.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 27,
                Enable = true,
                Language = "pt-BR",
                Description = "O medico infomado deve ser o mesmo logado. Medicos",
                LanguageKey = "ErrorValidator_MedicalModify_Invalid",
                ResourceKey = "SharedResource",
                LanguageValue = "O medico infomado deve ser o mesmo logado. Medicos nao podem modificar arquivos de outro medico.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
             new ApplicationLanguage
             {
                 Id = 28,
                 Enable = true,
                 Language = "pt-BR",
                 Description = "O Paciente deve ser informado.",
                 LanguageKey = "ErrorValidator_Patient_Null",
                 ResourceKey = "SharedResource",
                 LanguageValue = "O Paciente deve ser informado.",
                 CreatedDate = DataHelper.GetDateTimeNow(),
                 ModifyDate = DataHelper.GetDateTimeNow(),
                 LastAccessDate = DataHelper.GetDateTimeNow()
             },
            new ApplicationLanguage
            {
                Id = 29,
                Enable = true,
                Language = "pt-BR",
                Description = "O Paciente informado não existe.",
                LanguageKey = "ErrorValidator_Patient_NotFound",
                ResourceKey = "SharedResource",
                LanguageValue = "O Paciente informado não existe.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 30,
                Enable = true,
                Language = "pt-BR",
                Description = "O Paciente não pode ser alterado.",
                LanguageKey = "ErrorValidator_Patient_Changed",
                ResourceKey = "SharedResource",
                LanguageValue = "O Paciente não pode ser alterado.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 31,
                Enable = true,
                Language = "pt-BR",
                Description = "Informações do paciente não podem ser adicionadas ",
                LanguageKey = "ErrorValidator_Patient_Medical_Created",
                ResourceKey = "SharedResource",
                LanguageValue = "Informações do paciente não podem ser adicionadas por outro medico e/ou usuario.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 32,
                Enable = true,
                Language = "pt-BR",
                Description = "Informações do paciente não podem ser modificadas ",
                LanguageKey = "ErrorValidator_Patient_Medical_Modify",
                ResourceKey = "SharedResource",
                LanguageValue = "Informações do paciente não podem ser modificadas por outro medico e/ou usuario.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 33,
                Enable = true,
                Language = "pt-BR",
                Description = "O Usuário que está criando deve ser informado.",
                LanguageKey = "ErrorValidator_CreatedUser_Null",
                ResourceKey = "SharedResource",
                LanguageValue = "O Usuário que está criando deve ser informado.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 34,
                Enable = true,
                Language = "pt-BR",
                Description = "A anotação não pode ser vazia.",
                LanguageKey = "ErrorValidator_Annotation_Null",
                ResourceKey = "SharedResource",
                LanguageValue = "A anotação não pode ser vazia.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 35,
                Enable = true,
                Language = "pt-BR",
                Description = "A data da anotação não pode ser vazia.",
                LanguageKey = "ErrorValidator_AnnotationDate_Null",
                ResourceKey = "SharedResource",
                LanguageValue = "A data da anotação não pode ser vazia.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 36,
                Enable = true,
                Language = "pt-BR",
                Description = "Data de nascimento invalido",
                LanguageKey = "ErrorValidator_DateOfBirth_Invalid",
                ResourceKey = "SharedResource",
                LanguageValue = "Data de nascimento invalido",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 37,
                Enable = true,
                Language = "pt-BR",
                Description = "O Rg não pode ser vazio.",
                LanguageKey = "ErrorValidator_RG_Null",
                ResourceKey = "SharedResource",
                LanguageValue = "O Rg não pode ser vazio.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            },
            new ApplicationLanguage
            {
                Id = 38,
                Enable = true,
                Language = "pt-BR",
                Description = "O CPF não pode ser vazio.",
                LanguageKey = "ErrorValidator_CPF_Null",
                ResourceKey = "SharedResource",
                LanguageValue = "O CPF não pode ser vazio.",
                CreatedDate = DataHelper.GetDateTimeNow(),
                ModifyDate = DataHelper.GetDateTimeNow(),
                LastAccessDate = DataHelper.GetDateTimeNow()
            }
            ];
        }
    }
}