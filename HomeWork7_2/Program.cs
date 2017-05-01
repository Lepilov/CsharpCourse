using System;

namespace HomeWork7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            bool temp = true;
            while(temp)
            {
                Console.WriteLine(" Добро пожаловать в Банк ");
                Console.Write("Выберите действие: \"1\" - работа с сотрудниками, \"2\" - работа с клиентами, \"0\" - Выход: ");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Работа с сотрудниками");
                        Console.Write("Выберите действие: \"1\" - добавить нового сотрудника, \"2\" - поиск сотрудника по имени, \"3\" - получение списка всех сотрудников : ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        switch (number1)
                        {
                            case 1:
                                Console.WriteLine("Пожалуйста, введите имя сотрудника!");
                                NewEmployee(bank);
                                break;
                            case 2:
                                bank.FindEmployeeByName();
                                break;
                            case 3:
                                bank.ListOfBankEmployees();
                                break;
                            default:
                                Console.WriteLine("Выбрано некорректное действие!");
                                break;

                        }
                        break;
                    case 2:
                        Console.WriteLine("Работа с клиентами");
                        Console.Write("Выберите действие: \"1\" - обслужить клиента, \"2\" - поиск клиента по имени, \"3\" - получение списка всех клиентов: ");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        switch (number2)
                        {
                            case 1:
                                Console.WriteLine("Пожалуйста, введите имя клиента!");
                                NewClient(bank);
                                break;
                            case 2:
                                bank.FindCustomerByName();
                                break;
                            case 3:
                                bank.PrintAllClients();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 0:
                        temp = false;
                        continue;
                    default:
                        Console.WriteLine("Такой команды нет!");
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
            int choiceofPosition = Int32.Parse(Console.ReadLine());
            switch (choiceofPosition)
            {
                case 1:
                    bank.CreateEmployee(name, OperationTypes.PutMoney | OperationTypes.WithdrawMoney);
                    Console.WriteLine($"Вы устроились в Банк ваше имя : {name}. Вы можете произвести операцию положить/снять деньги");;
                    break;
                case 2:
                    bank.CreateEmployee(name, OperationTypes.OpenAccount | OperationTypes.CloseAccount);
                    Console.WriteLine($"Вы устроились в Банк ваше имя : {name}. Вы можете открывать/закрывать счет");
                    break;
                default:
                    Console.WriteLine("Такой команды не существует!");
                    break;
            }
        }

        private static void NewClient(Bank bank)
        {
            Console.Write("Введите имя : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Добро пожаловать : {name}");
            bank.CreateAccount(bank.CreateClient(name));
            bool temp = true;
            while (temp)
            {
                Console.WriteLine("Что бы вы хотели сделать :");
                Console.WriteLine("Положить деньги на счет - \"1\" \t Снять деньги со счета - \"2\"");
                Console.WriteLine("Открыть новый счет - \"3\" \t Закрыть счет - \"4\"");
                Console.WriteLine("Выход - \"0\"");
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
                    case 0:
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
            bank.AddAccount(bank.CurrentClient);
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
