using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

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

    }
}
