using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.api.graphql.src.Database.Domain
{
    public class Todo
    {
        public Guid? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public DateTime? DateDone  { get; set; }
    }
}
