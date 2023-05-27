using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{
    class cls_STK_DTL
    {
        OthaimITEntities db = new OthaimITEntities();

        public List<STK_DTL> List()
        {
            var result = db.STK_DTL.ToList();
            return result;
        }

        public void Create(int id, int devID, string ItemName, string Serial, string Model,string itemCode)
        {
            db.STK_DTL.Add(new STK_DTL
            {
                HDR_ID = id,
                Device_id = devID,
                device_name = ItemName,
                model_Name = Model,
                item_Code = itemCode,
                device_SN=Serial
            });
            db.SaveChanges();
        }

    }
}
