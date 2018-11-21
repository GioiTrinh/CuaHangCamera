using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;


namespace BUS
{
    public class BUS_KhachHang
    {
        DAO_KhachHang da;
        public BUS_KhachHang()
        {
            da = new DAO_KhachHang();
        }
        public List<KhachHang> GetKhachHangs(string key = "")
        {
            return da.GetKhachHangs(key);
        }

        public KhachHang GetKhachHang(int id)
        {
            return da.GetKhachHang(id);
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            return da.ThemKhachHang(kh);
        }

        public bool CapNhatKhachHang(KhachHang kh)
        {
            return da.CapNhatKhachHang(kh);
        }

        public bool XoaKhachHang(int id)
        {
            return da.XoaKhachHang(id);
        }


        public bool BanHang(int nhanVienId, int khachHangId, List<ChiTietHoaDon> chiTietHoaDons)
        {
            return da.BanHang(nhanVienId, khachHangId, chiTietHoaDons);
        }
    }
}
