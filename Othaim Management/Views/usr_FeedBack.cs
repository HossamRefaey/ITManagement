using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Othaim_Management.Controller;
using System.Drawing.Imaging;

namespace Othaim_Management.Views
{
    public partial class usr_FeedBack : UserControl
    {
        cls_FeedBack feed = new cls_FeedBack();
        string filePath;
        public usr_FeedBack()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }


        void pictureBox1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.BackgroundImage = new Bitmap(open.FileName);
                filePath = open.FileName;
            }
        }

        private void btn_Save_Edit_Click(object sender, EventArgs e)
        {

            try
            {
                if(!string.IsNullOrWhiteSpace(txt_Name.Text)&& !string.IsNullOrWhiteSpace(txt_Notes.Text)&&pictureBox1.BackgroundImage!=null)
                {
                    feed.Create(txt_Name.Text, txt_Notes.Text, cls_ImageConvert.ConvertFiletoByte(filePath),Properties.Settings.Default.userName);
                    MessageBox.Show("تم تسجيل الملاحظات بنجاح");
                    txt_Name.Clear();
                    txt_Notes.Clear();
                    pictureBox1.BackgroundImage = null;
                    txt_Name.Focus();
                }
                else
                {
                    MessageBox.Show("يرجى إكمال الحقول الناقصة");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        
    }
}
