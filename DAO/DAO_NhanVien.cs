using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;


namespace DAO
{
    public class DAO_NhanVien
    {
        DataAdapter da;
        public DAO_NhanVien()
        {
            da = new DataAdapter();
        }
        public List<NhanVien> GetNhanViens(string key = "")
        {
            string sql = "SELECT Id, MaNV, HoTenNV, Sdt, Email, DiaChi,Cmnd,Luong,CapBac  FROM NhanVien";
            if (!string.IsNullOrEmpty(key))
            {
                sql += " WHERE MaNV LIKE '%" + key + "%' " +
                    "OR HoTenNV LIKE '%" + key + "%'" +
                    "OR DiaChi LIKE '%" + key + "%'" +
                    "OR Email LIKE '%" + key + "%'" +
                    "OR Cmnd LIKE '%" + key + "%'" +
                    "OR Sdt LIKE '%" + key + "%'";
            }
            List<NhanVien> NhanViens = new List<NhanVien>();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {

                    NhanViens.Add(new NhanVien
                    {
                        Id = (int)dr[0],
                        MaNV = dr[1].ToString(),
                        HoTenNV = dr[2].ToString(),
                        DiaChi = dr[3].ToString(),
                        Sdt = dr[4].ToString(),
                        Email = dr[5].ToString(),
                        Cmnd = dr[6].ToString(),
                        Luong = double.Parse(dr[7].ToString()),
                        CapBac = int.Parse(dr[8].ToString())
                    });
                }
                da.Disconnet();
                return NhanViens;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<NhanVien>();
            }
        }


        public NhanVien GetNhanVien(int id)
        {
            string sql = "SELECT Id, MaNV, HoTenNV, DiaChi, Sdt, Email, Cmnd, Luong, CapBac FROM NhanVien Where id = " + id;

            NhanVien nhanVien = new NhanVien();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    nhanVien = new NhanVien
                    {
                        Id = (int)dr[0],
                        MaNV = dr[1].ToString(),
                        HoTenNV = dr[2].ToString(),
                        DiaChi = dr[3].ToString(),
                        Sdt = dr[4].ToString(),
                        Email = dr[5].ToString(),
                        Cmnd = dr[6].ToString(),
                        Luong = double.Parse(dr[7].ToString()),
                        CapBac = int.Parse(dr[8].ToString())
                    };
                }
                da.Disconnet();
                return nhanVien;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return nhanVien;
            }
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            string sql = @"INSERT INTO NhanVien VALUES(N'" + nv.MaNV + "', N'" + nv.HoTenNV + "', N'" + nv.DiaChi + "', N'" + nv.Sdt + "', N'" + nv.Email + "', '" + nv.Cmnd + "', " + nv.CapBac + ", " + nv.Luong + ")";
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
        public bool CapNhatNhanVien(NhanVien nv)
        {
            string sql = @"UPDATE NhanVien SET MaNV = N'" + nv.MaNV + "', N'" + nv.MaNV + "', " + "', " + nv.Sdt + "', " + nv.Email + "', " + nv.Cmnd + " WHERE Id = " + nv.Id;
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
        public bool XoaNhanVien(int id)
        {
            string sql = @"DELETE NhanVien WHERE Id = " + id;
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
