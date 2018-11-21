using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using DTO;

namespace UnitTest_QLCamera
{
    /// <summary>
    /// Summary description for UnitTest_KhachHang
    /// </summary>
    [TestClass]
    public class UnitTest_KhachHang
    {
        DAO_KhachHang dao;
        KhachHang KhachHang1;
        KhachHang KhachHang2;
        KhachHang KhachHang3;
        KhachHang KhachHang4;
        KhachHang KhachHang5;
        [TestInitialize]
        public void SetUp()
        {
            dao = new DAO_KhachHang();
            KhachHang1 = new KhachHang
            {
                MaKH = "KH_001",
                HoTenKH = "Khách hàng test 1",
                DiaChi = "BT",
                Sdt = "1",
                Email = "1"

            };
            KhachHang2 = new KhachHang
            {
                MaKH = "KH_002",
                HoTenKH = "Khách hàng test 2",
                DiaChi = "BT",
                Sdt = "1",
                Email = "1"
            };
            KhachHang3 = new KhachHang
            {
                MaKH = "KH_003",
                HoTenKH = "Khách hàng test 3",
                DiaChi = "BT",
                Sdt = "1",
                Email = "1"
            };
            KhachHang4 = new KhachHang
            {
                MaKH = "KH_004",
                HoTenKH = "Khách hàng test 4",
                DiaChi = "BT",
                Sdt = "1",
                Email = "1"
            };
            KhachHang5 = new KhachHang
            {
                MaKH = "KH_005",
                HoTenKH = "Khách hàng test 5",
                DiaChi = "BT",
                Sdt = "1",
                Email = "1"
            };

        }
        [TestMethod]
        public void TestThem()
        {
            dao.ThemKhachHang(KhachHang1);
            dao.ThemKhachHang(KhachHang2);
            dao.ThemKhachHang(KhachHang3);

            var kh1 = dao.GetKhachHangs(KhachHang1.MaKH);
            var kh2 = dao.GetKhachHangs(KhachHang2.MaKH);
            var kh3 = dao.GetKhachHangs(KhachHang3.MaKH);


            Assert.AreEqual(kh1.Count, 1);
            Assert.AreEqual(kh2.Count, 1);
            Assert.AreEqual(kh3.Count, 1);



            Assert.AreEqual(kh1[0].HoTenKH.Trim(), "Khách hàng test 1");
            Assert.AreEqual(kh1[0].MaKH.Trim(), "KH_001");
            Assert.AreEqual(kh1[0].DiaChi.Trim(), "BT");
            Assert.AreEqual(kh1[0].Sdt.Trim(), "1");
            Assert.AreEqual(kh1[0].Email.Trim(), "1");


        }
        [TestMethod]
        public void TestSua()
        {
            var KH1 = dao.GetKhachHangs(KhachHang1.MaKH);
            Assert.AreEqual(KH1.Count, 1);

            KH1[0].HoTenKH = "Tên khách hàng Đã thay đổi";
            KH1[0].MaKH = "KH_0010";
            KH1[0].DiaChi = "BT";

            dao.CapNhatKhachHang(KH1[0]);

            var nv = dao.GetKhachHangs(KhachHang1.MaKH);


            Assert.AreEqual(nv[0].HoTenKH.Trim(), "Tên khách hàng Đã thay đổi");
            Assert.AreEqual(nv[0].MaKH.Trim(), "KH_0010");
            Assert.AreEqual(nv[0].DiaChi, 10000);
        }
        [TestMethod]
        public void TestXoa()
        {
            var kh = dao.GetKhachHangs(KhachHang2.MaKH);


            Assert.AreEqual(kh.Count, 1);


            dao.XoaKhachHang(kh[0].Id);
            kh = dao.GetKhachHangs(KhachHang2.MaKH);

            Assert.AreEqual(kh.Count, 0);

        }

    }
}