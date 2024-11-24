using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.NgoaiLe
{
    internal class NgoaiLeSoDienThoai : System.Exception
    {
        public NgoaiLeSoDienThoai(string message) : base(message)
        {
        }
    }

}
