using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PersianAnimalLand.Domain.Entity
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(300)]
        public string Title { get; set; }

        [Required]
        [MaxLength(300)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(15)]
        public string Price { get; set; }

        [Required] 
        public bool InStoke { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [MaxLength(15)]
        public string Weight { get; set; }

        [Required]
        [MaxLength(15)]
        public string Country { get; set; }

        [Required] 
        public int Score { get; set; }
 
        public int CountOff { get; set; }
    }
}
