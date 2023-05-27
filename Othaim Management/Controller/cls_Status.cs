using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_Status
    {
        OthaimITEntities db = new OthaimITEntities();

        public int FirstID()
        {
            int id = 1;
            if (db.sys_status.Count() >= 1)
            {
                id = db.sys_status.Max(c => c.status_id + 1);
                return id;

            }
            else
            {
                return id;
            }
        }

        public List<sys_status> List()
        {
            var result = db.sys_status.ToList();
            return result;
        }

        public List<sys_status> FindByID(int id)
        {
            var result = db.sys_status.Where(c => c.status_id == id).ToList();
            return result;
        }

        public List<sys_status> Search(string name)
        {
            var result = db.sys_status.Where(c => c.status.Contains(name)).ToList();
            return result;
        }

        public void Create(string status)
        {
            db.sys_status.Add(new sys_status
            {
                status_id = FirstID(),
                status = status
            });
            db.SaveChanges();
        }

        public void Update(int id, string status)
        {
            try
            {
                var result = db.sys_status.SingleOrDefault(c => c.status_id == id);
                result.status = status;
                db.SaveChanges();
            }
            catch { return; }
            
        }

        public void Delete(int id)
        {
            try
            {

            
                var result = db.sys_status.Where(c => c.status_id == id).SingleOrDefault();
                db.sys_status.Remove(result);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("يندرج تحت هذه الحالة أجهزة يرجى حذف الأجهزة أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
