using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_Kho
    {
        DataAdapter da;
        public DAO_Kho()
        {
            da = new DataAdapter();
        }

        public List<Kho> GetKhos(string key = "")
        {
            string sql = "SELECT Id, MaKho, TenKho FROM Kho";
            if (!string.IsNullOrEmpty(key))
            {
                sql += " WHERE MaKho LIKE + N'%" + key + "%' OR "
                    + "TenKho LIKE + N'%" + key + "%'";
            }
            List<Kho> khos = new List<Kho>();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    khos.Add(new Kho
                    {
                        Id = (int)dr[0],
                        MaKho = dr[1].ToString(),
                        TenKho = dr[2].ToString()
                    });
                }
                da.Disconnet();
                return khos;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<Kho>() ;
            }
        }

        public Kho GetKho(int id)
        {
            string sql = "SELECT Id, MaKho, TenKho FROM Kho WHERE Id = " + id;
            Kho nhaCungCap = new Kho();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    nhaCungCap = new Kho
                    {
                        Id = (int)dr[0],
                        MaKho = dr[1].ToString(),
                        TenKho = dr[2].ToString()
                    };
                }
                da.Disconnet();
                return nhaCungCap;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new Kho();
            }
        }

        public bool ThemKho(Kho kho)
        {
            string sql = @"INSERT INTO Kho VALUES(N'" + kho.MaKho + "', N'" + kho.TenKho + "')";
            try
            {
                var result = false;
                da.Connect();
                result =  da.ExecuteNonQuery(sql) > 0;
                da.Disconnet();
                return result;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool CapNhatKho(Kho kho)
        {
            string sql = @"UPDATE Kho SET MaKho = N'" + kho.MaKho + "', TenKho = N'" + kho.TenKho + "' WHERE Id = " + kho.Id;
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

        public bool XoaKho(int id)
        {
            string sql = @"DELETE Kho WHERE Id = " + id;
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

        public bool NhapHangVaoKho(int nhanVienId, int khoId, List<ChiTietHoaDonMua> chiTietHoaDonMuas)
        {
            if (chiTietHoaDonMuas.Any())
            {
                foreach (var chiTietHoaDonMua in chiTietHoaDonMuas)
                {
                    try
                    {
                        string sql = @"INSERT INTO ChiTietKho VALUES (" + chiTietHoaDonMua.SanPhamId + ", " + khoId + ", '" + DateTime.Now + "', " + chiTietHoaDonMua.SoLuong + ", " + nhanVienId + ")";
                        da.Connect();
                        da.ExecuteNonQuery(sql);
                        da.Disconnet();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool CheckTonTaiKhoByTen(string name)
        {
            string sql = "SELECT Id FROM Kho WHERE TenKho = N'" + name + "'";
            bool check = false;
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                check = dr.HasRows;
                da.Disconnet();
                return check;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
