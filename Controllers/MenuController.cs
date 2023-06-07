using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MenuController : ControllerBase
	{
		private readonly IMenuService _menuService;

		public MenuController(IMenuService menuService)
		{
			_menuService = menuService;
		}

		[HttpGet("GetAll")]
		public async Task<ActionResult<List<ProductModel>>> GetAll()
		{
			return await _menuService.GetAll();
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<ProductModel>> Details(int id)
		{
			var result = await _menuService.Details(id);
			if (result is null)
			{
				return NotFound("Product not found.");
			}
			return Ok(result);
		}

		[HttpPost("AddProduct")]
		public async Task<ActionResult<List<ProductModel>>> AddProduct(ProductModel product)
		{
			var result = await _menuService.AddProduct(product);
			return Ok(result);
		}
		[HttpPut("Edit/{id}")]
		public async Task<ActionResult<List<ProductModel>>> Edit(int id, ProductModel request)
		{
			var result = await _menuService.Edit(id, request);
			if (result is null)
			{
				return NotFound("Product not found.");
			}
			return Ok(result);
		}

		[HttpDelete("Delete/{id}")]
		public async Task<ActionResult<List<ProductModel>>> DeleteProduct(int id)
		{
			var result = await _menuService.DeleteProduct(id);
			if (result is null)
			{
				return NotFound("Product not found.");
			}
			return Ok(result);
		}

	}
}