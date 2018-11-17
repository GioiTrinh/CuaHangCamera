using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAO_NhanVien da;
        public BUS_NhanVien()
        {
            da = new DAO_NhanVien();
        }
        public List<NhanVien> GetNhanViens(string key = "")
        {
            return da.GetNhanViens(key);
        }

        public NhanVien GetNhanVien(int id)
        {
            return da.GetNhanVien(id);
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            return da.ThemNhanVien(nv);
        }

        public bool CapNhatNhanVien(NhanVien nv)
        {
            return da.CapNhatNhanVien(nv);
        }

        public bool XoaNhanVien(int id)
        {
            return da.XoaNhanVien(id);
        }
    }
}
