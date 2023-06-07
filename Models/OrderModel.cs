namespace Restaurant.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string ProductIds { get; set; }

        public float TotalPrice {
            get {
                return OrderItems.Sum(item => item.Price);
            }
        }


        public List<ProductModel> OrderItems { get; set; } = new List<ProductModel>();


    }
}
