using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDS.DAL;
using TTDS.Model;

namespace TTDS.BLL
{
    public partial class TireAmountService :BaseService<vw_tire_amount>
    {
        private TireAmountDAL tireAmountDAL = new TireAmountDAL();
        public override void SetDal()
        {
            Dal = tireAmountDAL;
        }
    }
}
