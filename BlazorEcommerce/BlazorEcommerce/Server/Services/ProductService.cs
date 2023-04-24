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

        public async Task<ServiceResponse<List<Product>>> GetProducts()
        {
            var result = await _context.Products.ToListAsync();
            var response = new ServiceResponse<List<Product>>() { Data = result };
            return response;
        }
    }
}
