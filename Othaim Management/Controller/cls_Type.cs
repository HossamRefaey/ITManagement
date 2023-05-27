using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_Type
    {
        OthaimITEntities db = new OthaimITEntities();

        public int FirstID()
        {
            int id = 1;
            if (db.sys_Type.Count() >= 1)
            {
                id = db.sys_Type.Max(c => c.type_id + 1);
                return id;
            }
            else
            {
                return id;
            }
        }

        public List<sys_Type> List()
        {
            var result = db.sys_Type.ToList();
            return result;
        }

        public List<sys_Type> FindByID(int id)
        {
            var result = db.sys_Type.Where(c => c.type_id == id).ToList();
            return result;
        }

        public List<sys_Type> Search(string name)
        {
            var result = db.sys_Type.Where(c => c.name.Contains(name)).ToList();
            return result;
        }

        public void Create(string type)
        {
            db.sys_Type.Add(new sys_Type
            {
                type_id = FirstID(),
                name = type
            });
            db.SaveChanges();
        }

        public void Update(int id, string type)
        {
            try
            {
                var result = db.sys_Type.SingleOrDefault(c => c.type_id == id);
                result.name = type;
                db.SaveChanges();
            }
            catch { return; }
        
        }

        public void Delete(int id)
        {
            try
            { 
                var result = db.sys_Type.Where(c => c.type_id == id).SingleOrDefault();
                db.sys_Type.Remove(result);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("يندرج تحت هذه الطبيعة أجهزة يرجى حذف الأجهزة أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
