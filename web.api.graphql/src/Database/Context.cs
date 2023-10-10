using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web.api.graphql.src.Database.Domain;

namespace web.api.graphql.src.Database
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base (options)
        {
        }

        public DbSet<Todo> Tasks{get; set;}
    }
}
