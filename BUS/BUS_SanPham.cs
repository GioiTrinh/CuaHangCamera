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
    }
}
