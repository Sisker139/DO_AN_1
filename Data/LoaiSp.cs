using System;
using System.Collections.Generic;

namespace NiceNiceShop.Data;

public partial class LoaiSp
{
    public int MaLoaiSp { get; set; }

    public string TenLoaiSp { get; set; } = null!;

    public string? MoTa { get; set; }

    public string? Hinh { get; set; }

    public virtual ICollection<HangHoa> HangHoas { get; set; } = new List<HangHoa>();
}
