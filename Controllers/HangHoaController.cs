using Microsoft.AspNetCore.Mvc;
using NiceNiceShop.Data;
using Microsoft.EntityFrameworkCore;
using NiceNiceShop.ViewModels;


namespace NiceNiceShop.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly NiceNiceShopContext db;

        public HangHoaController(NiceNiceShopContext conetxt)
        {
            db = conetxt;
        }
        public IActionResult Index(int? loai )
        {
            var hangHoas = db.HangHoas.AsQueryable();

            if (loai.HasValue)
            {
                hangHoas = hangHoas.Where(p => p.MaLoaiSp == loai.Value);
            }
            var result = hangHoas.Select(p => new HangHoaVM
            {
                MaHh = p.MaHh,
                TenHH = p.TenHh,
                DonGia = p.DonGia ?? 0,
                Hinh = p.Hinh ?? "",
                MoTaNgan = p.MoTa ?? "",
                TenLoai = p.MaLoaiSpNavigation.TenLoaiSp
            });

            return View(result);
        }

        public IActionResult Search(String? query)
        {
            var hangHoas = db.HangHoas.AsQueryable();

            if (query!= null)
            {
                hangHoas = hangHoas.Where(p => p.TenHh.Contains(query));
            }
            var result = hangHoas.Select(p => new HangHoaVM
            {
                MaHh = p.MaHh,
                TenHH = p.TenHh,
                DonGia = p.DonGia ?? 0,
                Hinh = p.Hinh ?? "",
                MoTaNgan = p.MoTa ?? "",
                TenLoai = p.MaLoaiSpNavigation.TenLoaiSp
            });

            return View(result);
        }
    }
}
