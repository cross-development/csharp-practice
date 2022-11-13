namespace Sources.Variables;

public class VariablesPractice
{
    public static void Run()
    {
        // тип_данных имя_переменной = значение (опциональное)

        Console.WriteLine("Before init and changing");

        int a = 17;
        string title = "War and peace";
        bool jobIsDone = false;

        Console.WriteLine(a);
        Console.WriteLine(title);
        Console.WriteLine(jobIsDone);

        Console.WriteLine("After init and changing");

        a = 22;
        int b = 22;
        a = b;

        Console.WriteLine(a);

        int pagesCountInMyBook = 205;

        Console.WriteLine($"Pages count in my book {pagesCountInMyBook}");

        // =================================================================
        // арифметические операторы

        int x = 10;
        int y = 5;
        int z;

        z = x + y; // 15
        z = x - y; // 5
        z = x * y; // 50
        z = x / y; // 0
        z = x + x + x - y - x; // 15

        int s = 3;
        int w = 2;
        Console.WriteLine(s / w); // 1 instead of 1.5

        double c = 3;
        double d = 2;
        Console.WriteLine(c / d); // 1.5

        int k = 15;
        k++;
        Console.WriteLine($"k = {k}");

        int n = 0;
        int m = 0;
        Console.WriteLine(n++);
        Console.WriteLine(++m);

        // Класс Math
        double p = Math.Pow(4, 3); // возведение в степень
        double q = Math.Max(100, 200); // максимальное значение

        // HW
        int daysOfWeek = 7;
        int weeksOfYear = 4 * 12;
        Console.WriteLine($"Days of week = {daysOfWeek}");
        Console.WriteLine($"Weeks of year = {weeksOfYear}");

        int totalDaysOfYear = daysOfWeek * weeksOfYear;
        Console.WriteLine($"Total days of year = {totalDaysOfYear}");

        // =================================================================
        // текстовые типы данных

        string firstName = "Ivan";
        string lastName = "Ivanov";
        string middleName = "Ivanovich";

        string fio = lastName + " " + firstName + " " + middleName;
        Console.WriteLine(fio); // Ivanov Ivan Ivanovich

        Console.WriteLine($"FIO: {fio}");
        Console.WriteLine("FIO: " + fio);
        Console.WriteLine("FIO: {0}", fio);
        Console.WriteLine("FIO: {0} {1} {2}", lastName, firstName, middleName);

        Console.WriteLine(3 + 4); // 7
        Console.WriteLine("3" + "4"); // "34"

        int r = 25;
        string f = r.ToString();

        string someText = "123";
        int someNumber = int.Parse(someText);

        // ****************************************************************

        char symbol = '5';
        char symbol2 = '?';

        Console.WriteLine("Symbol {0} is a number: {1}", symbol, char.IsDigit(symbol));
        Console.WriteLine("Symbol {0} is a number: {1}", symbol, char.IsDigit(symbol2));
        Console.WriteLine("Symbol {0} is a punctuation: {1}", symbol, char.IsPunctuation(symbol2));

        // =================================================================
        // логические типы данных

        bool isOperationFinished = false;
        Console.WriteLine(" Is operation finished? {0}", isOperationFinished);

        bool boolResult;

        boolResult = 5 > 6;
        boolResult = 18 - 2 == 16;
        boolResult = "snow" == "snow";

        char t = 'S';

        char.IsUpper(t);
        Console.WriteLine($"BoolResult {boolResult}");
    }
}
