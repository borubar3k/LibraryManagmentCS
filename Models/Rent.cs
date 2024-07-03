using System.ComponentModel.DataAnnotations;

namespace LibraryManagmentCS.Models
{
    public class Rent
    {
        [Key]
        public int Id_rent { get; set; }
        public int Id_user { get; set; }
        public int Id_book { get; set; }
        public string DateFrom { get; set; } = null!;
        public string DateTo { get; set; } = null!; 
        public int Grade { get; set; }
        public bool Returned { get; set; } = false;
    }
}
