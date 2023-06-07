using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.Services;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Services.MenuServices
{
	public class MenuService : IMenuService
	{
		private readonly RestaurantDbContext _context;
		public MenuService(RestaurantDbContext context)
		{
			_context = context;
		}
		public async Task<List<ProductModel>> AddProduct(ProductModel product)
		{
			_context.Menu.Add(product);
			await _context.SaveChangesAsync();
			return await _context.Menu.ToListAsync();
		}
		public async Task<List<ProductModel>?> DeleteProduct(int id)
		{
			var product = await _context.Menu.FindAsync(id);
			if (product is null)
			{
				return null;
			}

			_context.Menu.Remove(product);
			await _context.SaveChangesAsync();
			return await _context.Menu.ToListAsync();
		}
		public async Task<List<ProductModel>?> Edit(int id, ProductModel request)
		{
			var product = await _context.Menu.FindAsync(id);
			if (product is null)
			{
				return null;
			}
			product.Name = request.Name;
			product.Description = request.Description;
			product.Price = request.Price;
			product.ImgPath = request.ImgPath;
			await _context.SaveChangesAsync();

			return await _context.Menu.ToListAsync();
		}
		public async Task<ProductModel?> Details(int id)
		{
			var product = await _context.Menu.FindAsync(id);
			if (product == null)
			{
				return null;
			}

			return product;
		}
		public async Task<List<ProductModel>> GetAll()
		{
			var shoppingLists = await _context.Menu.ToListAsync();
			return shoppingLists;
		}
	}
}