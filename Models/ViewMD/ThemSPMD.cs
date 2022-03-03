using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteBanHang.Models.ViewMD
{
    public class ThemSPMD
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public string CauHinh { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
        public Nullable<int> LuotXem { get; set; }
        public Nullable<int> LuotBinhChon { get; set; }
        public Nullable<int> LuotBinhLuan { get; set; }
        public Nullable<int> SoLanMua { get; set; }
        public Nullable<int> Moi { get; set; }
        public Nullable<int> MaNCC { get; set; }
        public Nullable<int> MaNSX { get; set; }
        public Nullable<int> MaLoaiSP { get; set; }
        public Nullable<bool> DaXoa { get; set; }


        public IEnumerable<SelectListItem> AddLoai { get; set; }


    }
}