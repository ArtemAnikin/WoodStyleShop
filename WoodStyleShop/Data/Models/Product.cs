namespace WoodStyleShop.Data.Models
{
    public class Product
    {
        private Dictionary<string, uint> _sizePrise = new Dictionary<string, uint>();
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string shortDesc { get; set; } = string.Empty;
        public string longDesc { get; set; } = string.Empty;
        public string img { get; set; } = string.Empty;
        public void addPrise(string size, uint prise)
        {
            _sizePrise.Add(size, prise);
        }
        public bool isFavourite { get; set; }
        public bool available { get; set; }
        public Category category { get; set; }
    }
}
