using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;
using System.Windows.Forms;

namespace Othaim_Management.Controller
{
    class cls_Contact_Branches
    {
        OthaimITEntities db = new OthaimITEntities();



        public List<Contact_Branches> findByID(int id)
        {
            var result = db.Contact_Branches.Where(s => s.id == id).ToList();
            return result;
        }



        public List<Contact_Branches> List()
        {
            var result = db.Contact_Branches.OrderBy(c => c.branch_id).ToList();
            return result;
        }

        public void Create(int branch_id, string emp_Name , string job, string Phone)
        {
            try
            {
                db.Contact_Branches.Add(new Contact_Branches
                {
                    branch_id = branch_id,
                    Emp_Name = emp_Name,
                    Job = job,
                    Phone_Num = Phone
                });
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }


        public void Update(int id, int branch_id, string emp_Name, string job, string Phone)
        {
            var result = db.Contact_Branches.Single(x => x.id == id);

            result.branch_id = branch_id;
            result.Emp_Name=emp_Name;
            result.Job=job;
            result.Phone_Num=Phone;
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var result = db.Contact_Branches.Where(x => x.id == id).SingleOrDefault();
            db.Contact_Branches.Remove(result);
            db.SaveChanges();
        }

        //public List<sys_phone> SearchByPhone(string phone)
        //{
        //    var result = db.sys_phone.Where(s => s.simcard == phone || s.LandLine == phone).ToList();
        //    return result;
        //}

        public List<Contact_Branches> SearchByBranch(int branch)
        {
            var result = db.Contact_Branches.Where(s => s.branch_id == branch).ToList();
            return result;
        }
    }
}
