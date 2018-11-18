using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_KhachHang
    {
        DataAdapter da;
        public DAO_KhachHang()
        {
            da = new DataAdapter();
        }
        public List<KhachHang> GetKhachHangs(string key = "")
        {
            string sql = "SELECT Id, MaKH, HoTenKH, DiaChi, Sdt, Email  FROM KhachHang";
            if (!string.IsNullOrEmpty(key))
            {
                sql += " WHERE MaKH LIKE '%" + key + "%' " +
                    "OR HoTenKH LIKE '%" + key + "%'" +
                    "OR DiaChi LIKE '%" + key + "%'" +
                    "OR Sdt LIKE '%" + key + "%'"+
                "OR Email LIKE '%" + key + "%'";
                    
            }
            List<KhachHang> khachHangs = new List<KhachHang>();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {

                    khachHangs.Add(new KhachHang
                    {
                        Id = (int)dr[0],
                        MaKH = dr[1].ToString(),
                        HoTenKH = dr[2].ToString(),
                        DiaChi = dr[3].ToString(),
                        Sdt = dr[4].ToString(),
                        Email = dr[5].ToString()
                        
                    });
                }
                da.Disconnet();
                return khachHangs;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<KhachHang>();
            }
        }


        public KhachHang GetKhachHang(int id)
        {
            string sql = "SELECT Id, MaKH, HoTenKH, DiaChi, Sdt, Email FROM KhachHang Where id = " + id;

            KhachHang khachHang = new KhachHang();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    khachHang = new KhachHang
                    {
                        Id = (int)dr[0],
                        MaKH = dr[1].ToString(),
                        HoTenKH = dr[2].ToString(),
                        DiaChi = dr[3].ToString(),
                        Sdt = dr[4].ToString(),
                        Email = dr[5].ToString()
                    };
                }
                da.Disconnet();
                return khachHang;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return khachHang;
            }
        }
        public bool ThemKhachHang(KhachHang kh)
        {
             string sql = @"INSERT INTO KhachHang VALUES( N'" + kh.MaKH + "', N'" + kh.HoTenKH + "', N'" + kh.DiaChi + "', N'" + kh.Sdt + "', N'" + kh.Email + "' )";
            try
            {
                var result = false;
                da.Connect();
                result = da.ExecuteNonQuery(sql) > 0;
                da.Disconnet();
                return result;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool CapNhatKhachHang(KhachHang kh)
        {
            string sql = @"UPDATE KhachHang SET MaKH = N'" + kh.MaKH + "', HoTenKH = N'" + kh.HoTenKH + "', DiaChi = N'" + kh.DiaChi + "', Sdt = N'" + kh.Sdt + "', Email = N'" + kh.Email +  "' WHERE Id = " + kh.Id;
            try
            {
                var result = false;
                da.Connect();
                result = da.ExecuteNonQuery(sql) > 0;
                da.Disconnet();
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool XoaKhachHang(int id)
        {
            string sql = @"DELETE KhachHang WHERE Id = " + id;
            try
            {
                var result = false;
                da.Connect();
                result = da.ExecuteNonQuery(sql) > 0;
                da.Disconnet();
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }

}
