using NiceNiceShop.Data;
using Microsoft.AspNetCore.Mvc;
using NiceNiceShop.ViewModels;

namespace NiceNiceShop.ViewComponents
{
    public class MenuloaiViewComponent :  ViewComponent
    {
        private readonly NiceNiceShopContext db;

        public MenuloaiViewComponent(NiceNiceShopContext context) => db = context;

        public IViewComponentResult Invoke()
        {
            var data = db.LoaiSps.Select(lo => new MenuLoaiVM
            {
                MaLoaiSp = lo.MaLoaiSp,
                TenLoaiSp = lo.TenLoaiSp,
                SoLuong = lo.HangHoas.Count
            }).OrderBy(p => p.TenLoaiSp);

            return View("Default",data);
        }
    }
}
