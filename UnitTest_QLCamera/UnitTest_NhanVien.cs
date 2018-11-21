using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using DTO;
namespace UnitTest_QLCamera
{
    
    [TestClass]
   
        public class UnitTest_NhanVien
        {
            DAO_NhanVien dao;
            NhanVien NhanVien1;
            NhanVien NhanVien2;
            NhanVien NhanVien3;
            NhanVien NhanVien4;
            NhanVien NhanVien5;
        
        [TestInitialize]
        public void SetUp()
        {
            dao = new DAO_NhanVien();
            NhanVien1 = new NhanVien
            {
                MaNV = "NV_001",
                HoTenNV = "Nhân viên test 1",
                DiaChi = "BT",
                Sdt = "1",
                Email = "1",
                Cmnd = "1",
                Luong = 1000,
                CapBac = 1,
                TenCapBac = "Admin"
            };
            NhanVien2 = new NhanVien
            {
                MaNV = "NV_001",
                HoTenNV = "Nhân viên test 1",
                DiaChi = "BT",
                Sdt = "1",
                Email = "1",
                Cmnd = "1",
                Luong = 1000,
                CapBac = 1,
                TenCapBac = "Admin"
            };
            NhanVien3 = new NhanVien
            {
                MaNV = "NV_001",
                HoTenNV = "Nhân viên test 1",
                DiaChi = "BT",
                Sdt = "1",
                Email = "1",
                Cmnd = "1",
                Luong = 1000,
                CapBac = 1,
                TenCapBac = "Admin"
            };
            NhanVien4 = new NhanVien
            {
                MaNV = "NV_001",
                HoTenNV = "Nhân viên test 1",
                DiaChi = "BT",
                Sdt = "1",
                Email = "1",
                Cmnd = "1",
                Luong = 1000,
                CapBac = 1,
                TenCapBac = "Admin"
            };
            NhanVien5 = new NhanVien
            {
                MaNV = "NV_001",
                HoTenNV = "Nhân viên test 1",
                DiaChi = "BT",
                Sdt = "1",
                Email = "1",
                Cmnd = "1",
                Luong = 1000,
                CapBac = 1,
                TenCapBac = "Admin"
            };
        }
        [TestMethod]
        public void TestThem()
        {
            dao.ThemNhanVien(NhanVien1);
            dao.ThemNhanVien(NhanVien2);
            dao.ThemNhanVien(NhanVien3);

            var nv1 = dao.GetNhanViens(NhanVien1.MaNV);
            var nv2 = dao.GetNhanViens(NhanVien2.MaNV);
            var nv3 = dao.GetNhanViens(NhanVien3.MaNV);

            Assert.AreEqual(nv1.Count, 1);
            Assert.AreEqual(nv2.Count, 1);
            Assert.AreEqual(nv3.Count, 1);



            Assert.AreEqual(nv1[0].HoTenNV.Trim(), "Nhân viên test 1");
            Assert.AreEqual(nv1[0].MaNV.Trim(), "NV_001");
            Assert.AreEqual(nv1[0].DiaChi, "BT");
            Assert.AreEqual(nv1[0].Sdt, "1");
            Assert.AreEqual(nv1[0].Email, "1");
            Assert.AreEqual(nv1[0].Cmnd, "1");
            Assert.AreEqual(nv1[0].Luong, 1000);
            Assert.AreEqual(nv1[0].CapBac, 1);
            Assert.AreEqual(nv1[0].TenCapBac, "Admin");

        }
        [TestMethod]
        public void TestSua()
        {
            var NV1 = dao.GetNhanViens(NhanVien1.MaNV);
            Assert.AreEqual(NV1.Count, 1);

            NV1[0].HoTenNV = "TenNV Đã thay đổi";
            NV1[0].MaNV = "NV_0010";
            NV1[0].DiaChi = "BT";

            dao.CapNhatNhanVien(NV1[0]);

            var nv = dao.GetNhanViens(NhanVien1.MaNV);


            Assert.AreEqual(nv[0].HoTenNV.Trim(), "TenNV Đã thay đổi");
            Assert.AreEqual(nv[0].MaNV.Trim(), "NV_0010");
            Assert.AreEqual(nv[0].DiaChi, 10000);
        }
        [TestMethod]
        public void TestXoa()
        {
            var nv = dao.GetNhanViens(NhanVien2.MaNV);


            Assert.AreEqual(nv.Count, 1);


            dao.XoaNhanVien(nv[0].Id);
            nv = dao.GetNhanViens(NhanVien2.MaNV);

            Assert.AreEqual(nv.Count, 0);

        }
       
    }
}
