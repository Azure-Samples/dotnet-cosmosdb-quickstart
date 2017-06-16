using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo.Models
{
    public class DocDbConfig
    {
        public DocDbConfig()
        {
            string nc = "Not configured";
            Endpoint = nc;
            AuthKey = nc;
            Database = nc;
            Collection = nc;
        }

        public string Endpoint { get; set; }
        public string AuthKey { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
    }
}
