using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThongTinBaoHanh
    {
        public int Id { get; set; }
        public int HoaDonId { get; set; } = -1;
        public int SanPhamId { get; set; }
        public int NhanVienId { get; set; }
        public DateTime ThoiGian { get; set; }
        public int LanThu { get; set; }
    }
}
