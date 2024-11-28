using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.NgoaiLe
{
    public class NgoaiLeEmail : Exception
    {
        public NgoaiLeEmail(string message) : base(message)
        {
        }
    }

}
