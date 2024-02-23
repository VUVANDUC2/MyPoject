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
using Windows;

namespace MyProject
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.connStr);
        HocSinhDAO hocSinhDAO = new HocSinhDAO();
        public FHocSinh()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable dt = hocSinhDAO.Load();
            dataGridView1.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value.ToShortDateString());
            hocSinhDAO.Them(hs);
            Form1_Load(sender, e);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value.ToShortDateString());
            hocSinhDAO.Sua(hs);
            Form1_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value.ToShortDateString());
            hocSinhDAO.Xoa(hs);
            Form1_Load(sender, e);
        }
    }
}
