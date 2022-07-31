using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http.Results;
using System.Net;
using WebAPI.Models;
using WebAPI.Controllers;

namespace WebApiTests;

[TestClass]
public class TestPersonController
{

    [TestMethod]
    public void PostPerson_ShouldReturnSamePerson()
    {
        var controller = new PeopleController(new TestPersonContext());
        var person = GetDemoPerson();

        var result = controller.PostPerson(person) as CreatedAtRouteNegotiatedContentResult<Person>;

        Assert.IsNotNull(result);
        Assert.AreEqual(result.RouteName, "DefaultApi");
        Assert.AreEqual(result.RouteValues["id"], result.Content.Id);
        Assert.AreEqual(result.Content.Name, person.Name);
    }

    public Person GetDemoPerson()
    {
        return new Person { Id = 0, Name = "DemoFirst0", LastName = "DemoLast0", Email = "DemoEmail0" };
    }

    public List<Person> GetTestPeople()
    {
        // Create the list to hold all of the test people
        var testPeople = new List<Person>(); 

        // Add test people to the list
        testPeople.Add(new Person { Id = 1, Name = "DemoFirst1", LastName = "DemoLast1", Email = "DemoEmail1" });
        testPeople.Add(new Person { Id = 2, Name = "DemoFirst2", LastName = "DemoLast2", Email = "DemoEmail2" });
        testPeople.Add(new Person { Id = 3, Name = "DemoFirst3", LastName = "DemoLast3", Email = "DemoEmail3" });
        testPeople.Add(new Person { Id = 4, Name = "DemoFirst4", LastName = "DemoLast4", Email = "DemoEmail4" });

        // Return the list
        return testPeople;
    }
}
