using System;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models;

public interface IPersonContext : IDisposable
{
    // An interface for use by the PersonContext class
    public DbSet<Person> Persons { get; }
    //int SaveChange();
    void MarkAsModified(Person person);
}
