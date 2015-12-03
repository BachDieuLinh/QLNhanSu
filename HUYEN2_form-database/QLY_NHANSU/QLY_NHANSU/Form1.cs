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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



         

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có chắc muốn thoát ứng dụng này??", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NV nv = new frm_NV();
            nv.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmDangNhap frm_dn = new frmDangNhap();
            frm_dn.Close();
        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    frmHuongDan frm = new frmHuongDan();
        //    frm.ShowDialog();
        //    frm.Close();
        //    frm.Dispose();
        //}

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }
    }
}
