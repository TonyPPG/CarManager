using System;
using System.Threading;
using System.Threading.Tasks;
using CarManager.Request.Car;
using CarManager.Services;
using MediatR;

namespace CarManager.Handlers.Car
{
    public class UpdateCarRequestHandler : IRequestHandler<UpdateCarRequest, string>
    {
        private readonly ICarService _carService;

        public UpdateCarRequestHandler(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<string> Handle(UpdateCarRequest request, CancellationToken cancellationToken)
        {
            string msg = await _carService.UpdateCar(request.Id, request.Car);

            return msg;
        }
    }
}
