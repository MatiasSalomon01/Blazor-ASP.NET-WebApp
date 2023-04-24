using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services
{
    public interface IProductService
    {
        static List<Product> Products { get; set; }
        Task GetProducts();
    }
}
