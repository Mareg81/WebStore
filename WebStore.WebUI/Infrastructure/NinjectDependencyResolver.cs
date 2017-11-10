//komentarz: własny mechanizm rozwiązaywania zależności używany przez platformę MVC do tworzenia obiektów w aplikacji

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using WebStore.Domain.Abstract;
using WebStore.Domain.Concrete;
using WebStore.Domain.Entities;

namespace WebStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //komentarz: imitacja repozytorium

            //Mock<IProductRepository> mock = new Mock<IProductRepository>();
            //mock.Setup(m => m.Products).Returns(new List<Product> {
            //    new Product { Name = "Piłka nożna", Price = 25 },
            //    new Product { Name = "Deska do surfowania", Price = 179 },
            //    new Product { Name = "Buty do biegania", Price = 95 }
            //});

            //komentarz: dołączenie imitacji repozytorium do interfejsu

            //kernel.Bind<IProductRepository>().ToConstant(mock.Object);\

            //komentarz: powiązanie do repozytorium, które zastąpiło imitację

            kernel.Bind<IProductRepository>().To<EFProductRepository>();
        }
    }
}