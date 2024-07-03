using System.ComponentModel.DataAnnotations;

namespace LibraryManagmentCS.Models
{
    public class User
    {
        [Key]
        public int Id_user { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
