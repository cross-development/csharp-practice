namespace csharp_practice.Sources.DirectoryPractice
{
    public static class PathService
    {
        public static void GetPath()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine($"{docPath}");

            Console.WriteLine(Path.GetExtension("sales.json")); // outputs: .json

            Console.WriteLine(Path.Combine("Sources", "DirectoryPractice", "201")); // outputs: Sources/DirectoryPractice/201

            Console.WriteLine(
                $"Sources{Path.DirectorySeparatorChar}DirectoryPractice{Path.DirectorySeparatorChar}201"
            );
        }

        public static void GetFileInfo()
        {
            string fileName =
                $"Sources{Path.DirectorySeparatorChar}DirectoryPractice{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

            FileInfo info = new FileInfo(fileName);

            Console.WriteLine(
                $"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"
            );
        }

        public static void CombinePath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string storeDirectory = Path.Combine(currentDirectory, "Sources", "DirectoryPractice");
            IEnumerable<string> salesFiles = DirectoryService.FindFiles(storeDirectory, null);

            foreach (string file in salesFiles)
            {
                Console.WriteLine($"File => {file}");
            }
        }
    }
}
