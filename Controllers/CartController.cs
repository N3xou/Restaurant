using Microsoft.AspNetCore.Mvc;
using Restaurant.Services.CartServices;

namespace Restaurant.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CartController : Controller
	{
		private readonly ICartService _cartService;
		public CartController(ICartService cartService)
		{
			_cartService = cartService;
		}
		[HttpPost("order")]
		public async Task<IActionResult> Order(OrderModel cart)
        {
            int idNumber = await _cartService.Order(cart);
			return Ok(idNumber);
        }

		//[HttpDelete("remove-product")]
		//public IActionResult RemoveProduct(OrderModel cart, ProductModel product)
		//{
		//	_cartService.RemoveProduct(cart, product);
		//	return NoContent();
		//}

		//[HttpPost("add-to-cart")]
		//public IActionResult AddToCart(OrderModel cart, ProductModel product)
		//{
		//	_cartService.AddToCart(cart, product);
		//	return NoContent();
		//}
	}
}
