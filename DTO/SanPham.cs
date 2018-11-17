using System;

namespace DTO
{
    public class SanPham
    {
        public int Id { get; set; }
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public DateTimeOffset? BaoHanh { get; set; }
        public double Gia { get; set; }
    }
}
