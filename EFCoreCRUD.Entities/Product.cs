using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCRUD.Entities
{
        [Table("Products")]
        public class Product
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [StringLength(50), Required]
            public string? Name { get; set; }
            [StringLength(50)]
            public string? Marka { get; set; }
        }    
}