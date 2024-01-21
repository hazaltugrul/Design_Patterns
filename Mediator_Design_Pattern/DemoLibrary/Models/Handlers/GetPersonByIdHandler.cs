using DemoLibrary.Models.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private IMediator _mediator;
        public GetPersonByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetPersonListQuery());
            var output = result.FirstOrDefault(x => x.ID == request.Id);
            return output;
        }
    }
}
