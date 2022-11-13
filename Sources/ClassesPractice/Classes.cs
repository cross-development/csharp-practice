namespace csharp_practice.Sources.ClassesPractice
{
    public class Classes
    {
        public static void Run()
        {
            //* WITHOUT CONSTRUCTOR

            // Doctor doctor1 = new Doctor();

            // doctor1.firstName = "Ivan";
            // doctor1.middleName = "Ivanovich";
            // doctor1.lastName = "Ivanov";
            // doctor1.position = "Terapevt";
            // doctor1.cabinetNumber = 15;
            // doctor1.patientNumber = 0;

            // int workingDay = 5;

            // doctor1.PrintBio();

            // for (int i = 1; i <= workingDay; i++)
            // {
            //     doctor1.GoToWork();
            // }

            // doctor1.PrintBio();



            //* WITH CONSTRUCTOR

            // Doctor doctor2 = new Doctor("Ivan", "Ivanovich", "Ivanov", "Terapevt");
            // doctor2.CabinetNumber = 15;

            // doctor2.GoToWork();
            // doctor2.PrintBio();

            // Console.WriteLine(Doctor.Address);

            // Doctor.HowManyDoctors();

            // Service.SendEmail("example@test.ua");

            // Console.WriteLine(
            //     $"Отправляйте свои пожелания и предложения на адрес: {Service.SUPPORT_EMAIL}"
            // );

            //* HW

            Atm.WithdrawMoney(000000001, 15_000);
            Atm.WithdrawMoney(000000001, 15_000);
            Atm.WithdrawMoney(000000001, 15_000);
            Atm.WithdrawMoney(000000001, 15_000);

            Atm.DisplayCashBalance("uah");

            Atm.ChangeUahToUsd(1_000);

            Atm.DisplayCashBalance("uah");
            Atm.DisplayCashBalance("usd");
        }
    }
}
