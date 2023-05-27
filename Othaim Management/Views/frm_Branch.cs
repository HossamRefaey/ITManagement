using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othaim_Management.Model;

namespace Othaim_Management.Views
{
    public partial class frm_Branch : Form
    {
        JobDBEntities db = new JobDBEntities();

        public frm_Branch()
        {
            InitializeComponent();
            

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //db.sys_branch.Add(new sys_branch
            //{
            //    id = int.Parse(txt_ID.Text),
            //    a_manager_id = int.Parse(cbx_AreaMgr.SelectedValue.ToString()),
            //    user_id = int.Parse(cbx_Users.SelectedValue.ToString())
            //});

            //db.SaveChanges();
            //dgvfill();

        }

        void dgvfill()
        {

            dgv_BranchList.Rows.Clear();
            var result = db.sys_branch.ToList();
            int rowindex = 0;


            foreach (var item in result)
            {
                dgv_BranchList.Rows.Add(1);
                dgv_BranchList.Rows[rowindex].Cells[0].Value = item.id.ToString();
                dgv_BranchList.Rows[rowindex].Cells[2].Value = item.sys_AreaMgrs.Name;
                dgv_BranchList.Rows[rowindex].Cells[3].Value = item.sys_Users.Name;
                rowindex ++;
            }

        }

        void cbx_AreaMgrfill()
        {

            cbx_AreaMgr.DataSource = db.sys_AreaMgrs.ToList();

            cbx_AreaMgr.ValueMember = "id";          
            cbx_AreaMgr.DisplayMember = "Name";

            
        }

        void cbx_Usersfill()
        {

            cbx_Users.DataSource = db.sys_Users.ToList();

            cbx_Users.ValueMember = "id";
            cbx_Users.DisplayMember = "Name";


        }

        private void frm_Branch_Load(object sender, EventArgs e)
        {
            dgvfill();
            cbx_AreaMgrfill();
            cbx_Usersfill();
            //txt_Name.Text = dgv_BranchList.Rows[0].Cells[2].Value.ToString();
        }

        private void Refrish_Click(object sender, EventArgs e)
        {
            frm_Branch_Load(sender, e);
        }
    }
}
