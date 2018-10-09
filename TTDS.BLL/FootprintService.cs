using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDS.DAL;
using TTDS.Model;

namespace TTDS.BLL
{
    public class FootprintService:BaseService<t_contactground>
    {
        private FootprintDAL footprintDAL = new FootprintDAL();
        public override void SetDal()
        {
            Dal = footprintDAL;
        }
    }
}
