using DemoLibrary.Models;
using DemoLibrary.Models.Commands;
using DemoLibrary.Models.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IMediator _mediator;
        public PersonController(IMediator mediator)
        {
           _mediator = mediator;
        }


        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<PersonModel>> Get()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<PersonModel> Get(int id)
        {
            return await _mediator.Send(new GetPersonByIdQuery(id));
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<PersonModel> Post([FromBody] PersonModel value)
        {
            //var model = new InsertPersonCommand(value.Name, value.LastName);  return await _mediator.Send(model);

            return await _mediator.Send(new InsertPersonCommand(value.Name, value.LastName));
        }


    }
}
