
using System.ComponentModel.DataAnnotations;

namespace DataBase.Models
{
    public class UrlTable
    {
        [Key]
        public int Id { get; set; }
        public string OriginalUrl { get; set; }
        public string ShortUrl { get; set; }
        public DateTime DateMake { get; set; }
        public int UserId { get; set; }
        public UserTable User { get; set; }
    }
}
