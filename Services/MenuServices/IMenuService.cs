namespace Restaurant.Services.MenuServices
{
	public interface IMenuService
	{
		Task<List<ProductModel>> GetAll();
		Task<ProductModel?> Details(int id);
		Task<List<ProductModel>> AddProduct(ProductModel product);
		Task<List<ProductModel>?> Edit(int id, ProductModel request);
		Task<List<ProductModel>?> DeleteProduct(int id);
	}
}
