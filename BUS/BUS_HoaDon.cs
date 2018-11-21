using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAO_HoaDon da;
        public BUS_HoaDon()
        {
            da = new DAO_HoaDon();
        }

        public List<HoaDon> GetHoaDons()
        {
            return da.GetHoaDons();
        }

        public HoaDon GetHoaDon(int id)
        {
            return da.GetHoaDon(id);
        }

        public List<ChiTietHoaDon> GetChiTietHoaDon(int id)
        {
            return da.GetChiTietHoaDon(id);
        }
    }
}
