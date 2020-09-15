using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PersianAnimalLand.Domain.Entity
{
    [Table("Clinic")]
    public class Clinic
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Address { get; set; }

        [Required]
        [MaxLength(20)]
        public string Latitude { get; set; }

        [Required]
        [MaxLength(30)]
        public string Longitude { get; set; }

        [Required]
        [MaxLength(30)]
        public string Phone { get; set; } 
    }
}
