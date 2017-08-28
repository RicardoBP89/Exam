using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queries.Core.Domain;
using Queries.Persistence.EntityConfigurations;
using System.Data.Entity;

namespace ConsoleApplication1
{
        public class PlutoContext : DbContext
        {
            public PlutoContext()
                : base("name=PlutoContext")
            {
                this.Configuration.LazyLoadingEnabled = false;
            }

            public virtual DbSet<Author> Authors { get; set; }
            public virtual DbSet<Course> Courses { get; set; }
            public virtual DbSet<Tag> Tags { get; set; }
        }
}
