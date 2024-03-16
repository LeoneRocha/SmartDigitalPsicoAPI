using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    [Table("MedicalFile", Schema = "dbo")]
    public class MedicalFile : FileBase, IEntityBaseLogUser
    {
        #region Relationship 
        [Required]
        public Medical Medical { get; set; }

        [ForeignKey("MedicalId")]
        public long MedicalId { get; set; }

        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }

        [ForeignKey("CreatedUserId")]
        public long? CreatedUserId { get; set; }

        [ForeignKey("ModifyUserId")]
        public long? ModifyUserId { get; set; }
        #endregion Relationship

    }
}