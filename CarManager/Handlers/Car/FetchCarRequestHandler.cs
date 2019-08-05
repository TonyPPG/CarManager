using System;
using System.Threading;
using System.Threading.Tasks;
using CarManager.Request.Car;
using CarManager.Services;
using MediatR;

namespace CarManager.Handlers.Car
{

    public class FetchCarHandler : IRequestHandler<FetchCarRequest, Data.Car>
    {
        private readonly ICarService _carService;

        public FetchCarHandler(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<Data.Car> Handle(FetchCarRequest request, CancellationToken cancellationToken)
        {
            if (Guid.TryParse(request.Id, out var newGuid) == false)
            {
                return null;
            }
            var car = await _carService.GetCar(request.Id);

            return car;
        }
    }
}
