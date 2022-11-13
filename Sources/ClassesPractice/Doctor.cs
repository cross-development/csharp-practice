namespace csharp_practice.Sources.ClassesPractice
{
    public class Doctor
    {
    #region Fields

        private int cabinetNumber;

    #endregion


    #region Properties

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int PatientNumber { get; set; }
        public static string Address { get; private set; }
        private static int DoctorsCount { get; set; }

        public int CabinetNumber
        {
            get { return cabinetNumber; }
            set
            {
                if (value > 100)
                    value = 100;
                if (value < 1)
                    value = 1;

                cabinetNumber = value;
            }
        }

    #endregion


    #region Constructors
        // static constructor
        static Doctor()
        {
            Address = "Какой-то адрес больницы";
        }

        // default constructor
        // public Doctor() { }

        public Doctor(string firstName, string middleName, string lastName, string position)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Position = position;

            DoctorsCount++;
        }

    #endregion


    #region Methods

        public void PrintBio()
        {
            Console.WriteLine(
                $"Врач {this.FirstName} {this.MiddleName} {this.LastName} имеет специальность \"{this.Position}\" и работает в кабинете №{this.CabinetNumber}."
            );
            Console.WriteLine($"Он уже вылечил {this.PatientNumber} пациентов.");
        }

        public void GoToWork()
        {
            Console.WriteLine($"Врач {this.LastName} пошел на работу...");
            this.PatientNumber++;
        }

        public static void HowManyDoctors()
        {
            Console.WriteLine($"Всего врачей в больнице: {DoctorsCount}");
        }

    #endregion
    }
}
