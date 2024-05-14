using maui_hybrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui_hybrid.Service
{
    public interface IProductService
    {
        Task<List<Product>> GetProductList();
    }
}
