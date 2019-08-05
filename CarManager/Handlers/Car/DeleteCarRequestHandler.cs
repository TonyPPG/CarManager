using System.Threading;
using System.Threading.Tasks;
using CarManager.Request.Car;
using CarManager.Services;
using MediatR;

namespace CarManager.Handlers.Car
{
    public class DeleteCarRequestHandler : IRequestHandler<DeleteCarRequest, string>
    {
        private readonly ICarService _carService;
        public DeleteCarRequestHandler(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<string> Handle(DeleteCarRequest request, CancellationToken cancellationToken)
        {
            string msg = await _carService.DeleteCar(request.Id);

            return msg;
        }
    }
}
