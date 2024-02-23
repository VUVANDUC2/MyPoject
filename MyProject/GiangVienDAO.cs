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
    internal class GiangVienDAO
    {
        SqlConnection conn = new
       SqlConnection(Properties.Settings.Default.connStr);
        public DataTable Load()
        {
            DataTable dtGiangVien = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM GiangVien");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);

                adapter.Fill(dtGiangVien);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtGiangVien;
        }
        public void Them(GiangVien gv)
        {
            string sql = string.Format("INSERT INTO GiangVien (Ten , Diachi,CMND,NgaySinh) VALUES ('{0}', '{1}','{2}','{3}')", gv.Ten, gv.Diachi, gv.Cmnd, gv.Ngaysinh);
            ThucThi(sql);

        }
        public void Sua(GiangVien gv)
        {
            string SQL = string.Format("UPDATE   GiangVien SET Ten='{0}' , Diachi='{1}' WHERE Cmnd ='{2}'", gv.Ten, gv.Diachi, gv.Cmnd, gv.Ngaysinh);
            ThucThi(SQL);
        }
        public void Xoa(GiangVien gv)
        {
            string SQL1 = string.Format("DELETE FROM GiangVien WHERE CMND = '{0}'", gv.Cmnd);
            ThucThi(SQL1);
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
    }
}
