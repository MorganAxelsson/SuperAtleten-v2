using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;
namespace DataLayer.Repository
{
    public class ExceptionLog : Repository<DataLayer.ExceptionLog>, IExceptionLog
    {
        private readonly Sa2DbEntities _context;

        public ExceptionLog(Sa2DbEntities context) : base(context)
        {
            _context = context;
        }
    }
}
