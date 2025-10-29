using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class ListBatDongSan
    {
        private List<CBatDongSan> DanhSach;

        public void Nhap()
        {
            int n;
            Console.Write("Nhap so luong bat dong san: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                    break;
                Console.Write("Gia tri khong hop le. Nhap lai so luong: ");
            }

            DanhSach = new List<CBatDongSan>();
            for (int i = 0; i < n; i++)
            {
                int x;
                Console.Write("Nhap loai bat dong san (1 = Khu dat, 2 = Nha Pho, 3 = Chung Cu): ");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out x) && x > 0 && x < 4)
                        break;
                    Console.Write("Gia tri khong hop le. Nhap lai: ");
                }

                CBatDongSan bds = null;
                switch (x)
                {
                    case 1:
                        bds = new CKhuDat();
                        break;
                    case 2:
                        bds = new CNhaPho();
                        break;
                    case 3:
                       bds = new CChungCu();
                        break;
                }

                bds.Nhap();
                DanhSach.Add(bds);
               
            }
        }

        public void Xuat()
        {
            Console.WriteLine("\n\t-----Thong tin cac bat dong san vua nhap-----");
            for (int i = 0; i < DanhSach.Count; i++)
            {
                DanhSach[i].Xuat();
            }
        }

        public float TongGiaBan()
        {
            float Tong = 0;
            for (int i = 0; i < DanhSach.Count; i++)
            {
                Tong += DanhSach[i].getGiaBan();
            }
            return Tong;
        }

        public void XuatKhuDatDienTichLonHon100m2()
        {
            bool flag = false;
            Console.WriteLine("\n\t----- Danh sach khu dat co dien tich lon hon 100m2 -----");
            for (int i = 0; i < DanhSach.Count; i++)
            {
                if (DanhSach[i] is CKhuDat && DanhSach[i].getDienTich() > 100)
                {
                    flag = true;
                    DanhSach[i].Xuat();
                    Console.WriteLine();
                }
            }
            if (!flag)
                Console.WriteLine("Khong co khu dat nao phu hop yeu cau!");


        }

        public void XuatNhaPhoDienTichLonHon60NamXDTu2019()
        {
            bool flag = false;
            Console.WriteLine("\n\t-----Danh sach nha pho có dien tich > 60m2 va nam xay dung >= 2019-----");
            for (int i = 0; i < DanhSach.Count; i++)
            {
                if (DanhSach[i] is CNhaPho)
                {
                    CNhaPho tmp = (CNhaPho)DanhSach[i];
                    if (tmp.getDienTich() > 60 && tmp.getNamXayDung() >= 2019)
                    {
                        flag = true;
                        DanhSach[i].Xuat();
                        Console.WriteLine();
                    }
                }
            }
            if (!flag)
                Console.WriteLine("Khong co nha pho nao phu hop yeu cau!");
        }

        public void TimKiem()
        {
            string diadiem;
            float gia, dientich;
            Console.WriteLine("\t---Nhap thong tin can tim kiem---");
            Console.Write("Nhap dia diem: ");
            diadiem = Console.ReadLine();
            diadiem = diadiem.ToLower();
            
            Console.Write("Nhap gia ban: ");
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out gia))
                    break;
                Console.Write("Gia tri vua nhap khong hop le. Nhap lai gia ban: ");
            }

            Console.Write("Nhap dien tich: ");
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out dientich))
                    break;
                Console.Write("Gia tri vua nhap khong hop le. Nhap lai dien tich: ");
            }

            Console.WriteLine();
            bool flag = false;
            foreach(var bds in DanhSach)
            {
                if(bds is CNhaPho || bds is CChungCu)
                {
                    string dd = bds.getDiaDiem().ToLower();
                    if (dd == diadiem && bds.getGiaBan() <= gia && bds.getDienTich() >= dientich)
                    {
                        bds.Xuat();
                        flag = true;
                    }
                }
            }
            if (!flag)
                Console.WriteLine("Khong tim thay bat dong san phu hop!");
        }
    }
}
