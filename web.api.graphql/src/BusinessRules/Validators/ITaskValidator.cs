using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using web.api.graphql.src.BusinessRules.Requests;

namespace web.api.graphql.src.BusinessRules.Validators
{
    public interface ITaskValidator : IValidator<UpsertTaskRequest>
    {
        
    }
}
