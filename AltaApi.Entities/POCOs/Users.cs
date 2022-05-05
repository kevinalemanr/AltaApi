using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.Entities.POCOs
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        public DateTime Creationdate { get; set; }

        public string? Comment { get; set; }
    }
}
