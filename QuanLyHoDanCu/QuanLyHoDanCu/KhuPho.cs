﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoDanCu
{
    internal class KhuPho
    {
        private List<GiaDinh> khuPhoDanCu;

        public KhuPho() 
        {
            khuPhoDanCu = new List<GiaDinh>();
        }

        public KhuPho(List<GiaDinh> khuPhoDanCu)
        {
            this.KhuPhoDanCu = khuPhoDanCu;
        }

        internal List<GiaDinh> KhuPhoDanCu 
        { 
            get => khuPhoDanCu; 
            set => khuPhoDanCu = value; 
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("\nNhập số lượng gia đình trong khu phố: ");
            int soLuong;
            while (!int.TryParse(Console.ReadLine(), out soLuong) || soLuong <= 0)
            {
                Console.WriteLine("Số lượng gia đình phải là số nguyên dương.");
            }

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin cho gia đình thứ {i + 1} ---");
                GiaDinh giaDinh = new GiaDinh();
                giaDinh.Nhap();
                khuPhoDanCu.Add(giaDinh);
            }
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n--- Thông tin khu phố ---");
            if (khuPhoDanCu.Count == 0)
            {
                Console.WriteLine("Khu phố hiện không có gia đình nào.");
                return;
            }

            for (int i = 0; i < khuPhoDanCu.Count; i++)
            {
                Console.WriteLine($"\n-- Gia đình thứ {i + 1} --");
                khuPhoDanCu[i].Xuat();
            }
        }

        public void ThemGiaDinh()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            GiaDinh giaDinh = new GiaDinh();
            Console.WriteLine("\nNhập thông tin cho gia đình mới:");
            giaDinh.Nhap();
            khuPhoDanCu.Add(giaDinh);
        }
    }
}