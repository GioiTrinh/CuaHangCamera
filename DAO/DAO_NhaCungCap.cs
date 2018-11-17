using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<NhaCungCap> GetNhaCungCaps(string key = "")
        {
            string sql = "SELECT Id, MaNCC, TenNCC, DiaChi, Sdt, Email, Website FROM NhaCungCap";
            if (!string.IsNullOrEmpty(key))
            {
                sql += " WHERE MaNCC LIKE + N'%" + key + "%' OR "
                    + "DiaChi LIKE + N'%" + key + "%' OR "
                    + "Sdt LIKE + N'%" + key + "%' OR " 
                    + "Email LIKE + N'%" + key + "%' OR " 
                    + "Website LIKE + N'%" + key + "%'";
            }
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
            string sql = @"UPDATE NhaCungCap SET MaNCC = N'" + ncc.MaNCC + "', TenNCC = N'" + ncc.TenNCC + "', DiaChi = N'" + ncc.DiaChi + "', Sdt = N'" + ncc.Sdt + "', Email = N'" + ncc.Email + "', Website = N'" + ncc.Website + "' WHERE Id = " + ncc.Id;
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

        public bool NhapHangTuNhaCungCap(int nhanVienId, int nccId, List<ChiTietHoaDonMua> chiTietHoaDonMuas)
        {
            if (chiTietHoaDonMuas.Any())
            {
                string sql = @"INSERT INTO HoaDonMua VALUES (" + nhanVienId + ", " + nccId + DateTime.Now + ", " + null + ")";
                try
                {
                    var result = false;
                    da.Connect();
                    result = da.ExecuteNonQuery(sql) > 0;
                    if (result)
                    {
                        var sqlGetId = "SELECT TOP 1 Id FROM HoaDonMua ORDER BY DESC";
                        var val = da.ExecuteScalar(sqlGetId).ToString();
                        int chiTietHoaDonMuaId;
                        if (int.TryParse(val, out chiTietHoaDonMuaId)) {
                            double tongTien = 0;
                            foreach (var chiTietHoaDonMua in chiTietHoaDonMuas)
                            {
                                sql = @"INSERT INTO ChiTietHoaDonMua VALUES (" + chiTietHoaDonMuaId + ", " + chiTietHoaDonMua.SanPhamId + ", " + chiTietHoaDonMua.SoLuong + ")";
                                result = da.ExecuteNonQuery(sql) > 0;
                                sql = @"SELECT Gia FROM SanPham WHERE Id = " + chiTietHoaDonMua.SanPhamId;
                                double gia = double.Parse(da.ExecuteScalar(sql).ToString());
                                tongTien += gia * chiTietHoaDonMua.SoLuong;
                            }

                            sql = @"UPDATE HoaDonMua SET TongTien = " + tongTien + " WHERE Id = " + chiTietHoaDonMuaId;
                            result = da.ExecuteNonQuery(sql) > 0;
                        }
                    }

                    da.Disconnet();
                    return result;
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
