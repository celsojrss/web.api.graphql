using web.api.graphql.src.BusinessRules.Handlers;
using web.api.graphql.src.BusinessRules.Requests;
using web.api.graphql.src.BusinessRules.Responses;

namespace web.api.graphql.src.Api
{
    public class Mutation
    {
        public UpsertTaskResponse UpserTask([Service] IUpsertTaskHandler handler , UpsertTaskRequest request)
        {
            return handler.Execute(request);
        }
    }
}
