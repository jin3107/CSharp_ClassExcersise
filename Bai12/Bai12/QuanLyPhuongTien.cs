using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class QuanLyPhuongTien
    {
        private List<PhuongTien> danhSachPhuongTien = new List<PhuongTien>();

        internal List<PhuongTien> DanhSachPhuongTien { get => danhSachPhuongTien; set => danhSachPhuongTien = value; }

        public QuanLyPhuongTien(List<PhuongTien> danhSachPhuongTien)
        {
            this.DanhSachPhuongTien = danhSachPhuongTien;
        }

        public QuanLyPhuongTien()
        {
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n1. Xe máy");
            Console.WriteLine("2. Ô tô");
            Console.WriteLine("3. Xe tải");
            Console.Write("Chọn loại phương tiện: ");
            int chon = int.Parse(Console.ReadLine());
            PhuongTien phuongTien = null;
            switch (chon)
            {
                case 1:
                    Console.WriteLine("\n-- Nhập thông tin cho xe máy --");
                    phuongTien = new XeMay();
                    break;
                case 2:
                    Console.WriteLine("\n-- Nhập thông tin cho ô tô --");
                    phuongTien = new Oto();
                    break;
                case 3:
                    Console.WriteLine("\n-- Nhập thông tin cho xe tải --");
                    phuongTien = new XeTai();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
            phuongTien.Nhap();
            DanhSachPhuongTien.Add(phuongTien);
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n-- Hiển thị danh sách phương tiện --");
            int level = 0;
            foreach (var item in DanhSachPhuongTien)
            {
                Console.WriteLine($"Phương tiện thứ {level + 1}");
                Console.WriteLine(item);
                level++;
            }
        }

        public void Xoa()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("\nNhập Id phương tiện cần xóa: ");
            string id = Console.ReadLine();
            foreach (var item in DanhSachPhuongTien)
            {
                if (item.Id == id)
                {
                    DanhSachPhuongTien.Remove(item);
                    Console.WriteLine("Đã xóa phương tiện có ID = " + id);
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy phương tiện có ID = " + id);
        }

        public void TimKiem()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\nNhập Hãng/Màu phương tiện cần tìm: ");
            
            Console.WriteLine("1. Hãng xe");
            Console.WriteLine("2. Màu xe");
            Console.Write("Lựa chọn của bạn: ");
            int chon = int.Parse(Console.ReadLine());
            int level = 0;
            switch (chon)
            {
                case 1:
                    Console.Write("\nNhập hãng phương tiện cần tìm: ");
                    string hang = Console.ReadLine();
                    foreach (var item in DanhSachPhuongTien)
                    {
                        if (item.HangSanXuat == hang)
                        {
                            Console.WriteLine($"Phương tiện thứ {level + 1}");
                            Console.WriteLine(item);
                            level++;
                        }
                        Console.WriteLine("Hãng phương tiện không tồn tại.");
                    }
                    break;
                case 2:
                    Console.Write("\nNhập màu phương tiện cần tìm: ");
                    string mau = Console.ReadLine();
                    foreach (var item in DanhSachPhuongTien)
                    {
                        if (item.MauXe == mau)
                        {
                            Console.WriteLine($"Phương tiện thứ {level + 1}");
                            Console.WriteLine(item);
                            level++;
                        }
                        Console.WriteLine("Màu phương tiện không tồn taị.");
                    }
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }        
        }
    }
}
