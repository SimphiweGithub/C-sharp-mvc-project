using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Controllers
{
    public class Expense
    {
        public int ID { get; set; }
        public double Value { get; set; }
        [Required]//we set this string to nullale but the enforce it so that a datatype is required
        //? allows you to have a null value
        public string? Description { get; set; }
    }
}
