using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new PlutoContext()))
            {
                // Example1
                var caja = unitOfWork.Tickets.Get(1);

                // Example2
                var cajas = unitOfWork.Cajas.GetCajaWithTickets(1);
            }
        }
    }
}
