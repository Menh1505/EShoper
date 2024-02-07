using System.ComponentModel.DataAnnotations;

namespace Eshopper.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {set; get;}
        [StringLength(150)]
        public string? CategoryName {set; get;}
        [StringLength(300)]
        public string? CategoryPhoto { set; get; }
        public int CategoryOrder {set; get;}

    }
}