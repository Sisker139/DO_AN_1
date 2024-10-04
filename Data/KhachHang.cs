using System;
using System.Collections.Generic;

namespace NiceNiceShop.Data;

public partial class KhachHang
{
    public string MaKh { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public string? Email { get; set; }

    public int? Diem { get; set; }

    public string MatKhau { get; set; } = null!;

    public bool GioiTinh { get; set; }

    public string? DiaChi { get; set; }

    public virtual ICollection<GioHang> GioHangs { get; set; } = new List<GioHang>();

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
