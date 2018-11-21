using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_Kho
    {
        DAO_Kho da;
        public BUS_Kho()
        {
            da = new DAO_Kho();
        }

        public List<Kho> GetKhos(string key = "")
        {
            return da.GetKhos(key);
        }

        public Kho GetKho(int id)
        {
            return da.GetKho(id);
        }

        public bool ThemKho(Kho kho)
        {
            return da.ThemKho(kho);
        }

        public bool CapNhatKho(Kho kho)
        {
            return da.CapNhatKho(kho);
        }

        public bool XoaKho(int id)
        {
            return da.XoaKho(id);
        }

        public bool NhapHangVaoKho(int nhanVienId, int khoId, List<ChiTietHoaDonMua> chiTietHoaDonMuas)
        {
            return da.NhapHangVaoKho(nhanVienId, khoId, chiTietHoaDonMuas);
        }

        public bool CheckTonTaiKhoByTen(string name)
        {
            return da.CheckTonTaiKhoByTen(name);
        }
    }
}
