using System;
using System.Data.Entity;
using WebAPI.Models;

namespace WebApiTests
{
    internal class TestPersonContext : IPersonContext
    {
        public TestPersonContext()
        {
            this.Persons = new TestPersonDbSet();
        }

        public DbSet<Person> Persons { get; set; }

        public int SaveChanges()
        {
            return 0;
        }

        public void MarkAsModified(Person person) { }
        public void Dispose() { }
    }
}
