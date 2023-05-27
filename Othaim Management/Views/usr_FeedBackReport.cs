using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othaim_Management.Controller;

namespace Othaim_Management.Views
{
    public partial class usr_FeedBackReport : UserControl
    {
        cls_FeedBack feed = new cls_FeedBack();

        void refresh()
        {
            dgvfill();
        }

        void dgvfill()
        {
            try
            {
                dgv_FeedBackList.Rows.Clear();
                var result = feed.List();
                int rowindex = 0;


                foreach (var item in result)
                {
                    dgv_FeedBackList.Rows.Add(1);
                    dgv_FeedBackList.Rows[rowindex].Cells[0].Value = item.id.ToString();
                    dgv_FeedBackList.Rows[rowindex].Cells[1].Value = item.user_Name;


                    rowindex++;
                }
            }
            catch { return; }
        }

        public usr_FeedBackReport()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void usr_FeedBackReport_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void dgv_FeedBackList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var result = feed.ListByID(int.Parse(dgv_FeedBackList.CurrentRow.Cells[0].Value.ToString()));


                foreach (var item in result)
                {
                    txt_Name.Text = item.PageName;
                    txt_Notes.Text = item.Issus;
                    pictureBox1.BackgroundImage = cls_ImageConvert.ConvertBytetoImage(item.img);


                }
            }
            catch { return; }
        }
    }
}
