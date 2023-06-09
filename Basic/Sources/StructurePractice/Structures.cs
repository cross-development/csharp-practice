namespace csharp_practice.Sources.StructurePractice
{
    public class Structures
    {
        public static void Run()
        {
            BankAccount ba = new BankAccount(1001, 10);
            ba.Withdraw(10);
        }
    }

    public struct BankAccount
    {
        private int accountNumber;
        private decimal money;

        public BankAccount(int accountNumber, decimal money)
        {
            this.accountNumber = accountNumber;
            this.money = money;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= this.money)
            {
                money -= amount;
            }
        }
    }
}

// Отличия структур от классов

// 1. структуры работают быстрее чем классы (это тип значения, а классы - ссылочный тип);
// 2. структуры не могут иметь конструктора без параметров
// 3. структуры не могут наследоваться от других структур или классов
// 4. структура не может служить базовой для другой структуры или класса
// 5. структура может наследоваться от интерфейсов
// 6. структуру нельзя сделать абстрактной и она всегда неявно запечатана (sealed)
// 7. структуру нельзя сделать protected (только public или private)
