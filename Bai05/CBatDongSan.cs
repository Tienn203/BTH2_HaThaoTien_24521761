using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class CBatDongSan
    {
        protected string DiaDiem { get; set; }
        protected float GiaBan { get; set; }
        protected float DienTich { get; set; }

        public CBatDongSan()
        {
            DiaDiem = "";
            GiaBan = 0;
            DienTich = 0;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap dia diem: ");
            DiaDiem = Console.ReadLine();

            float tmp;
            Console.Write("Nhap gia ban (VND): ");
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out tmp) && tmp > 0)
                {
                    GiaBan = tmp;
                    break;
                }
                Console.Write("Gia tri khong hop le. Nhap lai gia ban: ");
            }

            Console.Write("Nhap dien tich (m2): ");
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out tmp) && tmp > 0)
                {
                    DienTich = tmp;
                    break;
                }
                Console.Write("Gia tri khong hop le. Nhap lai dien tich: ");
            }
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Dia diem: " + DiaDiem);
            Console.WriteLine($"Gia ban: {GiaBan} VND");
            Console.WriteLine($"Dien tich: {DienTich} m2");
        }

        public float getGiaBan()
        {
            return GiaBan;
        }
        public float getDienTich()
        {
            return DienTich;
        }

        public string getDiaDiem()
        {
            return DiaDiem;
        }
    }



}
