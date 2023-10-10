using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using web.api.graphql.src.BusinessRules.Requests;

namespace web.api.graphql.src.BusinessRules.Validators
{
    public class TaskValidator : AbstractValidator<UpsertTaskRequest>, ITaskValidator
    {
        public TaskValidator()
        {
            RuleFor(t => t.Title)
            .NotEmpty()
            .NotNull()
            .MinimumLength(3)
            .MaximumLength(20)
            .WithName("Titulo");

            RuleFor(t => t.Description)
            .NotEmpty()
            .NotNull()
            .MinimumLength(3)
            .MaximumLength(150)
            .WithName("Descrição");
        }
    }
}
