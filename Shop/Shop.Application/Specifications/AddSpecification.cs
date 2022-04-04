using Shop.Domain.Infrastructure;
using Shop.Domain.Models;
using System.Threading.Tasks;

namespace Shop.Application.Specifications
{
    [Service]
    public class AddSpecification
    {
        private ISpecificationManager _specificationManager;

        public AddSpecification(ISpecificationManager specificationManager)
        {
            _specificationManager = specificationManager;
        }

        public async Task<Response> Do(Request request)
        {
            var specification = new Specification
            {
                ProductId = request.ProductId,
                OperatingSystem = request.OperatingSystem,
                ScreenDiagonal = request.ScreenDiagonal,
                RAM = request.RAM,
                PersistentMemory = request.PersistentMemory,
                QtySIM = request.QtySIM,
                MainCamera = request.MainCamera,
                FrontCamera = request.FrontCamera,
            };

            await _specificationManager.AddSpecification(specification);

            return new Response
            {
                Id = specification.Id,
                OperatingSystem = specification.OperatingSystem,
                ScreenDiagonal = specification.ScreenDiagonal,
                RAM = specification.RAM,
                PersistentMemory = specification.PersistentMemory,
                QtySIM = specification.QtySIM,
                MainCamera = specification.MainCamera,
                FrontCamera = specification.FrontCamera,
            };
        }
        public class Request
        {
            public string OperatingSystem { get; set; }

            public string ScreenDiagonal { get; set; }
            public string RAM { get; set; }

            public string PersistentMemory { get; set; }

            public string QtySIM { get; set; }

            public string MainCamera { get; set; }
            public string FrontCamera { get; set; }

            public int ProductId { get; set; }
        }

        public class Response
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
    }
}
