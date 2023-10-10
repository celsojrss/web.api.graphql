using Microsoft.EntityFrameworkCore;
using web.api.graphql.src.Api;
using web.api.graphql.src.BusinessRules.Handlers;
using web.api.graphql.src.BusinessRules.Validators;
using web.api.graphql.src.Database;
using web.api.graphql.src.Database.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddDbContext<Context>(option => 
        option.UseInMemoryDatabase("graphql")
    );

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

builder.Services
    .AddScoped<ITaskValidator, TaskValidator>()
    .AddScoped<ITaskRepository, TaskRepository>()  
    .AddScoped<IUpsertTaskHandler, UpsertTaskHandler>(); 

var app = builder.Build();

app.MapGraphQL();

app.Run();
