using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;
namespace DataLayer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Sa2DbEntities _context;
        public IExceptionLog ExceptionLog { get; private set; }

        public UnitOfWork(Sa2DbEntities context)
        {
            _context = context;
            ExceptionLog = new ExceptionLog(_context);
        }
        public int Save()
        {
            return _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
