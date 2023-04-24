using BlazorEcommerce.Shared;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient http;

        public ProductService(HttpClient http)
        {
            this.http = http;
        }
        public static List<Product> Products { get; set; } = new List<Product>();

        public async Task GetProducts()
        {
            var result = await http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (result is not null && result.Data is not null) Products = result.Data;
        }
    }
}
