namespace Bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Nhap so dong n (>0): ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                    break;
                Console.Write("Gia tri khong hop le. Nhap lai n: ");
            }

            Console.Write("Nhap so cot m (>0): ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out m) && m > 0)
                    break;
                Console.Write("Gia tri khong hop le. Nhap lai m: ");
            }

            int[,] matrix = new int[n, m];
            for (int i=0; i<n; i++) { 
                for(int j=0; j<m; j++)
                {
                    Console.Write($"Nhap phan tu thu [{i}, {j}]: ");
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out matrix[i, j]))
                            break;
                        Console.Write("Gia tri khong hop le. Nhap lai: ");
                    }
                }
            }

            Console.WriteLine("\n\t=====MENU=====");
            Console.WriteLine("Nhap 1 de in ma tran vua nhap.");
            Console.WriteLine("Nhap 2 de tim kiem phan tu trong ma tran.");
            Console.WriteLine("Nhap 3 de xuat cac phan tu la so nguyen to.");
            Console.WriteLine("Nhap 4 de tim dong co nhieu so nguyen to nhat.");
            Console.WriteLine("Nhap 0 de thoat chuong trinh.");

            int x = -1;
            do
            {
                Console.Write("\nChon chuc nang: ");
                if (int.TryParse(Console.ReadLine(), out x) == false)
                {
                    Console.WriteLine("\tLua chon khong hop le!");
                    x = -1;
                    continue;
                }

                switch (x)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("\tMa tran vua nhap la: ");
                        XuatMaTran(matrix, n, m);
                        break;
                    case 2:
                        Console.Write("\tNhap phan tu can tim: ");
                        int k;
                        while (true)
                        {
                            if (int.TryParse(Console.ReadLine(), out k))
                                break;
                            Console.Write("\tGia tri khong hop le. Nhap lai: ");
                        }

                        if (TimKiemPhanTu(matrix, n, m, k))
                            Console.WriteLine($"\tPhan tu {k} co trong ma tran.");
                        else Console.WriteLine($"\tPhan tu {k} khong co trong ma tran.");
                        break;
                    case 3:
                        Console.WriteLine("\tCac phan tu la so nguyen to trong ma tran: ");
                        XuatSoNguyenTo(matrix, n, m);
                        Console.WriteLine();
                        break;
                    case 4:
                        int res = DongCoNhieuSoNguyenToNhat(matrix, n, m);
                        if (res == -1)
                            Console.WriteLine("\tKhong co so nguyen to nao trong ma tran.");
                        else Console.WriteLine($"\tDong co nhieu so nguyen to nhat: {res}");
                        break;
                    default:
                        Console.WriteLine("\tLua chon khong hop le!");
                        break;
                }
            }
            while (x != 0);
        }

        static void XuatMaTran(int[,] a, int n, int m) { 
            for(int i=0; i<n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static bool TimKiemPhanTu(int[,] a, int n, int m, int k)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (a[i, j] == k)
                        return true;
            }
            return false;
        }
        static bool KtSoNguyenTo(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        static void XuatSoNguyenTo(int[,] a, int n, int m)
        {
            bool flag = false;
            for(int i=0; i<n; i++)
            {
                for (int j = 0; j<m; j++)
                {
                    if (KtSoNguyenTo(a[i, j]))
                    {
                        flag = true;
                        Console.Write("\t" + a[i, j]);
                    }
                }
            }
            if (flag == false)
                Console.Write("\nKhong co so nguyen to nao trong ma tran.");
        }

        static int DongCoNhieuSoNguyenToNhat(int[,] a, int n, int m) //neu khong co so nguyen to nao thi return -1
        {
            int max = 0;
            int res = -1;
            
            for(int i=0; i<n; i++)
            {
                int count = 0;
                for(int j=0; j<m; j++)
                {
                    if (KtSoNguyenTo(a[i, j]))
                        count++;
                }
                
                if (count>max)
                {
                    max = count;
                    res = i;
                }
            }

            return res;
        }
    }
}
