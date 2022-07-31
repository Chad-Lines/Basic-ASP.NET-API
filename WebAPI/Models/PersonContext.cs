using Microsoft.EntityFrameworkCore;


namespace WebAPI.Models;

public class PersonContext : DbContext, IPersonContext
{
    public PersonContext(DbContextOptions<PersonContext> options) : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; } = null!;

    public void MarkAsModified(Person person)
    {
        Entry(person).State = EntityState.Modified;
    }
}
