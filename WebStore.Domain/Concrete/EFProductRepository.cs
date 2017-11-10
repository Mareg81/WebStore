//komentarz: klasa repozytorium

using System.Collections.Generic;
using WebStore.Domain.Abstract;
using WebStore.Domain.Entities;

namespace WebStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
