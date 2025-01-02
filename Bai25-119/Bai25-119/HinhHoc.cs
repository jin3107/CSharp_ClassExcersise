using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai25_119
{
    public abstract class HinhHoc
    {
        public string TenHinh { get; set; }
        public abstract void Nhap();
        public abstract void Xuat();

        public HinhHoc() { }

        protected HinhHoc(string tenHinh)
        {
            TenHinh = tenHinh;
        }
    }
}
