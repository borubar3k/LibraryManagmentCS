using System.ComponentModel.DataAnnotations;

namespace LibraryManagmentCS.Models
{
    public class Department
    {
        [Key]
        public int Id_department { get; set; }
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
