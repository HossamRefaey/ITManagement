using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_deviceCycle
    {

        OthaimITEntities db = new OthaimITEntities();

        public List<device_Cycle> List()
        {
            var result = db.device_Cycle.ToList();
            return result;
        }

        public List<device_Cycle> Search(string serial)
        {
            var result = db.device_Cycle.Where(d=>d.dev_SN == serial).ToList();
            return result;
        }

        public void Create(int dev_id, string tosite, string dev_SN,int doctype,int stk_hdr, DateTime date)
        {
            db.device_Cycle.Add(new device_Cycle
            {
                device_id=dev_id,
                To_SIte=tosite,
                dev_SN= dev_SN,
                DocType_ID=doctype,
                HDR_ID=stk_hdr,
                date=date

            });
            db.SaveChanges();
        }

        public void Update(int id, string dev_SN)
        {
            var result = db.device_Cycle.Where(c => c.device_id == id).ToList();
            foreach (var item in result)
            {
                item.dev_SN = dev_SN;

            }
            db.SaveChanges();
        }

        public void CreateDev(int dev_id, string tosite, string dev_SN,int doc_type, DateTime date)
        {
            db.device_Cycle.Add(new device_Cycle
            {
                device_id = dev_id,
                To_SIte = tosite,
                dev_SN = dev_SN,
                DocType_ID = doc_type,
                HDR_ID = null,
                date = date
            });
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var result = db.device_Cycle.Where(x => x.device_id == id).SingleOrDefault();
            db.device_Cycle.Remove(result);
            db.SaveChanges();
        }
        //public void CreateWithNull(int dev_id, string dev_SN, int brid, DateTime date)
        //{
        //    db.device_Cycle.Add(new device_Cycle
        //    {
        //        dev_id = dev_id,
        //        dept_id = null,
        //        dev_SN = dev_SN,
        //        branch_id = brid,
        //        date = date
        //    });
        //    db.SaveChanges();
        //}

    }
}
