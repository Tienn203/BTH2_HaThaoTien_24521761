namespace Bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPhanSo a = new CPhanSo();
            CPhanSo b = new CPhanSo();
            CPhanSo res = new CPhanSo();
            Console.WriteLine("\tNhap phan so a: ");
            a.Nhap();
            Console.WriteLine("\tNhap phan so b: ");
            b.Nhap();

            Console.Write("\nTong hai phan so: ");
            res = a + b;
            res.Xuat();

            Console.Write("\nHieu hai phan so: ");
            res = a - b;
            res.Xuat();

            Console.Write("\nTich hai phan so: ");
            res = a * b;
            res.Xuat();

            Console.Write("\nThuong hai phan so: ");
            res = a / b;
            res.Xuat();
            Console.WriteLine();

            ListPhanSo list = new ListPhanSo();
            list.Nhap();
            Console.WriteLine("\nDanh sach phan so vua nhap: ");
            list.Xuat();

            Console.Write("\nPhan so lon nhat trong danh sach: ");
            list.TimMax().Xuat();

            Console.WriteLine("\nDanh sach phan so sau khi sap xep tang dan: ");
            list.SapXepTang();
            list.Xuat();

        }
    }
}
