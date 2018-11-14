using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_NhaCungCap
    {
        DAO_NhaCungCap da;
        public BUS_NhaCungCap()
        {
            da = new DAO_NhaCungCap();
        }
        public List<NhaCungCap> GetNhaCungCaps()
        {
            return da.GetNhaCungCaps();
        }

        public NhaCungCap GetNhaCungCap(int id)
        {
            return da.GetNhaCungCap(id);
        }

        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            return da.ThemNhaCungCap(ncc);
        }

        public bool CapNhatNhaCungCap(NhaCungCap ncc)
        {
            return da.CapNhatNhaCungCap(ncc);
        }

        public bool XoaNhaCungCap(int id)
        {
            return da.XoaNhaCungCap(id);
        }
    }
}
