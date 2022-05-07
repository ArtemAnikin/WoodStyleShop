using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WoodStyleShop.Data.Mocks;
using WoodStyleShop.Data.Models;

namespace WoodStyleShop.Pages.Shared
{
    public class ProdutcModel : PageModel
    {
        private MockProducts _mockProducts = new MockProducts();
        public Product product = new Product();
        public void OnGet(int value)
        {
            product = _mockProducts.products[value];
        }
    }
}
