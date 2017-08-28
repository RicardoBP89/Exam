using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queries.Core;
using Queries.Core.Repositories;
using Queries.Persistence.Repositories;


namespace ConsoleApplication1
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        public UnitOfWork()
        {
            _context = context;
            Cajas = new RepositoryTicket(_context);
            Tickets = new RepositoryCaja(_context);
        }
        
        public IrepositoryCaja Cajas { get; private set; }
        public IrepositoryTicket Tickets { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
