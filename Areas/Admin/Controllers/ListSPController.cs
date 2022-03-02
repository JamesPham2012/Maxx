using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanHang.Models;
using WebSiteBanHang.Models.ViewMD;

namespace WebSiteBanHang.Areas.Admin.Controllers
   
{
    public class ListSPController : Controller
    {
        private QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        // GET: Admin/ListSP
        public ActionResult Index()
        {
            ListSanPhamAD_MD listSP = new ListSanPhamAD_MD();
            IEnumerable<ListSanPhamAD_MD> ListSP = (from objSp in db.SanPhams
                                                    join objLoai in db.LoaiSanPhams
                                                    on objSp.MaLoaiSP equals objLoai.MaLoaiSP
                                                    select new ListSanPhamAD_MD()
                                                    {
                                                        MaSP = objSp.MaSP,
                                                        TenSP = objSp.TenSP,
                                                        DonGia = objSp.DonGia,
                                                        MoTa = objSp.MoTa,
                                                        HinhAnh = objSp.HinhAnh,
                                                        TenLoai = objLoai.TenLoai,
                                                    }).ToList();

            return View(ListSP);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Debug.WriteLine(db);
            SanPham sanPhamCanXoa = db.SanPhams.SingleOrDefault(n => n.MaSP==id);
            Debug.WriteLine("sp "+ sanPhamCanXoa.MaSP);
            db.SanPhams.Remove(sanPhamCanXoa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}