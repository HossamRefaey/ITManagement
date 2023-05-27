using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_Users
    {
        OthaimITEntities db = new OthaimITEntities();
        public List<sys_Users> List()
        {
            var result = db.sys_Users.ToList();
            return result;
        }

        public List<sys_Users> List_By_Disabled_False()
        {
            var result = db.sys_Users.Where(u => u.accountDisabled == false && u.Thechnical == true).ToList();
            return result;
        }

        public int FirstID()
        {
            int id = 1;
            var result = db.sys_Users.ToList();
            if (result.Count() <= 0)
            {
                return id;
            }
            else
            {
                id = db.sys_Users.Max(i => i.User_id + 1);
                return id;
            }
        }

        //void CreatePermission()
        //{
        //    db.sys_Users.Add(new sys_Users
        //    {
        //        brWin = false,
        //        brNewbtn = false,
        //        brEditbtn = false,
        //        brDeletebtn = false,
        //        deptWin = false,
        //        deptNewbtn = false,
        //        deptEditbtn = false,
        //        deptDeletebtn = false,
        //        usrWin = false,
        //        usrNewbtn = false,
        //        usrEditbtn = false,
        //        usrDeletebtn = false,
        //        catWin = false,
        //        catNewbtn = false,
        //        catEditbtn = false,
        //        catDeletebtn = false,
        //        devTypeWin = false,
        //        devTypeNewbtn = false,
        //        devTypeEditbtn = false,
        //        devTypeDeletebtn = false,
        //        mdlWin = false,
        //        mdlNewbtn = false,
        //        mdlEditbtn = false,
        //        mdlDeletebtn = false,
        //        typeWin = false,
        //        typeNewbtn = false,
        //        typeEditbtn = false,
        //        typeDeletebtn = false,
        //        statWin = false,
        //        statNewbtn = false,
        //        statEditbtn = false,
        //        statDeletebtn = false,
        //        devWin = false,
        //        devNewbtn = false,
        //        devEditbtn = false,
        //        devDeletebtn = false,
        //        transoutWin = false
        //    });
        //    db.SaveChanges();
        //}

        public void Create(string name, string phone, string Email, int jobcode, string username, string password, bool mustPassChng, bool userDisabled)
        {
            db.sys_Users.Add(new sys_Users
            {
                User_id = FirstID(),
                Name = name,
                Phone = phone,
                Email = Email,
                JobCode = jobcode,
                UserName = username,
                Password = password,
                mustPassChange = mustPassChng,
                accountDisabled = userDisabled,
                brWin = false,
                brNewbtn = false,
                brEditbtn = false,
                brDeletebtn = false,
                deptWin = false,
                deptNewbtn = false,
                deptEditbtn = false,
                deptDeletebtn = false,
                usrWin = false,
                usrNewbtn = false,
                usrEditbtn = false,
                usrDeletebtn = false,
                catWin = false,
                catNewbtn = false,
                catEditbtn = false,
                catDeletebtn = false,
                devTypeWin = false,
                devTypeNewbtn = false,
                devTypeEditbtn = false,
                devTypeDeletebtn = false,
                mdlWin = false,
                mdlNewbtn = false,
                mdlEditbtn = false,
                mdlDeletebtn = false,
                typeWin = false,
                typeNewbtn = false,
                typeEditbtn = false,
                typeDeletebtn = false,
                statWin = false,
                statNewbtn = false,
                statEditbtn = false,
                statDeletebtn = false,
                devWin = false,
                devNewbtn = false,
                devEditbtn = false,
                devDeletebtn = false,
                transoutWin = false
            });
            db.SaveChanges();

        }

        public void Update(int id, string name, string phone, string Email, int jobcode, string username/*, string password*/)
        {
            
            var result = db.sys_Users.SingleOrDefault(c => c.User_id == id);
            result.Name = name;
            result.Phone = phone;
            result.Email = Email;
            result.JobCode = jobcode;
            result.UserName = username;
            //result.Password = password;
            db.SaveChanges();

        }

        public void UpdatePermission(int id, bool brWin, bool brNewbtn,bool brEditbtn,bool brDeletebtn,bool deptWin,bool deptNewbtn,bool deptEditbtn,
            bool deptDeletebtn,bool usrWin,bool usrNewbtn,bool usrEditbtn,bool usrDeletebtn, bool catWin, bool catNewbtn,bool catEditbtn, bool catDeletebtn,
            bool devTypeWin,bool devTypeNewbtn,bool devTypeEditbtn, bool devTypeDeletebtn, bool mdlWin, bool mdlNewbtn, bool mdlEditbtn, bool mdlDeletebtn,
            bool typeWin, bool typeNewbtn, bool typeEditbtn, bool typeDeletebtn, bool statWin, bool statNewbtn, bool statEditbtn,bool statDeletebtn, bool devWin, 
            bool devNewbtn, bool devEditbtn, bool devDeletebtn, bool transoutWin)
        {
            
            var result = db.sys_Users.SingleOrDefault(c => c.User_id == id);

            result.brWin = brWin;
            result.brNewbtn = brNewbtn;
            result.brEditbtn = brEditbtn;
            result.brDeletebtn = brDeletebtn;
            result.deptWin = deptWin;
            result.deptNewbtn = deptNewbtn;
            result.deptEditbtn = deptEditbtn;
            result.deptDeletebtn = deptDeletebtn;
            result.usrWin = usrWin;
            result.usrNewbtn = usrNewbtn;
            result.usrEditbtn = usrEditbtn;
            result.usrDeletebtn = usrDeletebtn;
            result.catWin = catWin;
            result.catNewbtn = catNewbtn;
            result.catEditbtn = catEditbtn;
            result.catDeletebtn = catDeletebtn;
            result.devTypeWin = devTypeWin;
            result.devTypeNewbtn = devTypeNewbtn;
            result.devTypeEditbtn = devTypeEditbtn;
            result.devTypeDeletebtn = devTypeDeletebtn;
            result.mdlWin = mdlWin;
            result.mdlNewbtn = mdlNewbtn;
            result.mdlEditbtn = mdlEditbtn;
            result.mdlDeletebtn = mdlDeletebtn;
            result.typeWin = typeWin;
            result.typeNewbtn = typeNewbtn;
            result.typeEditbtn = typeEditbtn;
            result.typeDeletebtn = typeDeletebtn;
            result.statWin = statWin;
            result.statNewbtn = statNewbtn;
            result.statEditbtn = statEditbtn;
            result.statDeletebtn = statDeletebtn;
            result.devWin = devWin;
            result.devNewbtn = devNewbtn;
            result.devEditbtn = devEditbtn;
            result.devDeletebtn = devDeletebtn;
            result.transoutWin = transoutWin;
            db.SaveChanges();

        }

        public void UpdatePass(int id, string password, bool must, bool disabled)
        {

            var result = db.sys_Users.SingleOrDefault(c => c.User_id == id);
            
            result.Password = password;
            result.mustPassChange = must;
            result.accountDisabled = disabled;
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            
                var result = db.sys_Users.Where(c => c.User_id == id).SingleOrDefault();
                db.sys_Users.Remove(result);
                db.SaveChanges();
            
        }

        public List<sys_Users> FindByID(int id)
        {
            var result = db.sys_Users.Where(c=>c.User_id == id).ToList();
            return result;
        }

        public List<sys_Users> Search(string param)
        {
            var result = db.sys_Users.Where(c => c.Name.Contains(param) ||c.UserName.Contains(param)).ToList();
            return result;
        }

        public List<sys_Users> SearchByUser(string param)
        {
            var result = db.sys_Users.Where(c => c.UserName==param).ToList();
            return result;
        }

        public List<sys_Users> SearchByPassword(string user, string pass)
        {
            var result = db.sys_Users.Where(c => c.UserName == user && c.Password == pass).ToList();
            return result;
        }

        public void accDis(int id, bool disabled)
        {
            var result = db.sys_Users.SingleOrDefault(c => c.User_id == id);

            
            result.accountDisabled = disabled;
            db.SaveChanges();
        }

        public List<sys_Users> ResetPass(string param)
        {
            var result = db.sys_Users.Where(c => c.UserName==param).ToList();
            return result;
        }
        public void UpdateLoginCount(string userName)
        {

            var result = db.sys_Users.SingleOrDefault(c => c.UserName == userName);

            result.LoginCount += 1;

            db.SaveChanges();

        }
    }
}
