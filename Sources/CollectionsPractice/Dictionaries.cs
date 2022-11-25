namespace csharp_practice.Sources.CollectionsPractice
{
    public class Dictionaries
    {
        public static void Run()
        {
            Dictionary<string, string> phones = new Dictionary<string, string>();
            phones.Add("Ivanov", "111-111-111");
            phones.Add("Petrov", "222-222-222");

            Console.WriteLine($"Ivanov's phone number: {phones["Ivanov"]}");

            Dictionary<int, decimal> accounts = new Dictionary<int, decimal>();
            accounts.Add(1, 500.3m);
            accounts.Add(2, 1400.2m);

            Console.WriteLine($"Account number {1} has amount {accounts[1]} usd");

            accounts.Clear();
        }
    }
}
