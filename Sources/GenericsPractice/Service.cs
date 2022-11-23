namespace csharp_practice.Sources.GenericsPractice
{
    public static class Service
    {
        public static void PrintPhoneNumber<T>(T phone)
        {
            Console.WriteLine($"Phone number: {phone}");
        }

        public static T ResetPhoneNumber<T>(T phone)
        {
            return default(T);
        }
    }
}