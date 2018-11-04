using System;

namespace DTO
{
    public class HoaDon
    {
        public int Id { get; set; }
        public int NhanVienId { get; set; }
        public int KhachHangId { get; set; }
        public DateTime ThoiGian { get; set; }
        public int? TongTien { get; set; }
    }
}
