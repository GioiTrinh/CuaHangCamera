using System;

namespace DTO
{
    public class HoaDonMua
    {
        public int Id { get; set; }
        public int NhanVienId { get; set; }
        public int NhaCungCapId { get; set; }
        public DateTime ThoiGian { get; set; }
        public double? TongTien { get; set; }
    }
}
