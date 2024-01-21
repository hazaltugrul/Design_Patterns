using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models.Queries
{
    public class GetPersonByIdQuery: IRequest<PersonModel>
    {
        public int Id { get; set; }

        public GetPersonByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }

    //You can do the same with a record instead of a class

    // public record GetPersonByIdQuery(int id): IRequest<PersonModel>;

}
