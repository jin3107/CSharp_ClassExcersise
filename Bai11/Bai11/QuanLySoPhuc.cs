using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    internal class QuanLySoPhuc
    {
        private List<SoPhuc> listSoPhuc = new List<SoPhuc>();
        public void NhapSoPhuc()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("\nNhập số lượng số phức: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n-- Số phức thứ {i + 1} --");
                SoPhuc soPhuc = new SoPhuc();
                soPhuc.NhapSoPhuc();
                listSoPhuc.Add(soPhuc);
            }
        }

        public void HienThiSoPhuc()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\nHiển thị danh sách số phức:");
            int i = 1;
            foreach (SoPhuc soPhuc in listSoPhuc)
            {
                Console.Write($"Q{i} = ");
                soPhuc.HienThiSoPhuc();
                i++;
            }
        }

        public void CongSoPhuc()
        {
            SoPhuc tong = new SoPhuc();
            foreach (SoPhuc soPhuc in listSoPhuc)
            {
                tong = tong.Cong(soPhuc);
            }
            Console.WriteLine("\nTổng các số phức:");
            Console.Write("S = ");
            tong.HienThiSoPhuc();
        }

        public void NhanSoPhuc()
        {
            SoPhuc tich = new SoPhuc(1, 0);
            foreach (SoPhuc soPhuc in listSoPhuc)
            {
                tich = tich.Nhan(soPhuc);
            }
            Console.WriteLine("\nTích các số phức:");
            Console.Write("P = ");
            tich.HienThiSoPhuc();
        }
    }
}
