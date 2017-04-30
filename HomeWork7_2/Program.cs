using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            bool temp = true;
            while (temp)
            {
                Console.WriteLine("Если вы хотите устроиться на работу нажмите : \"1\"");
                Console.WriteLine("Если вы новый клиент банка нажмите : \"2\"");
                Console.WriteLine("Список сотрудников банка : \"3\"");
                Console.WriteLine("Для выхода нажмите : \"6\"");
                int choiceofPosition = Convert.ToInt32(Console.ReadLine());
                switch (choiceofPosition)
                {
                    case 1:
                        NewEmployee(bank);
                        break;
                    case 2:
                        NewClient(bank);
                        break;
                    case 3:
                        bank.ListOfBankEmployees();
                        break;
                    case 6:
                        temp = false;
                        continue;
                    default:
                        Console.WriteLine("Такой команды не существует!");
                        break;
                }
            }
            
            Console.Read();
        }

        private static void NewEmployee(Bank bank)
        {
            Console.Write("Введите имя : ");
            string name = Console.ReadLine();
            Console.WriteLine("Кем вы хотите устроиться ?");
            Console.WriteLine("Если вы хотите работать \" кассиром \" то нажмите : \"1\" ");
            Console.WriteLine("Если вы хотите работать \" операционистом \" то нажмите : \"2\" ");
            //OperationTypes allowedOperationTypes;
            int choiceofPosition = Int32.Parse(Console.ReadLine());
            switch (choiceofPosition)
            {
                case 1:
                    bank.CreateEmployee(name, OperationTypes.PutMoney | OperationTypes.WithdrawMoney);
                    Console.WriteLine($"Вы устроились в Банк ваше имя : {name}. Вы можете произвести операцию положить/снять деньги");
                    //allowedOperationTypes = OperationTypes.PutMoney | OperationTypes.WithdrawMoney;
                    break;
                case 2:
                    bank.CreateEmployee(name, OperationTypes.OpenAccount | OperationTypes.CloseAccount);
                    Console.WriteLine($"Вы устроились в Банк ваше имя : {name}. Вы можете открывать/закрывать счет");
                    //allowedOperationTypes = OperationTypes.OpenAccount | OperationTypes.CloseAccount;
                    break;
                default:
                    Console.WriteLine("Такой команды не существует!");
                    break;
            }
        }

        private static void NewClient(Bank bank)
        {
            Console.WriteLine("Введите имя : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Добро пожаловать : {name}");
            bank.CreateAccount(bank.CreateClient(name));
            bank.CreateAccount(bank.CurrentClient);
            bool temp = true;
            while (temp)
            {
                Console.WriteLine("Что бы вы хотели сделать :");
                Console.WriteLine("Положить деньги на счет - \"1\" \t Снять деньги со счета - \"2\"");
                Console.WriteLine("Открыть новый счет - \"3\" \t Закрыть счет - \"4\"");
                Console.WriteLine("Выход - \"5\"");
                Console.Write("Введите операцию :");
                int choiceofPosition = Convert.ToInt32(Console.ReadLine());
                switch (choiceofPosition)
                {
                    case 1:
                        ToPutMoneyIntoTheAccount(bank);
                        break;
                    case 2:
                        WithdrawMoneyFromTheAccount(bank);
                        break;
                    case 3:
                        AddAccount(bank);
                        break;
                    case 4:
                        CloseAccount(bank);
                        break;
                    case 5:
                        temp = false;
                        continue;
                    default:
                        Console.WriteLine("Такой команды не существует!");
                        break;
                }
            }
            
        }

        private static void AddAccount(Bank bank)
        {
            //bank.AddAccount();
        }

        private static void CloseAccount(Bank bank)
        {
            Console.Write("Введите № счета, который надо закрыть : ");
            int id = Convert.ToInt32(Console.ReadLine());

            bank.CloseAccount(id);
        }

        private static void ToPutMoneyIntoTheAccount(Bank bank)
        {
            Console.Write("Укажите сумму, чтобы положить на счет : ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите № счета :");
            int numberAccount = Convert.ToInt32(Console.ReadLine());

            bank.PutMoneyOperation(numberAccount, sum);
        }

        private static void WithdrawMoneyFromTheAccount(Bank bank)
        {
            Console.Write("Укажите сумму для вывода со счета : ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите № счета : ");
            int numberAccount = Convert.ToInt32(Console.ReadLine());

            bank.WithdrawMoneyOperation(numberAccount, sum);
        }
    }
}
