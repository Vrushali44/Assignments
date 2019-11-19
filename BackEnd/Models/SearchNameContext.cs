using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SearchName.Models
{
    public class SearchNameContext : DbContext
    {
        
        public SearchNameContext() : base("name=SearchNameContext")
        {
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<ClientAdd> ClientAdds { get; set; }
    }
}
