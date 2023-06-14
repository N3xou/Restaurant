using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Services.CartServices
{
	public interface ICartService
	{
		Task<int> Order(OrderModel cart);
		//void RemoveProduct(OrderModel cart, ProductModel product);
		//void AddToCart(OrderModel cart, ProductModel product);
	}
}