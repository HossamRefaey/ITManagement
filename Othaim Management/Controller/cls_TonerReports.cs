using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_TonerReports
    {
        OthaimITEntities db = new OthaimITEntities();

        public List<TonerReports> List()
        {
            var result = db.TonerReports.OrderByDescending(x=>x.Order_Date).ToList();
            return result;
        }

        public List<TonerReports> ListByUser(int usrID)
        {
            var result = db.TonerReports.Where(x => x.User_ID == usrID).ToList();
            return result;
        }

        //public int FirstID()
        //{
        //    int id = 1;
        //    var result = db.TonerReports.ToList();
        //    if (result.Count() <= 0)
        //    {
        //        return id;
        //    }
        //    else
        //    {
        //        id = db.TonerReports.Max(i => i.dept_id + 1);
        //        return id;
        //    }

        //}

        public List<TonerReports> findByTonerID(int id)
        {
            var result = db.TonerReports.Where(s => s.Toner_ID == id).ToList();
            return result;
        }
        public List<TonerReports> findByBranchID(int id)
        {
            var result = db.TonerReports.Where(s => s.Branch_ID == id).ToList();
            return result;
        }

        public List<TonerReports> Search(string id)
        {
            var result = db.TonerReports.Where(s => s.ID == id).ToList();
            return result;
        }


        public List<TonerReports> SearchbyTonerModel(int id)
        {
            var result = db.TonerReports.Where(s => s.sys_Toners.Toner_ID == id).ToList();
            return result;
        }

        public void Create(string id, int branchID, int toner_id, int userid, int printcount, DateTime firstdate, DateTime lastdate,DateTime order, string notes)
        {
            db.TonerReports.Add(new TonerReports
            {
                ID = id,
                Branch_ID = branchID,
                Toner_ID = toner_id,
                User_ID = userid,
                PrintCount = printcount,
                First_Date = firstdate,
                Last_Date = lastdate,
                Order_Date = order,
                Notes = notes

            });
            db.SaveChanges();
        }

        public void Update(string id, int branchID, int toner_id, int userid, int printcount, DateTime firstdate, DateTime lastdate, string notes)
        {
            var result = db.TonerReports.SingleOrDefault(c => c.ID == id);
            result.Branch_ID = branchID;
            result.Toner_ID = toner_id;
            result.User_ID = userid;
            result.PrintCount = printcount;
            result.First_Date = firstdate;
            result.Last_Date = lastdate;
            result.Notes = notes;
            db.SaveChanges();
        }

       
    }
}
