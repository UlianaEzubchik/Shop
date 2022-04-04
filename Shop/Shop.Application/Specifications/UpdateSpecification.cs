using Shop.Domain.Infrastructure;
using Shop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Application.Specifications
{
    [Service]
    public class UpdateSpecification
    {
        private ISpecificationManager _specificationManager;

        public UpdateSpecification(ISpecificationManager specificationManager)
        {
            _specificationManager = specificationManager;
        }

        public async Task<Response> Do(Request request)
        {
            var specificationList = new List<Specification>();

            foreach (var specification in request.Specification)
            {
                specificationList.Add(new Specification
                {
                    Id = specification.Id,
                    ProductId = specification.ProductId,
                    OperatingSystem = specification.OperatingSystem,
                    ScreenDiagonal = specification.ScreenDiagonal,
                    RAM = specification.RAM,
                    PersistentMemory = specification.PersistentMemory,
                    QtySIM = specification.QtySIM,
                    MainCamera = specification.MainCamera,
                    FrontCamera = specification.FrontCamera,
                });
            }

            await _specificationManager.UpdateSpecificationRange(specificationList);

            return new Response
            {
                Specification = request.Specification
            };
        }

        public class SpecificationViewModel
        {
            public int Id { get; set; }
            public string OperatingSystem { get; set; }

            public string ScreenDiagonal { get; set; }
            public string RAM { get; set; }

            public string PersistentMemory { get; set; }

            public string QtySIM { get; set; }

            public string MainCamera { get; set; }
            public string FrontCamera { get; set; }

            public int ProductId { get; set; }
        }

        public class Request
        {
            public IEnumerable<SpecificationViewModel> Specification { get; set; }
        }

        public class Response
        {
            public IEnumerable<SpecificationViewModel> Specification { get; set; }
        }
    }
}
