using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models.Commands
{
   //instead of class do record

    public record InsertPersonCommand(string Name , string LastName): IRequest<PersonModel>;

    //public class InsertPersonCommand : IRequest<PersonModel>
    //{
    //    public  string Name { get; set; }
    //    public  string LastName { get; set; }

    //    public InsertPersonCommand(string name, string lastName)
    //    {
    //        Name = name;
    //        LastName = lastName;
    //    }
    //}
}
