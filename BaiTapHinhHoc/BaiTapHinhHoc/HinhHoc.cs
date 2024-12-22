using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapHinhHoc
{
    public abstract class HinhHoc
    {
        public string TenHinh { get; set; }
        public abstract void Nhap();
        public abstract void Xuat();

        public HinhHoc() { }
    }
}
