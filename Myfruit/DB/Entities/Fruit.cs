using Myfruit.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Myfruit.DB.Entities
{
    public class Fruit
    {
        public int FruitId { get; set; }
        [StringLength(50,MinimumLength =3)]
        [Required]
        [Display(Name="Nom")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual Image Image { get; set; }

        [Column(TypeName ="decimal(3,2")]
        [DataType(DataType.Currency)] 
        [Range(1,100)]
        [Required]
        [Display(Name="Prix")]
        public decimal Price { get; set; }
    }
}

