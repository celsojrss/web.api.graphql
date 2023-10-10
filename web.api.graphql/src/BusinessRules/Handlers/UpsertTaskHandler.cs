using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.api.graphql.src.BusinessRules.Requests;
using web.api.graphql.src.BusinessRules.Responses;
using web.api.graphql.src.BusinessRules.Validators;
using web.api.graphql.src.Database.Domain;
using web.api.graphql.src.Database.Repositories;

namespace web.api.graphql.src.BusinessRules.Handlers
{
    public class UpsertTaskHandler : IUpsertTaskHandler
    {
        private readonly ITaskRepository _repository;
        private readonly ITaskValidator _validator;
        public UpsertTaskHandler(ITaskRepository repository, ITaskValidator validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public UpsertTaskResponse Execute(UpsertTaskRequest request)
        {
            var validatorResult = _validator.Validate(request);
            if(!validatorResult.IsValid)
            {
                return new UpsertTaskResponse
                {
                    Errors = validatorResult.Errors
                };
            }

            Todo entity;

            if(request.Id.HasValue)
            {
                entity = _repository.GetById(request.Id.Value);
                if(entity == null)
                    throw new Exception("Tarefa não encontrada");
            }
            else
            {
                entity = new Todo();
            }

            entity.Title = request.Title;
            entity.Description = request.Description;
            entity.Done = request.Done;
            if(request.Done)
                entity.DateDone = DateTime.Now;
            else
                entity.DateDone = null;  

            _repository.Save(entity);

            return new UpsertTaskResponse
            {
                Payload = new UpsertTaskResponsePayload
                {
                    Id = entity.Id.Value,
                    Title = entity.Title,
                    Description = entity.Description,
                    Done = entity.Done,
                    DateDone = entity.DateDone,
                }
            };
        }
    }
}
