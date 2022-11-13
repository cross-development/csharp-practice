namespace csharp_practice.Sources.ClassesPractice
{
    public static class Service
    {
        // constant field
        public const string SUPPORT_EMAIL = "support@mycompany.com";

        // private static field
        private static string emailAddress;

        // static constructor
        static Service()
        {
            emailAddress = "test@test.ua";
        }

        // public static method
        public static void SendEmail(string emailTo)
        {
            Console.WriteLine($"Отправляем email с адреса {emailAddress} на адрес {emailTo}.");
        }
    }
}
