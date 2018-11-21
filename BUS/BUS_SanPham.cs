using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_SanPham
    {
        DAO_SanPham da;
        public BUS_SanPham()
        {
            da = new DAO_SanPham();
        }
        public List<SanPham> GetSanPhams(string key = "")
        {
            return da.GetSanPhams(key);
        }

        public SanPham GetSanPham(int id)
        {
            return da.GetSanPham(id);
        }

        public bool ThemSanPham(SanPham ncc)
        {
            return da.ThemSanPham(ncc);
        }

        public bool CapNhatSanPham(SanPham ncc)
        {
            return da.CapNhatSanPham(ncc);
        }

        public bool XoaSanPham(int id)
        {
            return da.XoaSanPham(id);
        }


        public bool CheckTonTaiSanPhamByTen(string name)
        {
            return da.CheckTonTaiSanPhamByTen(name);
        }

        public int KiemTraSoLuongHangHienCo(int id)
        {
            return da.KiemTraSoLuongHangHienCo(id);
        }
        
        public bool CapNhatSoLuong(int id, int soLuong)
        {
            return da.CapNhatSoLuong(id, soLuong);
        }

        public bool ThemBaoHanh(ThongTinBaoHanh baoHanh)
        {
            return da.ThemBaoHanh(baoHanh);
        }

        public int GetLanBaoHanh(int hoaDonId, int sanPhamId)
        {
            return da.GetLanBaoHanh(hoaDonId, sanPhamId);
        }
    }
}
