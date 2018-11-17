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
            string sql = "SELECT Id, MaSP, TenSP, BaoHanh, Gia FROM SanPham";
            if (string.IsNullOrEmpty(key))
            {
                sql += " WHERE MaSp LIKE " + key + " OR TenSP LIKE " + key;
            }
            List<SanPham> sanPhams = new List<SanPham>();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    DateTimeOffset? baoHanh;
                    if (dr[3] == null)
                        baoHanh = null;
                    else
                        baoHanh = (DateTimeOffset)dr[3];
                    sanPhams.Add(new SanPham
                    {
                        Id = (int)dr[0],
                        MaSp = dr[1].ToString(),
                        TenSp = dr[2].ToString(),
                        BaoHanh = baoHanh,
                        Gia = double.Parse(dr[4].ToString())
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

        public SanPham GetSanPham(int id)
        {
            string sql = "SELECT Id, MaSP, TenSP, BaoHanh, Gia FROM SanPham WHERE Id = " + id;
            SanPham sanPham = new SanPham();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    DateTimeOffset? baoHanh;
                    if (dr[3] == null)
                        baoHanh = null;
                    else
                        baoHanh = (DateTimeOffset)dr[3];
                    sanPham = new SanPham
                    {
                        Id = (int)dr[0],
                        MaSp = dr[1].ToString(),
                        TenSp = dr[2].ToString(),
                        BaoHanh = baoHanh,
                        Gia = double.Parse(dr[4].ToString())
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
            string sql = @"INSERT INTO SanPham VALUES(N'" + sp.MaSp + "', N'" + sp.TenSp + "', " + sp.BaoHanh + ", Gia = " + sp.Gia + ")";
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

        public bool CapNhatSanPham(SanPham sp)
        {
            string sql = @"UPDATE SanPham SET MaSp = N'" + sp.MaSp + "', TenSp = N'" + sp.TenSp + "', BaoHanh = " + sp.BaoHanh + ", Gia = " + sp.Gia + " WHERE Id = " + sp.Id;
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
    }
}
