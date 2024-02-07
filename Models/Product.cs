using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshopper.Models
{
    public class Product
    {
        [Key]
        public int ProductId { set; get; }
        [Required]
        [StringLength(150)]
        public string? ProductName { set; get; }
        [StringLength(30000)]
        public string? ProductDescription { set; get; }
        [ForeignKey("Category")]
        public int CategoryId { set; get; }
        public Category? category {set; get;}
        [Column(TypeName = "decimal(8,2)")]
        public decimal? ProductPrice { set; get; }
        [Column(TypeName = "decimal(2,2)")]
        public decimal? ProductDiscount { set; get; }
        [StringLength(300)]
        public string? ProductPhoto { set; get; }
        [ForeignKey("Size")]
        public int SizeId { set; get; }
        public Size? size {set; get;}
        [ForeignKey("Color")]
        public int ColorId { set; get; }
        public Color? color {set; get;}
        public bool IsTrandy {set; get;}
        public bool IsArrived {set; get;}
    }
}