using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
	public class ProductModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public float Price { get; set; } = 0;
		public string Description { get; set; } = string.Empty;
		public string ImgPath { get; set; } = string.Empty;

	}
}