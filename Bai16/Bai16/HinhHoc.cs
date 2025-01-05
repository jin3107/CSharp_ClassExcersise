using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    public class HinhHoc
    {
        public string TenHinh { get; set; }
        public virtual void Nhap() { }
        public virtual void Xuat() { }

        public HinhHoc(string tenHinh)
        {
            TenHinh = tenHinh;
        }

        public HinhHoc() { }
    }
}
