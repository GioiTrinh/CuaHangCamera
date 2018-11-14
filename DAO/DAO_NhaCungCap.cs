using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_NhaCungCap
    {
        DataAdapter da;
        public DAO_NhaCungCap()
        {
            da = new DataAdapter();
        }

        public List<NhaCungCap> GetNhaCungCaps()
        {
            string sql = "SELECT Id, MaNCC, TenNCC, DiaChi, Sdt, Email, Website FROM NhaCungCap";
            List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    nhaCungCaps.Add(new NhaCungCap
                    {
                        Id = (int)dr[0],
                        MaNCC = dr[1].ToString(),
                        TenNCC = dr[2].ToString(),
                        DiaChi = dr[3].ToString(),
                        Sdt = dr[4].ToString(),
                        Email = dr[5].ToString(),
                        Website = dr[6].ToString()
                    });
                }
                da.Disconnet();
                return nhaCungCaps;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<NhaCungCap>() ;
            }
        }

        public NhaCungCap GetNhaCungCap(int id)
        {
            string sql = "SELECT Id, MaNCC, TenNCC, DiaChi, Sdt, Email, Website FROM NhaCungCap WHERE Id = " + id;
            NhaCungCap nhaCungCap = new NhaCungCap();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    nhaCungCap = new NhaCungCap
                    {
                        Id = (int)dr[0],
                        MaNCC = dr[1].ToString(),
                        TenNCC = dr[2].ToString(),
                        DiaChi = dr[3].ToString(),
                        Sdt = dr[4].ToString(),
                        Email = dr[5].ToString(),
                        Website = dr[6].ToString()
                    };
                }
                da.Disconnet();
                return nhaCungCap;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new NhaCungCap();
            }
        }

        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            string sql = @"INSERT INTO NhaCungCap VALUES(N'" + ncc.MaNCC + "', N'" + ncc.TenNCC + "', N'" + ncc.DiaChi +  "', N'" + ncc.Sdt + "', N'" + ncc.Email + "', N'" + ncc.Website + "')";
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

        public bool CapNhatNhaCungCap(NhaCungCap ncc)
        {
            string sql = @"UPDATE NhaCungCap SET MaNCC = N'" + ncc.MaNCC + "', TenNCC = N'" + ncc.TenNCC + "', DiaChi = N'" + ncc.DiaChi + "', Sdt = N'" + ncc.Sdt + "', Email = N'" + ncc.Email + "', Website = N'" + ncc.Website + "'";
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

        public bool XoaNhaCungCap(int id)
        {
            string sql = @"DELETE NhaCungCap WHERE Id = " + id;
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
