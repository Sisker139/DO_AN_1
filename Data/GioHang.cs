using System;
using System.Collections.Generic;

namespace NiceNiceShop.Data;

public partial class GioHang
{
    public string MaGh { get; set; } = null!;

    public int MaHh { get; set; }

    public string MaKh { get; set; } = null!;

    public int? SoLuong { get; set; }

    public int? DonGia { get; set; }

    public int? TongTien { get; set; }

    public virtual HangHoa MaHhNavigation { get; set; } = null!;

    public virtual KhachHang MaKhNavigation { get; set; } = null!;
}
