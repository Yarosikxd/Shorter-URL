using DataBase.Enums;
using System.ComponentModel.DataAnnotations;

namespace DataBase.Models
{
    public class UserTable
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public RoleIdEnum RoleId { get; set; }
    }
}
