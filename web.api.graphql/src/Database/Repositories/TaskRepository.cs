using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.api.graphql.src.Database.Domain;

namespace web.api.graphql.src.Database.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly Context _dbContext;

        public TaskRepository(Context dbContext) => _dbContext = dbContext;

        public IQueryable<Todo> GetAll()
        {
            return _dbContext.Tasks.AsQueryable();
        }

        public Todo GetById(Guid id)
        {
            return _dbContext.Tasks.SingleOrDefault(task => task.Id == id);
        }

        public Todo Save(Todo entity)
        {
            if(string.IsNullOrEmpty(entity.Id.ToString()))
            {
                entity.Id = Guid.NewGuid();
                _dbContext.Tasks.Add(entity);
            }

            _dbContext.SaveChanges();

            return entity;
        }
    }
}
