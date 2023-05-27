using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_Phone
    {
        OthaimITEntities db = new OthaimITEntities();

        public int FirstID()
        {
            int id = 1;
            var result = db.sys_phone.ToList();
            if (result.Count() <= 0)
            {
                return id;
            }
            else
            {
                id = db.sys_phone.Max(i => i.phone_id + 1);
                return id;
            }

        }

        public List<sys_phone> findByID(int id)
        {
            var result = db.sys_phone.Where(s => s.phone_id == id).ToList();
            return result;
        }

        public List<sys_phone> List()
        {
            var result = db.sys_phone.OrderBy(c=>c.branch_id).ToList();
            return result;
        }

        public void Create(int id, string simcard, string serial, string landline, string Quota, string Note, int branchid)
        {
            db.sys_phone.Add(new sys_phone {
                phone_id = id,
                simcard = simcard,
                simCardSerial = serial,
                LandLine = landline,
                Quota = Quota,
                note = Note,
                branch_id = branchid
            });
            db.SaveChanges();
        }

        public void Update(int id, string simcard, string serial, string landline,string Quota, string Note, int branchid)
        {
            var result = db.sys_phone.Single(x => x.phone_id == id);

            result.simcard = simcard;
            result.simCardSerial = serial;
            result.LandLine = landline;
            result.Quota = Quota;
            result.note = Note;
            result.branch_id = branchid;
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var result = db.sys_phone.Where(x => x.phone_id == id).SingleOrDefault();
            db.sys_phone.Remove(result);
            db.SaveChanges();
        }

        public List<sys_phone> SearchByPhone(string phone)
        {
            var result = db.sys_phone.Where(s => s.simcard == phone || s.LandLine == phone).ToList();
            return result;
        }

        public List<sys_phone> SearchByBranch(int branch)
        {
            var result = db.sys_phone.Where(s => s.branch_id == branch).ToList();
            return result;
        }
    }
}
