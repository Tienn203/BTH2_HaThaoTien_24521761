namespace Bai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap duong dan thu muc: ");
            string path = Console.ReadLine();

            if (Directory.Exists(path) == false)
            {
                Console.WriteLine("Thu muc khong ton tai.");
                return;
            }

            Console.WriteLine("\n\tDirectory of " + path);

            string[] dirs = Directory.GetDirectories(path); //Danh sach thu muc con
            string[] files = Directory.GetFiles(path); //Danh sach tap tin

            long totalSize = 0;

            string root = Path.GetPathRoot(path); //Lay o dia goc
            DriveInfo drive = new DriveInfo(root);
            long freeSpace = drive.AvailableFreeSpace; //Dung luong con trong cua o dia

            for(int i=0; i<dirs.Length; i++) //In thu muc con
            {
                DirectoryInfo d = new DirectoryInfo(dirs[i]);
                Console.WriteLine(d.LastWriteTime.ToString("dd/MM/yyyy hh:mm tt") + "\t< DIR >\t\t" + d.Name);
            }

            for(int i=0; i<files.Length; i++) //In tap tin
            {
                FileInfo f = new FileInfo(files[i]);
                Console.WriteLine(f.LastWriteTime.ToString("dd/MM/yyyy hh:mm tt") + "\t\t" + f.Length + "\t\t" + f.Name);
                totalSize += f.Length;
            }

            Console.WriteLine($"\t{files.Length} File(s) \t {totalSize} bytes");
            Console.WriteLine($"\t{dirs.Length} Dir(s) \t {freeSpace} bytes free");
        }
    }
}
