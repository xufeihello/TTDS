using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDS.DAL;
using TTDS.Model;

namespace TTDS.BLL
{
    public partial class TireService:BaseService<tire>
    {
        private TireDAL tireDAL = new TireDAL();
        public override void SetDal()
        {
            Dal = tireDAL;
        }
    }
}
