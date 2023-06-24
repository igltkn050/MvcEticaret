namespace MvcEticaretApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int StarCount { get; set; }
        public decimal OldPrice { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSale { get; set; }
    }
}
