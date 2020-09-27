using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PersianAnimalLand.Domain.Entity.BaseData
{
    [Table("ProductCategory")]
    public class ProductCategory
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required] 
        public int AnimalTypeID { get; set; }
    }
}
