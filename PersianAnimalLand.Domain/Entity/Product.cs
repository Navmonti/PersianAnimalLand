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
        public string Title { get; set; }
        public string Brand { get; set; }
        public string Price { get; set; }
        public string IsStoke { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public string Country { get; set; }
        public string Point { get; set; }

        public string CountOff { get; set; }
    }
}
