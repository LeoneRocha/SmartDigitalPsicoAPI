namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class RoleGroupUser
    {    
        public User User { get; set; }         
        public long UserId { get; set; }

        public RoleGroup RoleGroup { get; set; }
        public long RoleGroupId { get; set; } 
    }
}