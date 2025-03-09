using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Expenses
    {
        public int ID { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Value must be a positive number.")]
        public double Value { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string? Category { get; set; } // New Category field

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}

