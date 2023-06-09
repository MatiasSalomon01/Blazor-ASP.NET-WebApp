﻿using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task<ServiceResponse<List<Product>>> GetProducts();
        Task<ServiceResponse<Product>> GetProduct(int id);
    }
}
