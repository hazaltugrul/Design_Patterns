using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        public List<PersonModel> People = new();

        public DemoDataAccess()
        {
            People.Add(new PersonModel { ID = 1, Name = "Jack", LastName = "Burden" });
            People.Add(new PersonModel { ID = 2, Name = "Adam", LastName = "Stormy" });
        }
        public PersonModel InsertPerson(string name, string lastname)
        {
            PersonModel personModel = new() { Name = name, LastName = lastname };
            personModel.ID = People.Max(x => x.ID) + 1;
            People.Add(personModel);
            return personModel;
        }

        public List<PersonModel> GetPeople()
        {
            return People;
        }
    }
}
