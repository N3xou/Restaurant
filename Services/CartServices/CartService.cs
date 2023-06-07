using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Services.CartServices
{
	public class CartService
	{
		private readonly RestaurantDbContext _context;
		public CartService(RestaurantDbContext context)
		{
			_context = context;
		}

		// adds the cart to the Orders database
		public async Task<bool> Order(OrderModel cart)
		{
			_context.Orders.Add(cart);
			await _context.SaveChangesAsync();
			return true;
		}
		// deletes a product from users cart, 
		//public void RemoveProduct(OrderModel cart, ProductModel product)
		//{
		//	cart.Products.Remove(product);
		//}
		//public void AddToCart(OrderModel cart, ProductModel product)
		//{
		//	cart.Products.Add(product);
		//}
	}
}
