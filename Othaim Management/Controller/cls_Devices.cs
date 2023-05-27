using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_Devices
    {
        OthaimITEntities db = new OthaimITEntities();
        cls_Users usr = new cls_Users();
        int usrID = 0;

        public List<sys_devices> List()
        {
            var result = db.sys_devices.ToList();
            return result;
        }

        public int DevCountAll()
        {
            int result = db.sys_devices.Count();
            return result;
        }

        public int DevStockCount()
        {
            int result = db.sys_devices.Where(d=>d.sys_branch.Main_Store == true).Count();
            return result;
        }

        public int DevNonStockCount()
        {
            int result = db.sys_devices.Where(d => d.sys_branch.Main_Store == false).Count();
            return result;
        }

        public List<sys_devices> ListByUser()
        {
            
            var res = usr.Search(Properties.Settings.Default.userName).ToList();
            foreach (var item in res)
            {
                usrID = item.User_id;
            }

            var result = db.sys_devices.Where(d=>d.sys_branch.User_id == usrID).ToList();
            return result;
        }

        public void Create(string Name,string Serial, int model_id, int dev_Type, int Category_ID, int type, int stat, DateTime rec_date, string Notes, int cur_branch)
        {
            db.sys_devices.Add(new sys_devices
            {
                Device_id = FirstID(),
                Name = Name,
                SN = Serial,
                model_id = model_id,
                dev_Type_id = dev_Type,
                category_ID = Category_ID,
                type_id = type,
                status_id = stat,
                opr_date = rec_date,
                Notes = Notes,
                branch_id = cur_branch
                //, dept_id = dept_id
            });
            db.SaveChanges();
        }

        public void CreateWithnull(string Name, string Serial, int model_id, int dev_Type, int Category_ID, int type, int stat, DateTime rec_date, string Notes, int cur_branch)
        {
            db.sys_devices.Add(new sys_devices
            {
                Device_id = FirstID(),
                Name = Name,
                SN = Serial,
                model_id = model_id,
                dev_Type_id = dev_Type,
                category_ID = Category_ID,
                type_id = type,
                status_id = stat,
                opr_date = rec_date,
                Notes = Notes,
                branch_id = cur_branch,
                dept_id = null


            });
            db.SaveChanges();
        }

        public int FirstID()
        {
            int id = 1;
            var result = db.sys_devices.ToList();
            if (result.Count() <= 0)
            {
                return id;
            }
            else
            {
                id = db.sys_devices.Max(i => i.Device_id + 1);
                return id;
            }

        }
        public List<sys_devices> ChekSerial(string Serial)
        {
            
            var result = db.sys_devices.Where(s => s.SN == Serial).ToList();
            return result;
        }

        public List<sys_devices> ChekSerialInStore(int store, string Serial)
        {

            var result = db.sys_devices.Where(s => s.SN == Serial && s.branch_id==store).ToList();
            return result;
        }

        public void Update(int id, string Name, string Serial, int model_id, int dev_Type, int Category_ID, string Notes, int cur_branch)
        {
            int devid = id;
            var result = db.sys_devices.Single(x => x.Device_id == devid);
            result.Name = Name;
            result.SN = Serial;
            result.model_id = model_id;
            result.dev_Type_id = dev_Type;
            result.category_ID = Category_ID;
            //result.type_id = type;
            //result.status_id = stat;
            result.Notes = Notes;
            result.branch_id = cur_branch;
            //if (!string.IsNullOrWhiteSpace(curDept))
            //{
            //    result.dept_id = int.Parse(curDept);
            //}
            //else
            //{
            //    result.dept_id = null;
            //}
            db.SaveChanges();

        }

        public void UpdateByBranch(int id, int cur_branch, DateTime rec_date, int stat)
        {
            int devid = id;
            var result = db.sys_devices.Single(x => x.Device_id == devid);
            
            result.branch_id = cur_branch;
            result.dept_id = null;
            result.rec_date = rec_date;
            result.status_id = stat;
            db.SaveChanges();

        }

        public void UpdateByBranchandDept(int id, int cur_branch, int Dept, DateTime rec_date, int stat)
        {
            int devid = id;
            var result = db.sys_devices.Single(x => x.Device_id == devid);

            result.branch_id = cur_branch;
            result.dept_id = Dept;
            result.rec_date = rec_date;
            result.status_id = stat;
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var result = db.sys_devices.Where(x => x.Device_id == id).SingleOrDefault();
            db.sys_devices.Remove(result);
            db.SaveChanges();
        }

        public List<sys_devices> FindByID(int id)
        {
            var result = db.sys_devices.Where(c => c.Device_id == id);
            return result.ToList();
        }

        public List<sys_devices> FindByModel(int id)
        {
            var result = db.sys_devices.Where(c => c.model_id == id);
            return result.ToList();
        }

        public List<sys_devices> FindByModelWithUser(int id)
        {
            var res = usr.Search(Properties.Settings.Default.userName).ToList();
            foreach (var item in res)
            {
                usrID = item.User_id;
            }

            var result = db.sys_devices.Where(c => c.model_id == id && c.sys_branch.User_id == usrID);
            return result.ToList();
        }

        public List<sys_devices> FindByBranch(int id)
        {
            var result = db.sys_devices.Where(c => c.branch_id == id).OrderBy(a=>a.model_id);
            return result.ToList();
        }

        public List<sys_devices> FindByBranchWithUser(int id)
        {
            var res = usr.Search(Properties.Settings.Default.userName).ToList();
            foreach (var item in res)
            {
                usrID = item.User_id;
            }

            var result = db.sys_devices.Where(c => c.branch_id == id && c.sys_branch.User_id == usrID);
            return result.ToList();
        }

        public List<sys_devices> Search(string serial)
        {
            var result = db.sys_devices.Where(s => s.SN == serial).ToList();
            return result;
        }
        public List<sys_devices> SearchWithUser(string serial)
        {
            var res = usr.Search(Properties.Settings.Default.userName).ToList();
            foreach (var item in res)
            {
                usrID = item.User_id;
            }

            var result = db.sys_devices.Where(s => s.SN == serial && s.sys_branch.User_id == usrID).ToList();
            return result;
        }


        public void CreateItemCount(string Name, string Serial, int model_id, int dev_Type, int Category_ID,  DateTime rec_date, int cur_branch)
        {
            db.sys_devices.Add(new sys_devices
            {
                Device_id = FirstID(),
                Name = Name,
                SN = Serial,
                model_id = model_id,
                dev_Type_id = dev_Type,
                category_ID = Category_ID,
                opr_date = rec_date,
                branch_id = cur_branch
                
            });
            db.SaveChanges();
        }
        //public void UpdateCount(string serial,int brID, int count)
        //{
            
        //    var result = db.sys_devices.Single(x => x.SN == serial && x.branch_id==brID);

        //    result.Count = result.Count+count;

            
        //    db.SaveChanges();

        //}

        public List<sys_devices> ChekSerialCount(string Serial , int brID)
        {

            var result = db.sys_devices.Where(s => s.SN == Serial && s.branch_id == brID).ToList();
            return result;
        }


        //------------------- Search by 3 Param ------------//

        public List<sys_devices> SearchBy_Mdl_Null_Br_NotNull(int br)
        {


            var result = db.sys_devices.Where(c=>c.branch_id==br);
            return result.ToList();
            


        }

        public List<sys_devices> SearchBy_Mdl_NotNull_Br_Null(int mdl)
        {


            var result = db.sys_devices.Where(c=>c.model_id==mdl);
            return result.ToList();



        }

        public List<sys_devices> SearchBy_Mdl_NotNull_Br_NotNull(int mdl, int br)
        {


            var result = db.sys_devices.Where(c=>c.model_id==mdl&&c.branch_id==br);
            return result.ToList();



        }

        //--------------------------------------------------//



    }
}
