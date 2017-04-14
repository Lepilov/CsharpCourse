using System;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("БАНК");
            bool temp = true;
            while (temp)
            {
                Console.WriteLine(bank.Name);
                Console.WriteLine("1. Открыть счет \t 2. Вывести средства  \t 3. Добавить на счет");
                Console.WriteLine("4. Закрыть счет \t 5. Пропустить день \t 6. Выйти из программы");
                Console.Write("Введите номер пункта : ");
                int command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        OpenAccount(bank);
                        break;
                    case 2:
                        Withdraw(bank);
                        break;
                    case 3:
                        Put(bank);
                        break;
                    case 4:
                        CloseAccount(bank);
                        break;
                    case 5:
                        break;
                    case 6:
                        temp = false;
                        continue;
                }
                bank.CalculatePercentage();
            }

            Console.Read();
        }

        private static void OpenAccount(Bank bank)
        {
            Console.Write("Укажите сумму для создания счета : ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Выберите тип счета: 1. До востребования 2. Депозит : ");
            AccountType accountType;
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 2)
            {
                accountType = AccountType.Deposit;
            }
            else
            {
                accountType = AccountType.Ordinary;
            }

            bank.Open(accountType, sum);
        }

        private static void Withdraw(Bank bank)
        {
            Console.Write("Укажите сумму для вывода со счета : ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите № счета : ");
            int id = Convert.ToInt32(Console.ReadLine());

            bank.Withdraw(sum, id);
        }

        private static void Put(Bank bank)
        {
            Console.Write("Укажите сумму, чтобы положить на счет : ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите № счета : ");
            int id = Convert.ToInt32(Console.ReadLine());

            bank.Put(sum, id);
        }

        private static void CloseAccount(Bank bank)
        {
            Console.Write("Введите № счета, который надо закрыть : ");
            int id = Convert.ToInt32(Console.ReadLine());

            bank.Close(id);
        }
    }
}
