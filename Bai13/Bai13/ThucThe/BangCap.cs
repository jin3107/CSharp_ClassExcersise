using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13.ThucThe
{
    public class BangCap
    {
        public string MaBangCap { get; set; }
        public string Ten { get; set; }
        public DateTime NgayCap { get; set; }
        public string XepLoai { get; set; }

        public BangCap() { }

        public BangCap(string maBangCap, string ten, DateTime ngayCap, string xepLoai)
        {
            MaBangCap = maBangCap;
            Ten = ten;
            NgayCap = ngayCap;
            XepLoai = xepLoai;
        }
    }
}
