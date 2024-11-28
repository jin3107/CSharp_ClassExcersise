using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.NgoaiLe
{
    public class NgoaiLeSoDienThoai : Exception
    {
        public NgoaiLeSoDienThoai(string message) : base(message)
        {
        }
    }

}
