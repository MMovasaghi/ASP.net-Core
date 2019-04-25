using System.Collections.Generic;
using SportStoreSimpleCode.Models;

namespace SportStoreSimpleCode.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}