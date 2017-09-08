using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySampleWebApi.Resources
{
    public class User
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
