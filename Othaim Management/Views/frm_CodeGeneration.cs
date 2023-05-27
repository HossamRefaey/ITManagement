using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Othaim_Management.Model;
using ZXing;

namespace Othaim_Management.Views
{
    public partial class frm_CodeGeneration : Form
    {
        OthaimITEntities db = new OthaimITEntities();


       

        void cbx_CategoryFill()
        {
            cbx_Category.DataSource = db.sys_Category.ToList();

            cbx_Category.ValueMember = "ID";
            cbx_Category.DisplayMember = "Name";



        }

        public frm_CodeGeneration()
        {
            InitializeComponent();
        }

        private void frm_CodeGeneration_Load(object sender, EventArgs e)
        {
            cbx_CategoryFill();
            cbx_Category.SelectedIndex = -1;
            textBox1.Text = "";
        }

        private void cbx_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guid gd = Guid.NewGuid();

            try
            {
                int id = int.Parse(cbx_Category.SelectedValue.ToString());
                var result = db.sys_Category.Where(C => C.ID == id).FirstOrDefault();
                string shrt_id = result.shrt_id;
                string trimmed = String.Concat(shrt_id.Where(c => !Char.IsWhiteSpace(c)));
                string serial = "OTH" + trimmed + gd;
                string final = serial.Substring(0, 10).ToUpper();

                textBox1.Text = final;
            }
            catch (Exception) { return; }

        }


        private void PrintPage(object o, PrintPageEventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };


            //pictureBox1.Image = writer.Write(textBox1.Text);
            System.Drawing.Image img = writer.Write(textBox1.Text);
            Point loc = new Point(50, 50);
            e.Graphics.DrawImage(img, loc);
        }
        private void button1_Click(object sender, EventArgs e)
        {



            

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;
            pd.Print();


            //usr_Devices frm = new usr_Devices();
            //frm.txt_SN.Text = textBox1.Text;
            //Close();
        }
    }
}
