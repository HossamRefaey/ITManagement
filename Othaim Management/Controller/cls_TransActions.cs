using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_TransActions
    {
        OthaimITEntities db = new OthaimITEntities();

        public void Create(string ip, string username,string hostname, DateTime date, int user_id)
        {
            db.TransActions.Add(new TransActions
            {
                IP_PC = ip,
                user_name_PC = username,
                host_name_PC = hostname,
                User_ID = user_id,
                date = date
            });
            db.SaveChanges();
        }
    }
}
