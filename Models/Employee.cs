using System.ComponentModel.DataAnnotations;

namespace LibraryManagmentCS.Models
{
    public class Employee
    {
        [Key]
        public int Id_employee { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Pesel { get; set; } = null!;
        public string DateBorn { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Id_department { get; set; }
    }
}
