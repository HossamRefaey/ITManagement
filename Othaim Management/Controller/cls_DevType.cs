using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;
using System.Windows.Forms;

namespace Othaim_Management.Controller
{
    class cls_DevType
    {
        OthaimITEntities db = new OthaimITEntities();

        public List<sys_dev_type> List()
        {
            var result = db.sys_dev_type.ToList();
            return result;
        }

        public void Create(string name, int catid)
        {
            db.sys_dev_type.Add(new sys_dev_type
            {
                dev_type = name,
                Category_ID = catid

            });

            db.SaveChanges();
        }

        public List<sys_dev_type> findByID(int id)
        {
            var result = db.sys_dev_type.Where(s => s.devType_ID == id).ToList();
            return result;
        }

        public List<sys_dev_type> Search(string name)
        {
            var result = db.sys_dev_type.Where(s => s.dev_type.Contains(name)).ToList();
            return result;
        }

        public List<sys_dev_type> findByCatID(int id)
        {
            var result = db.sys_dev_type.Where(s => s.Category_ID == id).ToList();
            return result;
        }

        public void Update(int id, string Name, int catID)
        {
            var result = db.sys_dev_type.SingleOrDefault(b => b.devType_ID == id);
            result.dev_type = Name;
            result.Category_ID = catID;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var result = db.sys_dev_type.Where(x => x.devType_ID == id).SingleOrDefault();
            try
            {
                if (MessageBox.Show("تأكيد الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.sys_dev_type.Remove(result);
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("يندرج تحت هذا النوع موديلات أجهزة يرجى حذف الموديل أولا قبل حذف هذا النوع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
    }
}
