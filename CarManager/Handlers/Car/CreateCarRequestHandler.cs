using System.Threading;
using System.Threading.Tasks;
using CarManager.Request.Car;
using CarManager.Services;
using MediatR;

namespace CarManager.Handlers.Car
{
    public class CreateCarRequestHandler : IRequestHandler<CreateCarRequest, Data.Car>
    {
        private readonly ICarService _carService;

        public CreateCarRequestHandler(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<Data.Car> Handle(CreateCarRequest request, CancellationToken cancellationToken)
        {
            var car = await _carService.CreateCar(request.Car);
            return car;
        }
    }
}
