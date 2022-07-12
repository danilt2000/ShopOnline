namespace ShopOnline.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Price { get; set; } = string.Empty;

        public ProductType Type { get; set; } 

        public string ImageTitle { get; set; } = string.Empty;

    }
}
namespace ShopOnline.Models
{
    public enum ProductType
    {
        Vegetables,
        Fruit,
        Nuts

    }


}