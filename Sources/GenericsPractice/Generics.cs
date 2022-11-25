namespace csharp_practice.Sources.GenericsPractice
{
    public class Generics
    {
        public static void Run()
        {
            Person<int, int> p1 = new Person<int, int>();
            p1.PhoneNumber = 111112222;
            p1.AccountNumber = 099999999;

            Person<string, int> p2 = new Person<string, int>();
            p2.PhoneNumber = "111-222-222";
            p2.AccountNumber = 12312312;

            Person<PhoneNumber, string> p3 = new Person<PhoneNumber, string>();
            p3.PhoneNumber = new PhoneNumber()
            {
                Country = "Ukraine",
                Code = 38,
                Number = "111-222-333"
            };
            p3.AccountNumber = "qwe-123";

            Service.PrintPhoneNumber(p1.PhoneNumber);
            Service.PrintPhoneNumber(p2.PhoneNumber);
            Service.PrintPhoneNumber(p3.PhoneNumber);
        }
    }
}
