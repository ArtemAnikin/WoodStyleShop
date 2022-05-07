using WoodStyleShop.Data.Models;

namespace WoodStyleShop.Data.Mocks
{
    public class MockCategory
    {
        public List<Category> allCategories
        {
            get { return new List<Category> {
                    new Category {id = 0,categoryName = "animals", description = "cute animals"},
                    new Category {id = 1,categoryName = "flowers", description = "just flowers" }
                }; }
        }
    }
}
