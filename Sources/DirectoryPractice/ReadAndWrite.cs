using Newtonsoft.Json;

namespace csharp_practice.Sources.DirectoryPractice
{
    public class ReadAndWrite
    {
        public static void Run()
        {
            string pathToCurrentDirectory = DirectoryService.GetPathToCurrentDirectory();
            string salesTotalDir = Path.Combine(pathToCurrentDirectory, "salesTotalDir");

            Directory.CreateDirectory(salesTotalDir);

            IEnumerable<string> salesFiles = DirectoryService.FindFiles(
                pathToCurrentDirectory,
                null
            );

            double salesTotal = CalculateSalesTotal(salesFiles);

            File.AppendAllText(
                Path.Combine(salesTotalDir, "totals.txt"),
                $"{salesTotal}{Environment.NewLine}"
            );
        }

        public static double CalculateSalesTotal(IEnumerable<string> salesFiles)
        {
            double salesTotal = 0;

            foreach (string file in salesFiles)
            {
                string salesJson = File.ReadAllText(file);

                SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);

                salesTotal += data?.Total ?? 0;
            }

            return salesTotal;
        }

        record SalesData(double Total);
    }
}
