using Newtonsoft.Json;

// Методы Directory.EnumerateDirectories и Directory.EnumerateFiles принимают параметр, позволяющий указать условие поиска для возвращаемых имен,
// и параметр для рекурсивного прохода по всем дочерним каталогам.

namespace csharp_practice.Sources.DirectoryPractice
{
    public static class DirectoryService
    {
        // Получение пути к текущей папке практики
        public static string GetPathToCurrentDirectory()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "Sources", "DirectoryPractice");
        }

        // Создание каталогов
        public static void CreateDirectory(string newDirName)
        {
            string pathToCurrentFolder = GetPathToCurrentDirectory();
            string pathToTargetFolder = Path.Combine(pathToCurrentFolder, "201", newDirName);

            Directory.CreateDirectory(pathToTargetFolder);
        }

        // Создание файлов и запись содержимого
        public static void CreateFile(string fileNameWithExtension, string text)
        {
            string pathToCurrentFolder = GetPathToCurrentDirectory();
            string pathToTargetFile = Path.Combine(pathToCurrentFolder, fileNameWithExtension);

            File.WriteAllText(pathToTargetFile, text);
        }

        public static void CreateDirAndFile()
        {
            string salesTotalDir = Path.Combine(GetPathToCurrentDirectory(), "salesTotalDir");
            string pathToTargetFile = Path.Combine(salesTotalDir, "totals.txt");

            Directory.CreateDirectory(salesTotalDir);
            File.WriteAllText(pathToTargetFile, String.Empty);
        }

        public static void ReadFile()
        {
            string pathToCurrentFolder = GetPathToCurrentDirectory();
            string salesJson = File.ReadAllText(
                $"{pathToCurrentFolder}{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json"
            );

            SalesTotal? salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);

            // Запись данных в файлы
            File.WriteAllText(
                $"{pathToCurrentFolder}{Path.DirectorySeparatorChar}totals.txt",
                salesData?.Total.ToString()
            );

            // Добавление данных в файлы
            File.AppendAllText(
                $"{pathToCurrentFolder}{Path.DirectorySeparatorChar}totals.txt",
                $"{salesData?.Total}{Environment.NewLine}"
            );
        }

        public static IEnumerable<string> FindFiles(string folderName, string? fileExtension)
        {
            List<string> salesFiles = new List<string>();

            IEnumerable<string> foundFiles = Directory.EnumerateFiles(
                folderName,
                "*",
                SearchOption.AllDirectories
            );

            if (fileExtension != null)
            {
                foreach (var file in foundFiles)
                {
                    var extension = Path.GetExtension(file);

                    if (extension == fileExtension)
                    {
                        salesFiles.Add(file);
                    }
                }
            }
            else
            {
                foreach (string file in foundFiles)
                {
                    if (file.EndsWith("sales.json"))
                    {
                        salesFiles.Add(file);
                    }
                }
            }

            return salesFiles;
        }

        public static void GetListOfDirectories(string directory)
        {
            IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories(
                $"Sources/{directory}"
            );

            foreach (string dir in listOfDirectories)
            {
                Console.WriteLine($"Directory path - {dir}");
            }
        }

        public static void GetListOfFiles(string directory)
        {
            IEnumerable<string> listOfFiles = Directory.EnumerateFiles($"Sources/{directory}");

            foreach (string file in listOfFiles)
            {
                Console.WriteLine($"File path - {file}");
            }
        }

        public static void GetAllFilesInAllFolders(string directory, string fileExtension)
        {
            IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles(
                $"Sources/{directory}",
                $"*.{fileExtension.ToLower()}",
                SearchOption.AllDirectories
            );

            foreach (string file in allFilesInAllFolders)
            {
                Console.WriteLine($"Specific type of file inside directory - {file}");
            }
        }
    }

    class SalesTotal
    {
        public double Total { get; set; }
    }
}
