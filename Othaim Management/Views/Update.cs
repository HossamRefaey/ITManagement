using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Othaim_Management.Controller;
using System.Diagnostics;

namespace Othaim_Management.Views
{
    public partial class Update : DevExpress.XtraEditors.XtraForm
    {
        cls_Update update = new cls_Update();
        string path;
        public Update()
        {
            InitializeComponent();
        }

        void InfoList()
        {
            var result = update.List();
            foreach (var item in result)
            {
                txt_Ver.Text = item.ver;
                txt_Date.Text = Convert.ToDateTime(item.ver_date).ToString("yyyy-MM-dd");
                path = item.update_path;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Update_Load(object sender, EventArgs e)
        {
            InfoList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(path);
                Application.Exit();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            // opens the folder in explorer
            //// opens the folder in explorer
            //Process.Start("explorer.exe", @"c:\");
            //// throws exception
            //Process.Start(@"c:\does_not_exist");
            //// opens explorer, showing some other folder)
            //Process.Start("explorer.exe", @"c:\does_not_exist");
        }
    }
}