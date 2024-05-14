using maui_hybrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace maui_hybrid.Service
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


        public async Task<List<Product>> GetProductList()
        {
            var products= await httpClient.GetFromJsonAsync<ProductModel>("/products") ??new ProductModel();
            return products.products;
        }
    }
}

