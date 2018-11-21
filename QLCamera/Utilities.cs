using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCamera
{
    public static class Utilities
    {
        public static readonly string PREFIX_MaNCC= "NCC_";
        public static readonly string PREFIX_MaNV = "NV_";
        public static readonly string PREFIX_MASANPHAM = "SP_";
        public static readonly string PREFIX_MAKHO = "KHO_";
        public static readonly string PREFIX_MaKH = "KH_";
        public static readonly int MaNCC_LENGTH = 6;
        public static readonly int MaNV_LENGTH = 6;
        public static readonly int MASP_LENGTH = 6;
        public static readonly int MaKH_LENGTH = 6;

        public static readonly int MAKHO_LENGTH = 6;
        public static int currentUserId = 0;
        public static readonly string ADMIN_LABEL = "Admin";
        public static readonly string STAFF_LABEL = "Staff";
    }


    public class ComboboxItems
    {
        public int Id { get; set; }
        public string Label { get; set; }
    }

    public enum FormMode
    {
        Them = 1,
        Sua = 2
    }

    public enum CapBacNhanVien
    {
        Admin = 1,
        Staff = 2
    }
}
