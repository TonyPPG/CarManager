using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MediatR;
namespace CarManager.Request.Car
{
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
