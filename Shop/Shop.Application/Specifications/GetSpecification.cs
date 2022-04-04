using Shop.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.Specifications
{
    [Service]
    public class GetSpecification
    {
        private IProductManager _poductManager;

        public GetSpecification(IProductManager poductManager)
        {
            _poductManager = poductManager;
        }
        public IEnumerable<ProductViewModel> Do()
        {
            return _poductManager.GetProductsWithSpecification(x => new ProductViewModel
            {
                Id = x.Id,
                Description = x.Description,
                Specification = x.Specification.Select(y => new SrecificationViewModel
                {
                    Id = y.Id,
                    OperatingSystem = y.OperatingSystem,
                    ScreenDiagonal = y.ScreenDiagonal,
                    RAM = y.RAM,
                    PersistentMemory = y.PersistentMemory,
                    QtySIM = y.QtySIM,
                    MainCamera = y.MainCamera,
                    FrontCamera = y.FrontCamera,
                })
            });
        }

        public class SrecificationViewModel
        {
            public int Id { get; set; }
            public string OperatingSystem { get; set; }

            public string ScreenDiagonal { get; set; }
            public string RAM { get; set; }

            public string PersistentMemory { get; set; }

            public string QtySIM { get; set; }

            public string MainCamera { get; set; }
            public string FrontCamera { get; set; }


        }

        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public IEnumerable<SrecificationViewModel> Specification { get; set; }
        }
    }
}
