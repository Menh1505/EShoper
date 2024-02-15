namespace Eshopper.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems {set; get;}
        public int ItemsPerPage {set; get;}
        public int CurrentPage {set; get;}
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}