using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;


namespace Othaim_Management.Controller
{
    class cls_Update
    {
        OthaimITEntities db = new OthaimITEntities();
        
        public List<info> List()
        {
            var result = db.info.ToList();
            return result.ToList();
        }
    }
}
