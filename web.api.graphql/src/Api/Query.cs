using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.api.graphql.src.Database.Domain;

namespace web.api.graphql.src.Api
{
    public class Query
    {
        public Todo Task()
        {
            return new Todo();
        }
    }
}
