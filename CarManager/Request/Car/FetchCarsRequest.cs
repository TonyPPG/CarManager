using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MediatR;

namespace CarManager.Request.Car
{
    public class FetchCarsRequest : IRequest<IEnumerable<Data.Car>>
    {
        [Required]
        public int Offset { get; set; }

        public FetchCarsRequest(int offset)
        {
            Offset = offset;
        }
    }
}
