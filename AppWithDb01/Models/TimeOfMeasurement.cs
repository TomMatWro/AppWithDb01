using System.ComponentModel.DataAnnotations;

namespace AppWithDb01.Models
{
    public class TimeOfMeasurement
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}