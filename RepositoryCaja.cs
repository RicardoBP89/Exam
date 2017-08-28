using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class RepositoryCaja : IrepositoryCaja
    {
        public CourseRepository(PlutoContext context) 
            : base(context)
        {
        }


        public IEnumerable<Caja> GetCajasWithTickets(int Id)
        {
            return PlutoContext.Courses
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
