using System.Text;

namespace Basic2.Sources.BasicPractice;

public class Strings
{
    public void Run()
    {
        StringBuilderDemo();
        StringModification();
        StringEmptiness();
        QueryingStrings();
        StringFormat();
        ComparingStrings();
    }

    private void ComparingStrings()
    {
        string str1 = "abcde";
        string str2 = "abcde";
        bool areEqual = str1 == str2;
        Console.WriteLine(areEqual); // true

        areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
        Console.WriteLine(areEqual); // true

        string s1 = "Strasse";
        string s2 = "Straße";

        areEqual = string.Equals(s1, s2, StringComparison.Ordinal); // Ordinal is the same as str1 == str2. 
        Console.WriteLine(areEqual); // false

        areEqual = string.Equals(s1, s2, StringComparison.InvariantCulture); // Don't compare by bytes.
        Console.WriteLine(areEqual); // true

        areEqual = string.Equals(s1, s2, StringComparison.CurrentCulture); // Culture will be given in local machine
        Console.WriteLine(areEqual); // true
    }

    private void StringFormat()
    {
        string name = "John";
        ushort age = 30;

        string str = string.Format("My name is {0} and I'm {1}", name, age.ToString());
        Console.WriteLine(str);
        str = "My name is " + name + " and I'm " + age;
        Console.WriteLine(str);

        str = $"My name is {name} and I'm {age}";
        Console.WriteLine(str);

        str = "My name is \nJohn";
        Console.WriteLine(str);

        str = "I'm \t30";
        Console.WriteLine(str);

        str = $"My name is {Environment.NewLine}John";
        Console.WriteLine(str);

        str = "I'm John and I'm a \"good\" programmer";
        Console.WriteLine(str);

        str = @"C:\tmp\test_file.txt";
        Console.WriteLine(str);

        int answer = 42;
        string result = string.Format("{0:d}", answer.ToString()); // 42
        Console.WriteLine(result);

        result = string.Format("{0:d4}", answer.ToString()); // 0042
        Console.WriteLine(result);

        result = string.Format("{0:f}", answer.ToString()); // 42,00
        Console.WriteLine(result);

        result = string.Format("{0:f4}", answer.ToString()); // 42,0000
        Console.WriteLine(result);

        // Console.OutputEncoding = Encoding.UTF8;

        double money = 12.8;
        result = string.Format("{0:C}", money.ToString());
        Console.WriteLine(result); // 12,80 usd

        result = string.Format("{0:C2}", money.ToString());
        Console.WriteLine(result); // 12,80 usd

        result = money.ToString("C2");
        Console.WriteLine(result);

        result = $"{money:C2}";
        Console.WriteLine(result);

        // Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        // Console.WriteLine(money.ToString("C2")); // $12.80
    }

    private void StringBuilderDemo()
    {
        // Works faster if we have more than 5-7 strings (words)
        StringBuilder sb = new StringBuilder();

        sb.Append("My ");
        sb.Append("name ");
        sb.Append("is ");
        sb.Append("John");
        sb.AppendLine("!");
        sb.AppendLine("Hello!");

        string str = sb.ToString();
        Console.WriteLine(str);
    }

    private void StringModification()
    {
        string nameConcat = string.Concat("My ", "name ", "is ", "John!");
        Console.WriteLine(nameConcat); // return "My name is John!"

        nameConcat = string.Join(" ", "My", "name", "is", "John");
        Console.WriteLine(nameConcat); // return "My name is John"

        nameConcat = "My " + "name " + "is " + "John";

        nameConcat = nameConcat.Insert(0, "By the way, ");
        Console.WriteLine(nameConcat); // return "By the way, My name is John"

        nameConcat = nameConcat.Remove(0, 1);
        Console.WriteLine(nameConcat); // return "y the way, My name is John"

        string replaced = nameConcat.Replace('n', 'z');
        Console.WriteLine(replaced); // return "y the way, My zame is Johz"

        string data = "12;28;34;25;64";
        string[] splitData = data.Split(';');
        Console.WriteLine(splitData); // return ["12", "28" , "34", "25", "64"]

        string first = splitData[0];
        Console.WriteLine(first); // return "12"

        char[] chars = nameConcat.ToCharArray();
        Console.WriteLine(chars); // return ['12', '28' , '34', '25', '64']

        char firstChar = chars[0];
        Console.WriteLine(firstChar); // return '12'

        char firstLetter = nameConcat[0];
        Console.WriteLine(firstLetter); // return first letter in the nameConcat string

        string upper = nameConcat.ToUpper();
        Console.WriteLine(upper); // transform all nameConcat string to upper case 

        string lower = nameConcat.ToLower();
        Console.WriteLine(lower); // transform all nameConcat string to lower case

        string john = " My name is John ";
        Console.WriteLine(john.Trim()); // remove white spaces at the start and the end of the string
    }

    private void StringEmptiness()
    {
        string empty = "";
        string withSpaced = " ";
        string notEmpty = " b";
        string? nullString = null;

        string str = string.Empty; // is the same as a string with "" value

        // nullString.Contains('a'); ==> Error in the runtime

        #region IsNullOrEmpty

        Console.WriteLine("IsNullOrEmpty ==> null or empty string without whitespaces");

        bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
        Console.WriteLine(isNullOrEmpty); // true

        isNullOrEmpty = string.IsNullOrEmpty(withSpaced);
        Console.WriteLine(isNullOrEmpty); // false

        isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
        Console.WriteLine(isNullOrEmpty); // false

        isNullOrEmpty = string.IsNullOrEmpty(empty);
        Console.WriteLine(isNullOrEmpty); // true

        #endregion

        #region IsNullOrWhiteSpace

        Console.WriteLine("IsNullOrWhiteSpace ==> null or empty string with/without whitespaces inside");

        bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
        Console.WriteLine(isNullOrWhiteSpace); // true

        isNullOrWhiteSpace = string.IsNullOrWhiteSpace(withSpaced);
        Console.WriteLine(isNullOrWhiteSpace); // true

        isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
        Console.WriteLine(isNullOrWhiteSpace); // false

        isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
        Console.WriteLine(isNullOrWhiteSpace); // true

        #endregion
    }

    private void QueryingStrings()
    {
        string name = "qweasdzxc";

        bool containA = name.Contains('a');
        bool containB = name.Contains('b');

        Console.WriteLine(containA);
        Console.WriteLine(containB);

        bool endsWithZxc = name.EndsWith("zxc");
        Console.WriteLine(endsWithZxc);

        bool startsWithQwe = name.StartsWith("qwe");
        Console.WriteLine(startsWithQwe);

        int indexOfE = name.IndexOf('e', 0);
        Console.WriteLine(indexOfE);

        int lastIndexOfC = name.LastIndexOf('c');
        Console.WriteLine(lastIndexOfC);

        int lengthOfName = name.Length;
        Console.WriteLine(lengthOfName);

        string substrFrom5 = name.Substring(5); // from 5 index (included) to the end of the string
        Console.WriteLine(substrFrom5);

        string substrFromTo = name.Substring(0, 3);
        Console.WriteLine(substrFromTo); // from 0 index (included) to the 3 index (not included)
    }
}