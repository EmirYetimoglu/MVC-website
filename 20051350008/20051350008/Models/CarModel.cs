using System.ComponentModel.DataAnnotations;
namespace _20051350008.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]

        public string Brand { get; set; }

        [Required]
        public Int16 Price { get; set; }

        public string? CarType { get; set; }
        

    }
}
