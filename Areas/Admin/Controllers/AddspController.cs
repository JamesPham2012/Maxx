using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanHang.Models.ViewMD;
using WebSiteBanHang.Models;
using System.IO;

namespace WebSiteBanHang.Areas.Admin.Controllers
{
    public class AddspController : Controller
    {
        private QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        // GET: Admin/Addsp
        public ActionResult Index()
        {
            ThemSPMD dbmd = new ThemSPMD();
            dbmd.AddLoai = (from objaddloai in db.LoaiSanPhams
                            select new SelectListItem()
                            {
                                Text = objaddloai.TenLoai,
                                Value = objaddloai.MaLoaiSP.ToString(),
                                Selected = true,
                            });


            return View(dbmd);
        }
        [HttpPost]
        public JsonResult Index(ThemSPMD themmd)
        {
           
            SanPham sp = new SanPham();
         
            sp.MaSP = themmd.MaSP;
            sp.TenSP = themmd.TenSP;
            sp.HinhAnh = themmd.HinhAnh;
            sp.DonGia = themmd.DonGia;
            sp.NgayCapNhat = themmd.NgayCapNhat;
            sp.CauHinh = themmd.CauHinh;
            sp.MoTa = themmd.MoTa;
            sp.SoLuongTon = themmd.SoLuongTon;
            sp.LuotXem = themmd.LuotXem;
            sp.LuotBinhChon = themmd.LuotBinhChon;
            sp.LuotBinhLuan = themmd.LuotBinhLuan;
            sp.SoLanMua = themmd.SoLanMua;
            sp.Moi = themmd.Moi;
            sp.MaNCC = themmd.MaNCC;
            sp.MaNSX = themmd.MaNSX;
            sp.MaLoaiSP = themmd.MaLoaiSP;
            sp.DaXoa = themmd.DaXoa;
           
         
            db.SanPhams.Add(sp);
            db.SaveChanges();
            return Json(new { Success = true, Message = "Add Success" }, JsonRequestBehavior.AllowGet);
        }
    }
}