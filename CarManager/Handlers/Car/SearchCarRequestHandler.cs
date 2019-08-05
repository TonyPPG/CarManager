using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CarManager.Request.Car;
using CarManager.Services;
using MediatR;

namespace CarManager.Handlers.Car
{
    public class SearchCarRequestHandler : IRequestHandler<SearchCarRequest, IEnumerable<Data.Car>>
    {
        private readonly ICarService _carService;

        public SearchCarRequestHandler(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<IEnumerable<Data.Car>> Handle(SearchCarRequest request, CancellationToken cancellationToken)
        {
            var cars = await _carService.SearchCar(request.Search.Term);
            return cars;
        }
    }
}
