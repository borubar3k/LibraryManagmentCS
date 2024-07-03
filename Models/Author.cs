using System.ComponentModel.DataAnnotations;

namespace LibraryManagmentCS.Models
{
    public class Author
    {
        [Key]
        public int Id_author { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Country { get; set; } = null!;
    }
}
