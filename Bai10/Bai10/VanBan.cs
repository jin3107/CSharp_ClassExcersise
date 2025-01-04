using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    public class VanBan
    {
        public string NoiDung { get; set; }

        public VanBan() { }

        public VanBan(string noiDung)
        {
            NoiDung = noiDung;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập nội dung văn bản: ");
            NoiDung = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nội dung văn bản: " + NoiDung);
        }

        public void DemSoTuVanBan()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            if (string.IsNullOrEmpty(NoiDung))
            {
                Console.WriteLine("Văn bản không tồn tại hoặc rỗng.");
                return;
            }
            else
            {
                string[] words = NoiDung.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("Số từ của văn bản: " + words.Length);
            }
        }

        public void DemSoLuongKyTuA()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            if (string.IsNullOrEmpty(NoiDung))
            {
                Console.WriteLine("Văn bản không tồn tại hoặc rỗng.");
                return;
            }
            else
            {
                int count = 0;
                foreach (char c in NoiDung)
                {
                    if (c == 'A' || c == 'a')
                    {
                        count++;
                    }
                }
                Console.WriteLine("Số lượng ký tự 'A' trong văn bản: " + count);
            }
        }

        public void ChuanHoaVanBan()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            if (string.IsNullOrEmpty(NoiDung))
            {
                Console.WriteLine("Văn bản không tồn tại hoặc rỗng.");
                return;
            }
            else
            {
                NoiDung = NoiDung.Trim();
                while (NoiDung.Contains("  "))
                {
                    NoiDung = NoiDung.Replace("  ", " ");
                }
                Console.WriteLine("Văn bản sau khi chuẩn hoá: " + NoiDung);
            }
        }
    }
}
