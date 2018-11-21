using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_SanPham
    {
        DataAdapter da;
        public DAO_SanPham()
        {
            da = new DataAdapter();
        }

        public List<SanPham> GetSanPhams(string key = "")
        {
            string sql = "SELECT Id, MaSP, TenSP, NamBaoHanh, ThangBaoHanh, Gia, HienCo FROM SanPham";
            if (!string.IsNullOrEmpty(key))
            {
                sql += " WHERE MaSp LIKE '%" + key + "%' OR TenSP LIKE '%" + key + "%'";
            }
            List<SanPham> sanPhams = new List<SanPham>();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    int nam = (int)dr[3];
                    int thang = (int)dr[4];
                    sanPhams.Add(new SanPham
                    {
                        Id = (int)dr[0],
                        MaSp = dr[1].ToString(),
                        TenSp = dr[2].ToString(),
                        NamBaoHanh = nam,
                        ThangBaoHanh = thang,
                        Gia = double.Parse(dr[5].ToString()),
                        BaoHanhString = nam == 0 && thang == 0 ?  "Không bảo hành" : ( nam != 0 ? nam + " năm" : "") +  (thang != 0 ? " " + thang + " tháng" :  ""),
                        HienCo = int.Parse(dr[6].ToString()),
                    });
                }
                da.Disconnet();
                return sanPhams;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<SanPham>() ;
            }
        }

        public bool CheckTonTaiSanPhamByTen(string name)
        {
            string sql = "SELECT Id FROM SanPham WHERE TenSP = N'" + name + "'";
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
        public SanPham GetSanPham(int id)
        {
            string sql = "SELECT Id, MaSP, TenSP, NamBaoHanh, ThangBaoHanh, Gia, HienCo FROM SanPham WHERE Id = " + id;
            SanPham sanPham = new SanPham();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    sanPham = new SanPham
                    {
                        Id = (int)dr[0],
                        MaSp = dr[1].ToString(),
                        TenSp = dr[2].ToString(),
                        NamBaoHanh = (int)dr[3],
                        ThangBaoHanh = (int)dr[4],
                        Gia = double.Parse(dr[5].ToString()),
                        HienCo = int.Parse(dr[6].ToString()),
                    };
                }
                da.Disconnet();
                return sanPham;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new SanPham();
            }
        }

        public bool ThemSanPham(SanPham sp)
        {
            string sql = @"INSERT INTO SanPham VALUES(N'" + sp.MaSp + "', N'" + sp.TenSp + "', " + sp.NamBaoHanh + ", " + sp.ThangBaoHanh + ", " + sp.Gia + ", 0)";
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

        public bool CapNhatSanPham(SanPham sp)
        {
            string sql = @"UPDATE SanPham SET MaSp = N'" + sp.MaSp + "', TenSp = N'" + sp.TenSp + "', NamBaoHanh = " + sp.NamBaoHanh + ", ThangBaoHanh = " + sp.ThangBaoHanh + ", Gia = " + sp.Gia + " WHERE Id = " + sp.Id;
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

        public bool XoaSanPham(int id)
        {
            string sql = @"DELETE SanPham WHERE Id = " + id;
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

        public int KiemTraSoLuongHangHienCo(int id)
        {
            string sql = @"SELECT HienCo FROM SanPham WHERE Id = " + id;
            try
            {
                var result = 0;
                da.Connect();
                result = int.Parse(da.ExecuteScalar(sql).ToString());
                da.Disconnet();
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public bool CapNhatSoLuong(int id, int soLuong)
        {
            string sql = @"Update SanPham SET HienCo = " + soLuong + "  WHERE Id = " + id;
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
