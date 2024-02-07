using System.ComponentModel.DataAnnotations;

namespace Eshopper.Models
{
    public class Color
    {
        [Key]
        public int ColorId {set; get;}
        [StringLength(30)]
        public string? ColorName {set; get;}

    }
}