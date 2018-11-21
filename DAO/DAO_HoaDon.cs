using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_HoaDon
    {
        DataAdapter da;
        public DAO_HoaDon()
        {
            da = new DataAdapter();
        }

        public List<HoaDon> GetHoaDons()
        {
            string sql = "SELECT H.Id, H.NhanVienId, H.KhachHangId, H.ThoiGian, H.TongTien, N.HoTenNV, " +
                " K.HoTenKH" +
                " FROM HoaDon H INNER JOIN NhanVien N ON H.NhanVienId = N.Id" +
                " INNER JOIN KhachHang K ON H.KhachHangId = K.Id";

            List<HoaDon> khos = new List<HoaDon>();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {

                    var Id = (int)dr[0];
                    var NhanVienId = (int)dr[1];
                    var KhachHangId = (int)dr[2];
                    var ThoiGian = (DateTime)dr[3];
                    var TongTien = (decimal)dr[4];
                    var NhanVienName = dr[5].ToString();
                    var KhachHangName = dr[6].ToString();
                    khos.Add(new HoaDon
                    {
                        Id = Id,
                        NhanVienId = NhanVienId,
                        KhachHangId = KhachHangId,
                        ThoiGian = ThoiGian,
                        TongTien = TongTien,
                        NhanVienName = NhanVienName,
                        KhachHangName = KhachHangName,

                    });
                }
                da.Disconnet();
                return khos;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<HoaDon>();
            }
        }

        public HoaDon GetHoaDon(int id)
        {
            string sql = "SELECT H.Id, H.NhanVienId, H.KhachHangId, H.ThoiGian, H.TongTien, N.HoTenNV, " +
                " K.HoTenKH" +
                " FROM HoaDon H INNER JOIN NhanVien N ON H.NhanVienId = N.Id" +
                " INNER JOIN KhachHang K ON H.KhachHangId = K.Id WHERE Id = " + id;
            HoaDon hoaDon = new HoaDon();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    hoaDon = new HoaDon
                    {
                        Id = (int)dr[0],
                        NhanVienId = (int)dr[1],
                        KhachHangId = (int)dr[2],
                        ThoiGian = (DateTime)dr[3],
                        TongTien = (decimal)dr[4],
                        NhanVienName = dr[5].ToString(),
                        KhachHangName = dr[6].ToString()
                    };
                }
                da.Disconnet();
                return hoaDon;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new HoaDon();
            }
        }


        public List<ChiTietHoaDon> GetChiTietHoaDon(int id)
        {
            string sql = "SELECT H.Id, H.HoaDonId, H.SanPhamId, H.SoLuong, S.TenSP " +
                "FROM ChiTietHoaDon H INNER JOIN SanPham S ON H.SanPhamId = S.Id " +
                "WHERE HoaDonId = " + id;

            List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
            try
            {
                da.Connect();
                var dr = da.ExecuteReader(sql);
                while (dr.Read())
                {
                    chiTietHoaDons.Add(new ChiTietHoaDon
                    {
                        Id = (int)dr[0],
                        HoaDonId = (int)dr[1],
                        SanPhamId = (int)dr[2],
                        SoLuong = (int)dr[3],
                        TenSanPham = dr[4].ToString()
                    });
                }
                da.Disconnet();
                return chiTietHoaDons;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<ChiTietHoaDon>();
            }
        }
    }
}
