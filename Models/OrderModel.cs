namespace Restaurant.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string ProductIds { get; set; }

        public float TotalPrice {
            get {
                return (float)Math.Round(OrderItems.Sum(item => item.Price), 2);
            }
        }


        public List<ProductModel> OrderItems { get; set; } = new List<ProductModel>();


    }
}
