using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;
using System.Windows.Forms;

namespace Othaim_Management.Controller
{
    class cls_Category
    {
        OthaimITEntities db = new OthaimITEntities();

        public List<sys_Category> List()
        {
            var result = db.sys_Category.ToList();
            return result;
        }

        public List<sys_Category> findByID(int id)
        {
            var result = db.sys_Category.Where(s => s.category_ID == id).ToList();
            return result;
        }

        public List<sys_Category> Search(string name)
        {
            var result = db.sys_Category.Where(s => s.Name.Contains(name)).ToList();
            return result;
        }

        public void Insert(string Name, string ShrtName)
        {
            db.sys_Category.Add(new sys_Category
            {
                Name = Name,
                shrt_id = ShrtName
            });

            db.SaveChanges();
        }

        public void Update(int id, string Name, string ShrtName)
        {
            var result = db.sys_Category.SingleOrDefault(b => b.category_ID == id);
            result.Name = Name;
            result.shrt_id = ShrtName;
            db.SaveChanges();
        }

        public void Delete(int id)
        {

            var result = db.sys_Category.Where(x => x.category_ID == id).SingleOrDefault();
            try
            {
                if(MessageBox.Show("تأكيد الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    db.sys_Category.Remove(result);
                    db.SaveChanges();
                }
                
            }
            catch{ MessageBox.Show("يندرج تحت هذا القسم أنواع أجهزة يرجى حذف النوع أولا قبل حذف هذا القسم","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            
        }


    }
}
