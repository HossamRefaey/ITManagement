using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_Branch
    {
        
        ///         
        /// Add Commint To Branch Controller
            ////
            ///


        OthaimITEntities db = new OthaimITEntities();

        public List<sys_branch> List()
        {
            var result = db.sys_branch.ToList();
            return result;
        }

        public List<sys_branch> ListByStoreTrue()
        {
            var result = db.sys_branch.Where(c=>c.Main_Store == true).ToList();
            return result;
        }

        public List<sys_branch> ListByStoreFalse()
        {
            var result = db.sys_branch.Where(c => c.Main_Store == false).ToList();
            return result;
        }

        public List<sys_branch> ListByBranchUser(int userid)
        {
            var result = db.sys_branch.Where(c => c.User_id == userid).ToList();
            return result;
        }


        public List<sys_branch> findByID(int id)
        {
            var result = db.sys_branch.Where(s => s.branch_id == id).ToList();
            return result;
        }

        public string GetUserID(string name)
        {
            var result = db.sys_branch.Where(c => c.name == name).ToList();
            string user="";
            foreach (var item in result)
            {
                user = item.sys_Users.UserName;
            }
            return user;

        }

        public List<sys_branch> Search(int param)
        {
            var result = db.sys_branch.Where(s => s.User_id == param || s.branch_id == param ).ToList();
            return result;
        }

        public void Create(int id, string shortid, string name, int userid, Boolean chk)
        {
            db.sys_branch.Add(new sys_branch
            {
                branch_id=id,
                shrt_id=shortid,
                name = name,
                User_id=userid,
                Main_Store=chk
            });
            db.SaveChanges();
        }

        public void Update(int id, string shortid, string name, int userid, Boolean chk)
        {
            var result = db.sys_branch.SingleOrDefault(c => c.branch_id == id);
            result.shrt_id = shortid;
            result.name = name;
            result.User_id = userid;
            result.Main_Store = chk;
            db.SaveChanges();
        }

        public void Delete(int id)
        {

            var result = db.sys_branch.Where(x => x.branch_id == id).SingleOrDefault();

            db.sys_branch.Remove(result);
            db.SaveChanges();

        }


        //--------------------------------------------

        public List<sys_branch> ListByStoreTrueUser(int userID)
        {
            var result = db.sys_branch.Where(c => c.Main_Store == true && c.User_id==userID).ToList();
            return result;
        }

    }
}
