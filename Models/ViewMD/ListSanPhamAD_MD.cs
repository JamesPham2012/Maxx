using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteBanHang.Models.ViewMD
{
    public class ListSanPhamAD_MD
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        public string TenLoai { get; set; }
    }
}