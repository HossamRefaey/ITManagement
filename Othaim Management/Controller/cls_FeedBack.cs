using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Othaim_Management.Controller
{
    class cls_FeedBack
    {
        OthaimITEntities db = new OthaimITEntities();


        


        public void Create(string pageName, string Issus , Byte[] img, string user)
        {
            db.FeedBack.Add(new FeedBack
            {
                PageName = pageName,
                Issus = Issus,
                img = img,
                user_Name = user
                
            });
            db.SaveChanges();
        }

        public List<FeedBack> ListByID(int id)
        {
            var result = db.FeedBack.Where(f=>f.id==id);
            return result.ToList();
        }

        public List<FeedBack> List()
        {
            var result = db.FeedBack.ToList();
            return result.ToList();
        }


    }
}
