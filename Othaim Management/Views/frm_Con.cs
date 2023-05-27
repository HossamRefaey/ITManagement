using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Othaim_Management.Views
{
    public partial class frm_Con : Form
    {


        public frm_Con()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            var con = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string key = "JobDBEntities";
            string value = "data source";
            con.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            con.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.EntityClient";
            con.Save(ConfigurationSaveMode.Modified);

            //var name = ConfigurationManager.ConnectionStrings[0];
            ////var name = Conf["JobDBEntities"];
            MessageBox.Show(con.ToString());


        }
    }
}
