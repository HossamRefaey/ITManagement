using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_Toners
    {
        OthaimITEntities db = new OthaimITEntities();

        public List<sys_Toners> List()
        {
            var result = db.sys_Toners.ToList();
            return result;
        }
       

        public List<sys_Toners> findByID(int id)
        {
            var result = db.sys_Toners.Where(s => s.Toner_ID == id).ToList();
            return result;
        }


        public List<sys_Toners> Search(string name)
        {
            var result = db.sys_Toners.Where(s => s.Toner_Name.Contains(name)).ToList();
            return result;
        }

        public void Create(string name, int print_average)
        {
            db.sys_Toners.Add(new sys_Toners
            {
                
                Toner_Name = name,
                Print_Avarage =print_average
                

            });
            db.SaveChanges();
        }

        public void Update(int id, string name, int print_average)
        {
            var result = db.sys_Toners.SingleOrDefault(c => c.Toner_ID == id);
            result.Toner_Name = name;
            result.Print_Avarage = print_average;
            db.SaveChanges();
        }

        public void Delete(int id)
        {

            var result = db.sys_Toners.Where(x => x.Toner_ID == id).SingleOrDefault();

            db.sys_Toners.Remove(result);
            db.SaveChanges();

        }
    }
}
