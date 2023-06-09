namespace csharp_practice.Sources.ClassesPractice
{
    public static class Atm
    {
        public static string Address { get; set; }
        public static string SupportFIO { get; set; }
        public static double Uah { get; set; }
        public static double Usd { get; set; }
        public static double UsdCourse { get; set; }

        static Atm()
        {
            Address = "Some address";
            SupportFIO = "Ivanov Ivan";
            Uah = 50000;
            Usd = 3000;
            UsdCourse = 40.50;
        }

        public static void DisplayCashBalance(string currency)
        {
            switch (currency.ToLower())
            {
                case "uah":
                    Console.WriteLine($"На Вашем счету {Uah} гривен.\n");
                    break;
                case "usd":
                    Console.WriteLine($"На Вашем счету {Usd} гривен.\n");
                    break;
                default:
                    Console.WriteLine($"Ошибка! Такой валюты нет.\n");
                    break;
            }
        }

        public static double WithdrawMoney(int accountNumber, int amount)
        {
            Console.WriteLine($"Снимаем деньги со счета {accountNumber}");

            if (Uah >= amount)
            {
                Uah -= amount;
                Console.WriteLine("Операция прошла успешно. Заберите Ваши деньги и карту.\n");

                return amount;
            }

            Console.WriteLine("Ошибка! В банкомате недостаточно средств.\n");

            return 0;
        }

        public static void DepositMoney(int accountNumber, int amount)
        {
            Console.WriteLine($"Зачисляем деньги на счет {accountNumber}");
            Console.WriteLine("Операция прошла успешно. Заберите Вашу карту.\n");

            Uah += amount;
        }

        public static double ChangeUahToUsd(double amount)
        {
            Console.WriteLine("Обмениваем гривны на доллары...");

            double result = amount / UsdCourse;

            if (Usd >= result)
            {
                Usd -= result;
                Console.WriteLine("Операция прошла успешно. Заберите Ваши деньги и карту.\n");

                return result;
            }

            Console.WriteLine("Ошибка! В банкомате недостаточно средств.\n");

            return 0;
        }

        public static double ChangeUsdToUah(double amount)
        {
            Console.WriteLine("Обмениваем доллары на гривны...");

            double result = amount * UsdCourse;

            if (Uah >= result)
            {
                Uah -= result;
                Console.WriteLine("Операция прошла успешно. Заберите Ваши деньги и карту.\n");

                return result;
            }

            Console.WriteLine("Ошибка! В банкомате недостаточно средств.\n");

            return 0;
        }
    }
}
