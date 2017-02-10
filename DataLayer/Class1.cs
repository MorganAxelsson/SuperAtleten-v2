using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class Class1
    {
        public static ExceptionLog Get()
        {
            using(var db = new Sa2DbEntities())
            {
                return db.ExceptionLog.FirstOrDefault();
            }
        }
    }
}
