using System.ComponentModel.DataAnnotations;
using MediatR;

namespace CarManager.Request.Car
{
    public class CreateCarRequest: IRequest<Data.Car>
    {
        [Required]
        public Data.Car Car { set; get; }

        public CreateCarRequest(Data.Car car)
        {
            Car = car;
        }
    }
}
