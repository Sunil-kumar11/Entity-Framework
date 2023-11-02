using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entity_Framework.Models
{
    public class IdentityRole
    {
        [Column("UserRoleId"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long __Id { get; private set; }

        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int TbId { get; set; }

        [Required]
        public long UserId { get; set; }

        [Required]
        public long RoleId { get; set; }
    }
}
