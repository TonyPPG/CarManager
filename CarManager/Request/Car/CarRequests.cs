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

    public class FetchCarRequest : IRequest<Data.Car>
    {
        [Required]
        public string Id { get; set; }

        public FetchCarRequest(string id)
        {
            Id = id;
        }
    }

    public class CreateCarRequest: IRequest<Data.Car>
    {
        [Required]
        public Data.Car Car { set; get; }

        public CreateCarRequest(Data.Car car)
        {
            Car = car;
        }
    }

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

    public class DeleteCarRequest : IRequest<string>
    {
        [Required]
        public string Id { set; get; }

        public DeleteCarRequest(string id)
        {
            Id = id;
        }
    }

    public class SearchCarRequest : IRequest<IEnumerable<Data.Car>>
    {
        [Required]
        public Data.SearchRequest Search { set; get; }

        public SearchCarRequest(Data.SearchRequest search)
        {
            Search = search;
        }
    }
}
