using System;
using System.ComponentModel.DataAnnotations;

namespace AppWithDb01.Models
{
    public class Entry
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int Glucose { get; set; }

        public string Note { get; set; }

        [Required]
        public TimeOfMeasurement TimeOfMeasurement { get; set; }
    }
}