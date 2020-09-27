using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PersianAnimalLand.Domain.Entity.BaseData
{
    [Table("AnimalCategory")]
    public class AnimalCategory
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
    }
}
