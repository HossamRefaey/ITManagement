using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_Dept
    {
        OthaimITEntities db = new OthaimITEntities();

        public List<sys_Dept> List()
        {
            var result = db.sys_Dept.ToList();
            return result;
        }

        public int FirstID()
        {
            int id = 1;
            var result = db.sys_Dept.ToList();
            if (result.Count() <= 0)
            {
                return id;
            }
            else
            {
                id = db.sys_Dept.Max(i => i.dept_id + 1);
                return id;
            }

        }

        public List<sys_Dept> findByID(int id)
        {
            var result = db.sys_Dept.Where(s => s.dept_id == id).ToList();
            return result;
        }

        public List<sys_Dept> findByBranchID(int id)
        {
            var result = db.sys_Dept.Where(s => s.branch_id == id).ToList();
            return result;
        }

        


        public List<sys_Dept> Search(string name)
        {
            var result = db.sys_Dept.Where(s => s.name.Contains(name)).ToList();
            return result;
        }

        public void Create(int id, string name, int branchID)
        {
            db.sys_Dept.Add(new sys_Dept
            {
                dept_id = id,
                name = name,
                branch_id= branchID

            });
            db.SaveChanges();
        }

        public void Update(int id, string name, int branchID)
        {
            var result = db.sys_Dept.SingleOrDefault(c => c.dept_id == id);
            result.name = name;
            result.branch_id = branchID;
            db.SaveChanges();
        }

        public void Delete(int id)
        {

            var result = db.sys_Dept.Where(x => x.dept_id == id).SingleOrDefault();

            db.sys_Dept.Remove(result);
            db.SaveChanges();

        }
    }
}
