using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Product>> GetProduct(int id)
        {
            var response = new ServiceResponse<Product>();
            var result = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (result == null)
            {
                response.Success = false;
                response.Message= "Sorry, product does not exist.";
            }
            else
            {
                response.Data = result;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProducts()
        {
            var result = await _context.Products.ToListAsync();
            var response = new ServiceResponse<List<Product>>() { Data = result };
            return response;
        }
    }
}
