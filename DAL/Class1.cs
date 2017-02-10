using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Class1
    {
        public static ExceptionLog Get()
        {
            using(var db = new DefaultConnection())
            {
                return db.ExceptionLog.FirstOrDefault();
            }
        }
    }
}
