using WebAPI.Models;

namespace WebAPI.Services;

public class SeedData
{
    public static Person[] Seed()
    {
        // Creating and returning the array of people
        return new Person[] {
            new Person { Id = 1, FirstName = "John", LastName = "Doe", Email = "John@Doe.Com" },
            new Person { Id = 2, FirstName = "Janet", LastName = "Brown", Email = "Janet@Brown.Com" },
            new Person { Id = 3, FirstName = "Mark", LastName = "Hewlett", Email = "Mark@Hewlett.Com" },
            new Person { Id = 4, FirstName = "Betty", LastName = "Shell", Email = "Betty@Shell.Com" }
        };

    }
}
