using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTDS.DAL;
using TTDS.Model;

namespace TTDS.BLL
{
    public class UserService:BaseService<user>
    {
        private UserDAL userDAL = new UserDAL();
        public override void SetDal()
        {
            Dal = userDAL;
        }
    }
}
