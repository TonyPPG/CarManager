using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CarManager.Request.Car;
using CarManager.Services;
using MediatR;

namespace CarManager.Handlers.Car
{
    public class FetchCarsRequestHandler : IRequestHandler<FetchCarsRequest, IEnumerable<Data.Car> >
    {
        private readonly ICarService _carService;

        public FetchCarsRequestHandler(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<IEnumerable<Data.Car>> Handle(FetchCarsRequest request, CancellationToken cancellationToken)
        {
            var cars = await _carService.GetCars();

            return cars;
        }
    }
}
