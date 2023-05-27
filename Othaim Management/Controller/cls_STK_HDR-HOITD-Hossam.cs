using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_STK_HDR
    {
        OthaimITEntities db = new OthaimITEntities();


        public int FirstID()
        {
            int id = 1;
            var result = db.STK_HDR.ToList();
            if (result.Count() <= 0)
            {
                return id;
            }
            else
            {
                id = db.STK_HDR.Max(i => i.HDR_ID + 1);
                return id;
            }

        }

        public List<STK_HDR> List()
        {
            var result = db.STK_HDR.ToList();
            return result;
        }

        public void Create(int id, string FromSitenum, string FromSiteName,string ToSitenum, string ToSiteName ,int doctype,string username, int usercode, string empName, int empCode, DateTime date)
        {
            db.STK_HDR.Add(new STK_HDR
            {
                HDR_ID = id,
                from_Site_Num = FromSitenum,
                to_Site_Num = ToSitenum,
                from_Site_Name=FromSiteName,
                to_Site_Name=ToSiteName,
                doc_type_id = doctype,
                userName=username,
                userCode=usercode,
                Emp_Name=empName,
                Emp_Code=empCode,
                date =date
                
                
            });
            db.SaveChanges();
        }
    }
}
