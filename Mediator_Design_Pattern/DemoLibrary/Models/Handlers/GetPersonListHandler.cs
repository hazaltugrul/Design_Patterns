using DemoLibrary.DataAccess;
using DemoLibrary.Models.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        private readonly IDataAccess _dataAccess;
        public GetPersonListHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetPeople());
        }
    }
}
