using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace PersianAnimalLand.Domain.Entity
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
    }
}
