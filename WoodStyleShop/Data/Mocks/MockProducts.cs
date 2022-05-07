using WoodStyleShop.Data.Models;

namespace WoodStyleShop.Data.Mocks
{
    public class MockProducts
    {
        MockCategory _productsCategory = new MockCategory();
        public List<Product> products 
        { get 
            { return new List<Product> {
                new Product {
                    id = 0,
                    name = "Lion",
                    shortDesc = "Some lion ",
                    longDesc = "Устанавливает семейство шрифта, которое будет использоваться для оформления текста содержимого. Список шрифтов может включать одно или несколько названий, разделенных запятой. Если в имени шрифта содержатся пробелы, например, Trebuchet MS, оно должно заключаться в одинарные или двойные кавычки.",
                    img = "/img/lion.png",
                    
                    isFavourite = true,
                    available = true,
                    category = _productsCategory.allCategories.First()
                },
                new Product {
                    id = 1,
                    name = "Dog",
                    shortDesc = "Beatiful dog",
                    longDesc = "Устанавливает семейство шрифта, которое будет использоваться для оформления текста содержимого. Список шрифтов может включать одно или несколько названий, разделенных запятой. Если в имени шрифта содержатся пробелы, например, Trebuchet MS, оно должно заключаться в одинарные или двойные кавычки.",
                    img = "/img/dog.png",
                    
                    isFavourite = true,
                    available = true,
                    category = _productsCategory.allCategories.First()
                },
                new Product {
                    id = 2,
                    name = "Flower1",
                    shortDesc = "Flower1",
                    longDesc = "Устанавливает семейство шрифта, которое будет использоваться для оформления текста содержимого. Список шрифтов может включать одно или несколько названий, разделенных запятой. Если в имени шрифта содержатся пробелы, например, Trebuchet MS, оно должно заключаться в одинарные или двойные кавычки.",
                    img = "/img/flower1.png",
                    
                    isFavourite = false,
                    available = false,
                    category = _productsCategory.allCategories.Last() 
                },
                new Product {
                    id = 3,
                    name = "Flower face",
                    shortDesc = "face and flower",
                    longDesc = "",
                    img = "/img/flowerFace.png",
                    
                    isFavourite = false,
                    available = true,
                    category = _productsCategory.allCategories.Last()
                },
                new Product {
                    id = 4,
                    name = "real Flowers",
                    shortDesc = "just real flowers",
                    longDesc = "Устанавливает семейство шрифта, которое будет использоваться для оформления текста содержимого. Список шрифтов может включать одно или несколько названий, разделенных запятой. Если в имени шрифта содержатся пробелы, например, Trebuchet MS, оно должно заключаться в одинарные или двойные кавычки.",
                    img = "/img/realFlower.png",
                    
                    isFavourite = true,
                    available = true,
                    category = _productsCategory.allCategories.Last() 
                }
                }; 
            } 
        }
        public List<Product> GetFavProducts { get; set; }
        public Product GetProductsById(int ProductId)
        {
            throw new NotImplementedException();
        }
    }
}
