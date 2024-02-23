using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows;

namespace MyProject
{
    public partial class FGiangVien : Form
    {

        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.connStr);
        GiangVienDAO giangvienDAO = new GiangVienDAO();
        public FGiangVien()
        {
            InitializeComponent();
        }

        private void FGiangVien_Load(object sender, EventArgs e)
        {
            DataTable dt = giangvienDAO.Load();
            dataGridView2.DataSource = dt;
        }


         private void btnThem_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(txtName.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value.ToShortDateString());
            giangvienDAO.Them(gv);
            FGiangVien_Load(sender, e);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(txtName.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value.ToShortDateString());
            giangvienDAO.Sua(gv);
            FGiangVien_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien(txtName.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value.ToShortDateString());
            giangvienDAO.Xoa(gv);
            FGiangVien_Load(sender, e);
        }
    }
}
