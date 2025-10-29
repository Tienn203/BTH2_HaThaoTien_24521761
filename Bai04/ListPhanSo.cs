using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class ListPhanSo
    {
        private List<CPhanSo> list = new List<CPhanSo>();

        public void Nhap()
        {
            Console.Write("\nNhap n (>0): ");
            int n;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n) && n>0)
                    break;
                Console.Write("Gia tri khong hop le. Nhap lai n: ");
            }
            for(int i=1; i<=n; i++)
            {
                CPhanSo x = new CPhanSo();
                Console.WriteLine("\tNhap phan so thu " + i + ": ");
                x.Nhap();
                list.Add(x);
            }
        }

        public void Xuat()
        {
            foreach(var i in list)
            {
                i.Xuat();
                Console.Write("\t");
            }
        }

        public CPhanSo TimMax()
        {
            CPhanSo res = list[0];
            foreach (var i in list)
            {
                if (i.SoSanhLonHon(res))
                    res = i;
            }
            return res;    
        }

        public void SapXepTang()
        {
            int n = list.Count;
            for(int i=0; i<n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                    if (list[i].SoSanhLonHon(list[j]))
                        (list[i], list[j]) = (list[j], list[i]); //swap 2 phan so
            }
        }
    }


}
