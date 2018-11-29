using DTO;
using System;

namespace DAO
{
    public class DAO_TaiKhoan
    {
        DataAdapter da;
        public DAO_TaiKhoan()
        {
            da = new DataAdapter();
        }

        public bool CheckLogIn(string username, string password)
        {
            string sql = "SELECT UserId FROM TaiKhoan WHERE Username = '" + username + "' AND Password = '" + password +"'";
            try
            {
                var result = false;
                da.Connect();
                
                var dr = da.ExecuteScalar(sql);
                result = dr != null;
                da.Disconnet();
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetUserId(string username, string password)
        {
            string sql = "SELECT UserId FROM TaiKhoan WHERE Username = '" + username + "' AND Password = '" + password + "'";
            try
            {
                var result = -1;
                da.Connect();

                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    if(dr != null)
                    {
                        result = (int)dr[0];
                    }
                }
                da.Disconnet();
                return result;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public bool TaoTaiKhoan(TaiKhoan tk)
        {
            string sql = @"INSERT INTO TaiKhoan VALUES('" + tk.Username + "', '" + tk.Password + "', " + tk.UserId +  ")";
            try
            {
                var result = false;
                da.Connect();
                result =  da.ExecuteNonQuery(sql) > 0;
                da.Disconnet();
                return result;
            }
            catch (Exception)
            {
               
                return false;
            }
        }

        public bool DoiMatKhau(string password, int id)
        {
            string sql = @"UPDATE TaiKhoan SET Password = '" + password + "' WHERE Id = " + id;
            try
            {
                var result = false;
                da.Connect();
                result = da.ExecuteNonQuery(sql) > 0;
                da.Disconnet();
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public TaiKhoan GetTaiKhoanNhanVienHienTai(int id)
        {
            TaiKhoan tk = new TaiKhoan();
            string sql = @"SELECT Id, Username, Password, UserId FROM TaiKhoan WHERE UserId = " + id;
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    if (dr != null)
                    {
                        tk.Id = (int)dr[0];
                        tk.Username = dr[1].ToString().Trim();
                        tk.Password = dr[2].ToString().Trim();
                        tk.UserId = (int)dr[3];
                    }
                    else
                        tk = null;
                }
                da.Disconnet();
                return tk;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
