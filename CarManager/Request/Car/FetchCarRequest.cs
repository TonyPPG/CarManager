using System.ComponentModel.DataAnnotations;
using MediatR;

namespace CarManager.Request.Car
{
    public class FetchCarRequest : IRequest<Data.Car>
    {
        [Required]
        public string Id { get; set; }

        public FetchCarRequest(string id)
        {
            Id = id;
        }
    }
}
