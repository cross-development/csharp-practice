// using Sources.Variables;
// using Sources.Arrays;
// using Sources.Cycles;
// using Sources.Conditions;
// using Sources.Methods;
// using csharp_practice.Sources.ClassesPractice;
// using csharp_practice.Sources.Inheritance;
// using csharp_practice.Sources.DelegatePractice;
// using csharp_practice.Sources.DirectoryPractice;
// using csharp_practice.Sources.EventsPractice;

using csharp_practice.Sources.LambdaPractice;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            // VariablesPractice.Run();
            // ArrayPractice.Run();
            // CyclesPractice.Run();
            // ConditionsPractice.Run();
            // MethodsPractice.Run();
            // Classes.Run();
            // ClassicInheritance.Run();

            // ====================== DIRECTORIES and FILES ====================

            // DirectoryService.GetListOfDirectories("DirectoryPractice");
            // DirectoryService.GetListOfFiles("Inheritance");
            // DirectoryService.GetAllFilesInAllFolders("DirectoryPractice", "txt");

            // var salesFiles = DirectoryService.FindFiles("Sources/DirectoryPractice", null);

            // foreach (string file in salesFiles)
            // {
            //     Console.WriteLine($"File - {file}");
            // }

            // PathService.GetFileInfo();

            // DirectoryService.CreateDirectory("NewFolder");
            // DirectoryService.CreateFile("greeting.txt", "Hello World!");

            // DirectoryService.ReadFile();

            // ReadAndWrite.Run();

            // ====================== DELEGATES ====================
            // Delegates.Run();

            // ====================== EVENTS =======================
            // EventsBasic eventsBasic = new EventsBasic();

            // eventsBasic.Run();

            // ====================== LAMBDA =======================
            new Lambda().Run();
        }
    }
}
