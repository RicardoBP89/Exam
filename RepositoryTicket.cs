using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class RepositoryTicket : IrepositoryTicket
    {
        public RepositoryTicket(PlutoContext context) : base(context)
        {
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
