using System.ComponentModel.DataAnnotations;
using MediatR;
namespace CarManager.Request.Car
{
    public class DeleteCarRequest : IRequest<string>
    {
        [Required]
        public string Id { set; get; }

        public DeleteCarRequest(string id)
        {
            Id = id;
        }
    }
}
