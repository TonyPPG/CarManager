using System.ComponentModel.DataAnnotations;
using MediatR;

namespace CarManager.Request.Car
{

    public class UpdateCarRequest : IRequest<string>
    {
        [Required]
        public string Id { set; get; }
        [Required]
        public Data.Car Car { set; get; }

        public UpdateCarRequest(string id, Data.Car car)
        {
            Id = id;
            Car = car;
        }
    }
}
