using System;
using System.Linq;
using WebAPI.Models;

namespace WebApiTests;

class TestPersonDbSet : TestDbSet<Person>
{
    public override Person Find(params object[] keyValues)
    {
        return this.SingleOrDefault(person => person.Id == (int)keyValues.Single());
    }
}
