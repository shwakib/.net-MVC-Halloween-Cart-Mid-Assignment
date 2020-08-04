using System.Web.Mvc;

namespace Ch24ShoppingCartMVC.Models
{
    public class OrderViewModel
    {
        public SelectList ProductsList { get; set; }
        public ProductViewModel SelectedProduct { get; set; }
    }
}