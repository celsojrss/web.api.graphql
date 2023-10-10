using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.api.graphql.src.Database.Domain;

namespace web.api.graphql.src.Database.Repositories
{
    public interface ITaskRepository
    {
        IQueryable<Todo> GetAll();
        Todo GetById(Guid id);
        Todo Save(Todo entity);
    }
}
