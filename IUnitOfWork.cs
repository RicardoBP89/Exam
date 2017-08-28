using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IUnitOfWork : IDisposable
    {
        IrepositoryCaja Caja { get; }
        IrepositoryTicket Ticket { get; }
        int Complete();
    }
}
