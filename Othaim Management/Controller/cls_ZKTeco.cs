using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_ZKTeco
    {
        ZKTeco_DBEntities db = new ZKTeco_DBEntities();

        public List<USERINFO> FindByID(string BADGENUMBER)
        {
            
            var result = db.USERINFO.Where(u => u.BADGENUMBER == BADGENUMBER).ToList();
            return result;

        }
    }
}
