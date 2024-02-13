namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = "../Folder1/file.txt";
            string path2 = "../Folder2/file.txt";
            File.Copy(path1, path2);

        }
    }
}
