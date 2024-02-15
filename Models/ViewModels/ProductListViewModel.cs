namespace Eshopper.Models.ViewModels
{
    public class ProductListViewModel   
    {
        public IEnumerable<Product> Products {set; get;} = Enumerable.Empty<Product>();
        public PagingInfo pagingInfo {set; get;} = new PagingInfo();
    }
}