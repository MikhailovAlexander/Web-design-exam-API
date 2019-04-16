using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NotebookAPI.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
    }
}