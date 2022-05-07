using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WoodStyleShop.Data.Mocks;
using WoodStyleShop.Data.Models;

namespace WoodStyleShop.Pages
{
    public class CatalogModel : PageModel
    {
        private MockProducts _mockProducts = new MockProducts();
        public void OnGet()
        {
            ViewData["Title"] = "All products";
            ViewData["Products"] = _mockProducts.products;
        }
    }
}
