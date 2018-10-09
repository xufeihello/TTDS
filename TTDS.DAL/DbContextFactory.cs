using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDS.Model;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace TTDS.DAL
{
   public partial class DbContextFactory
    {
        public static DbContext Create()
        {
            DbContext dbContext = CallContext.GetData("DbContext") as DbContext;
            if(dbContext==null)
            {
                dbContext = new ttdbEntities();
                CallContext.SetData("DbContext", dbContext);
            }
            return dbContext;
        }
    }
}
