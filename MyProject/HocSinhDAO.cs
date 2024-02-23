using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows;

namespace MyProject
{
    internal class HocSinhDAO
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.connStr);
        public DataTable Load()
        {
            DataTable dtSinhVien = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM HocSinh");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);

                adapter.Fill(dtSinhVien);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtSinhVien;
        }
        public void ThucThi(string db)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(db, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show(" Thanh Cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" That Bai" + ex);
            }
            finally
            {
                conn.Close();

            }

        }
        public void Them(HocSinh hs)
        {
            string sqlStr = string.Format("INSERT INTO HocSinh(Ten , Diachi,CMND,NgaySinh) VALUES ('{0}', '{1}','{2}','{3}')", hs.Ten, hs.Diachi, hs.Cmnd, hs.Ngaysinh);
            ThucThi(sqlStr);

        }
        public void Sua(HocSinh hs)
        {
            string SQL = string.Format("UPDATE   HocSinh SET Ten='{0}' , Diachi='{1}' WHERE Cmnd ='{2}'", hs.Ten, hs.Diachi, hs.Cmnd, hs.Ngaysinh);
            ThucThi(SQL);
        }
        public void Xoa(HocSinh hs)
        {
            string SQL1 = string.Format("DELETE FROM HocSinh WHERE CMND = '{0}'", hs.Cmnd);
            ThucThi(SQL1);
        }
    }
}
