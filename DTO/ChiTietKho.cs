using System;

namespace DTO
{
    public class ChiTietKho
    {
        public int Id { get; set; }
        public int HangHoaId { get; set; }
        public int KhoId { get; set; }
        public DateTime ThoiGianNhapKho { get; set; }
        public int SoLuong { get; set; }
        public int UserIdNhap { get; set; }
    }
}
