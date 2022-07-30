using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers;

// GET: api/people
[Route("api/[controller]")]
[ApiController]
public class PeopleController : ControllerBase
{
    [HttpGet(Name = "GetPersons")]
    public IEnumerable<Person> Get() => SeedData.Seed();
}

// GET: api/people/{id}


// POST: api/people

// DELETE: api/people