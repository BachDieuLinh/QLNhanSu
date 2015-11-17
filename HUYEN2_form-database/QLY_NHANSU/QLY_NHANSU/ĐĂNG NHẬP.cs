using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLY_NHANSU
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        dangnhap dn = new dangnhap();

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            Form1 frm = new Form1();
            if (dn.DangNhap(txtTen.Text, txtMK.Text) == true)
            {
                frm.Show();
                this.Hide();
                 
            }
                
            else MessageBox.Show("Bạn đã nhập sai thông tin? mời bạn thử lại!");
        }
    }
}
