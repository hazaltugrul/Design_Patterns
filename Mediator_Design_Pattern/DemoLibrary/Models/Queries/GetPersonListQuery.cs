using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models.Queries
{
    // Record (DTO object ) and the class do the same thing but record has it's own syntax
    // Record is immutable.
    public record GetPersonListQuery():IRequest<List<PersonModel>>;

    //public class GetPersonListQueryClass : IRequest<List<PersonModel>>
    //{
    //}



}
