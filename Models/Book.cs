using System.ComponentModel.DataAnnotations;

namespace LibraryManagmentCS.Models
{
    public class Book
    {
        [Key]
        public int Id_book { get; set; }
        public int Id_author { get; set; }
        public int Id_department { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Genre { get; set; } = null!;
    }
}
