using DAO;
using DTO;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAO_TaiKhoan da;
        public BUS_TaiKhoan()
        {
            da = new DAO_TaiKhoan();
        }
        public bool CheckLogIn(string username, string password)
        {
            return da.CheckLogIn(username, password);
        }

        public bool TaoTaiKhoan(TaiKhoan tk)
        {
            return da.TaoTaiKhoan(tk);
        }

        public bool DoiMatKhau(string password, int id)
        {
            return da.DoiMatKhau(password, id);
        }

        public TaiKhoan GetTaiKhoanNhanVienHienTai(int id)
        {
            return da.GetTaiKhoanNhanVienHienTai(id);
        }

        public int GetUserId(string username, string password)
        {
            return da.GetUserId(username, password);
        }

    }
}
