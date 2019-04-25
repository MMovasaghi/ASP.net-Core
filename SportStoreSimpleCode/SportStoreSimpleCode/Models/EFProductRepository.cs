using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreSimpleCode.Models
{
    public class EFProductRepository : IProductRepository
    {
        private AppContext context;
        public EFProductRepository(AppContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
