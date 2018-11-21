using System;
using DAO;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_QLCamera
{
    [TestClass]
    public class UnitTest_SanPham
    {
        DAO_SanPham dao;
        SanPham SanPham1;
        SanPham SanPham2;
        SanPham SanPham3;
        SanPham SanPham4;
        SanPham SanPham5;

        [TestInitialize]
        public void SetUp()
        {
            dao = new DAO_SanPham();
            SanPham1 = new SanPham
            {
                MaSp = "SPT_001",
                TenSp = "Sản phẩm test 1",
                Gia = 10000,
                NamBaoHanh = 1,
                ThangBaoHanh = 6
            };
            SanPham2 = new SanPham
            {
                MaSp = "SPT_002",
                TenSp = "Sản phẩm test 2",
                Gia = 10000,
                NamBaoHanh = 1,
                ThangBaoHanh = 6
            };
            SanPham3 = new SanPham
            {
                MaSp = "SPT_003",
                TenSp = "Sản phẩm test 3",
                Gia = 10000,
                NamBaoHanh = 1,
                ThangBaoHanh = 6
            };
            SanPham4 = new SanPham
            {
                MaSp = "SPT_004",
                TenSp = "Sản phẩm test 4",
                Gia = 10000,
                NamBaoHanh = 1,
                ThangBaoHanh = 6
            };
            SanPham5 = new SanPham
            {
                MaSp = "SPT_005",
                TenSp = "Sản phẩm test 5",
                Gia = 10000,
                NamBaoHanh = 1,
                ThangBaoHanh = 6
            };
        }

        [TestMethod]
        public void TestThem()
        {
            dao.ThemSanPham(SanPham1);
            dao.ThemSanPham(SanPham2);
            dao.ThemSanPham(SanPham3);

            var sp1 = dao.GetSanPhams(SanPham1.MaSp);
            var sp2 = dao.GetSanPhams(SanPham2.MaSp);
            var sp3 = dao.GetSanPhams(SanPham3.MaSp);

            Assert.AreEqual(sp1.Count, 1);
            Assert.AreEqual(sp2.Count, 1);
            Assert.AreEqual(sp3.Count, 1);


            Assert.AreEqual(sp1[0].TenSp.Trim(), "Sản phẩm test 1");
            Assert.AreEqual(sp1[0].MaSp.Trim(), "SPT_001");
            Assert.AreEqual(sp1[0].Gia, 10000);
            Assert.AreEqual(sp1[0].NamBaoHanh, 1);
            Assert.AreEqual(sp1[0].ThangBaoHanh, 6);
        }


        [TestMethod]
        public void TestSua()
        {
            var sp1 = dao.GetSanPhams(SanPham1.MaSp);
            Assert.AreEqual(sp1.Count, 1);

            sp1[0].TenSp = "TenSp Đã thay đổi";
            sp1[0].MaSp = "SPT_001_01";
            sp1[0].Gia = 15000;

            dao.CapNhatSanPham(sp1[0]);
           
            var sp = dao.GetSanPhams(SanPham1.MaSp);


            Assert.AreEqual(sp[0].TenSp.Trim(), "TenSp Đã thay đổi");
            Assert.AreEqual(sp[0].MaSp.Trim(), "SPT_001_01");
            Assert.AreEqual(sp[0].Gia, 15000);
        }

 
        [TestMethod]
        public void TestXoa()
        {
            var sp = dao.GetSanPhams(SanPham3.MaSp);


            Assert.AreEqual(sp.Count, 1);


            dao.XoaSanPham(sp[0].Id);
            sp = dao.GetSanPhams(SanPham3.MaSp);

            Assert.AreEqual(sp.Count, 0);

        }
    }
}
