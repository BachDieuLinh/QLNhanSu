using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLY_NHANSU
{
    public partial class frm_NV : Form
    {
        public frm_NV()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        int chon = 0;
        TimKiem tk = new TimKiem();

        void KhoaDieuKhien()
        {
            txtMaNV.Enabled = txtTenNV.Enabled=dtp_NS.Enabled= cb_GT.Enabled=txtChucVu.Enabled= txtSDT.Enabled= txtLuong.Enabled= txtDiaChi.Enabled  = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        void MoDieuKhien()
        {
            txtMaNV.Enabled = txtTenNV.Enabled=dtp_NS.Enabled= cb_GT.Enabled=txtChucVu.Enabled= txtSDT.Enabled= txtLuong.Enabled= txtDiaChi.Enabled  = true;            
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        void SetNull()
        {
            txtMaNV.Text=txtTenNV.Text=txtChucVu.Text=txtSDT.Text=txtLuong.Text=txtDiaChi.Text="";
            cb_GT.Text="";
            dtp_NS.Text="";
        }

        private void frm_NV_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = nv.HienThiNhanVien();
            dgvNhanVien.DataSource = dt;
            KhoaDieuKhien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaNV.Enabled = false;
            SetNull();
            chon = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaNV.Enabled = false;
            chon = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
                MessageBox.Show("Chọn nhân viên!");
            else
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    nv.XoaNhanVien(txtMaNV.Text);
                    MessageBox.Show("Xóa thành công!");
                    frm_NV_Load(sender, e);
                    SetNull();
                }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                if ( txtTenNV.Text == "" || cb_GT.Text=="" || txtChucVu.Text=="" || txtSDT.Text=="" || txtLuong.Text=="" || txtDiaChi.Text=="")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        nv.ThemNhanVien(txtTenNV.Text,dtp_NS.Text, cb_GT.Text, txtChucVu.Text, txtSDT.Text, txtLuong.Text, txtDiaChi.Text);
                        MessageBox.Show("Thêm thành công!");
                        SetNull();
                        frm_NV_Load(sender, e);
                    }
            }
            else if (chon == 2)
            {
                if (  txtTenNV.Text == "" || cb_GT.Text == "" || txtChucVu.Text == "" || txtSDT.Text == "" || txtLuong.Text == "" || txtDiaChi.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn Sửa nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        nv.SuaNhanVien( txtTenNV.Text, dtp_NS.Text, cb_GT.Text, txtChucVu.Text, txtSDT.Text, txtLuong.Text, txtDiaChi.Text,txtMaNV.Text);
                        MessageBox.Show("Sửa thành công!");
                        SetNull();
                        frm_NV_Load(sender, e);
                    }
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
             
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            try
            {
                txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtp_NS.Value=DateTime.Parse(dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString());
                cb_GT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtChucVu.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                
            }
            catch {
                return;
            }
        }


        private void rbtMaNV_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = tk.TKMaNV(txtTimKiem.Text);
        }

        private void rbtTenNV_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = tk.TKTenNV(txtTimKiem.Text);
        }

        private void rbtDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = tk.TKDiaChiNhanVien(txtTimKiem.Text);
        }

        private void rbtgt_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = tk.TKGTNhanVien(txtTimKiem.Text);
        }

        private void rbtSDT_CheckedChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = tk.TKSDT(txtTimKiem.Text);
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            frm_NV_Load(sender, e);
            SetNull();
            chon = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có chắc muốn thoát ứng dụng này??", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void rbtMaNV_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = tk.TKMaNV(txtTimKiem.Text);
        }

    }
}
