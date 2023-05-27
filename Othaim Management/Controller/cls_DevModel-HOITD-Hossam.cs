using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;
using System.Windows.Forms;

namespace Othaim_Management.Controller
{
    class cls_DevModel
    {
        OthaimITEntities db = new OthaimITEntities();

        public List<sys_dev_model> List()
        {
            var result = db.sys_dev_model.ToList();
            return result;
        }

        public List<sys_dev_model> findByID(int id)
        {
            var result = db.sys_dev_model.Where(s => s.model_id == id).ToList();
            return result;
        }

        public List<sys_dev_model> Search(string name)
        {
            var result = db.sys_dev_model.Where(s => s.Name.Contains(name)).ToList();
            return result;
        }

        public List<sys_dev_model> findByTypeID(int id)
        {
            var result = db.sys_dev_model.Where(s => s.devType_ID == id).ToList();
            return result;
        }

        public int findByTypeName(string Name)
        {
            int id=0;
            var result = db.sys_dev_model.Where(s => s.Name == Name).ToList();
            foreach (var item in result)
            {
                id = item.model_id;
            }
            return id;
        }

        public List<sys_dev_model> DublicateItemCode(string item)
        {
            var result = db.sys_dev_model.Where(c => c.Item_Code.Contains(item)).ToList();
            return result;

        }

        public void Create(string name, string ItemCode, int devTypeID, int categoryID)
        {
            try
            {
                db.sys_dev_model.Add(new sys_dev_model
                {
                    Name = name,
                    Item_Code = ItemCode,
                    devType_ID = devTypeID,
                    category_ID = categoryID
                });

                db.SaveChanges();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return; }
                
            
            
        }

        public void Update(int id, string name, string ItemCode, int devTypeID, int categoryid)
        {
            var result = db.sys_dev_model.SingleOrDefault(b => b.model_id == id);
            result.Name = name;
            result.Item_Code = ItemCode;
            result.devType_ID = devTypeID;
            result.category_ID = categoryid;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var result = db.sys_dev_model.Where(x => x.model_id == id).SingleOrDefault();

            try
            {
                if (MessageBox.Show("تأكيد الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.sys_dev_model.Remove(result);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("يندرج تحت هذا الموديل أجهزة يرجى حذف الجهاز أولا قبل حذف هذا الموديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
    }
}
