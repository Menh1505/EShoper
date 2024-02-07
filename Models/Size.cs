using System.ComponentModel.DataAnnotations;

namespace Eshopper.Models
{
    public class Size
    {
        [Key]
        public int SizeId {set; get;}
        [StringLength(30)]
        public string? SizeName {set; get;}
    }
}