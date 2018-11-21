using System;

namespace DTO
{
    public class SanPham
    {
        public int Id { get; set; }
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public int NamBaoHanh { get; set; }
        public int ThangBaoHanh { get; set; }
        public string BaoHanhString { get; set; }
        public double Gia { get; set; }
        public int HienCo { get; set; }
    }
}
