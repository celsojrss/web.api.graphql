using web.api.graphql.src.BusinessRules.Requests;
using web.api.graphql.src.BusinessRules.Responses;

namespace web.api.graphql.src.BusinessRules.Handlers
{
    public interface IUpsertTaskHandler
    {
        UpsertTaskResponse Execute(UpsertTaskRequest request);
    }
}
