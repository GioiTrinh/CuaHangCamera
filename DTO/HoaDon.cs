using System;

namespace DTO
{
    public class HoaDon
    {
        public int Id { get; set; }
        public int NhanVienId { get; set; }
        public string NhanVienName { get; set; }
        public int KhachHangId { get; set; }
        public string KhachHangName { get; set; }
        public DateTime ThoiGian { get; set; }
        public decimal? TongTien { get; set; }
    }
}
