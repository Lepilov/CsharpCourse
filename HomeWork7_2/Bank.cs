using System;
using System.Collections.Generic;

namespace HomeWork7_2
{
    public class Bank
    {
        public List<Employee> Employees { get; private set; }
        public List<Client> Clients { get; private set; }
        public List<Account> Accounts { get; private set; }
        public List<Operation> Operations { get; private set; }
        public Employee CurrentEmployee { get; private set; }
        public Client CurrentClient { get; private set; }

        public Bank()
        {
            Employees = new List<Employee>();
            Clients = new List<Client>();
            Accounts = new List<Account>();
            Operations = new List<Operation>();
        }

        public Employee CreateEmployee(string name, OperationTypes allowedOperationTypes)
        {
            var newEmployee = new Employee(Employees.Count, name, allowedOperationTypes);
            Employees.Add(newEmployee);
            return newEmployee;
        }

        public Client CreateClient(string name)
        {
            var newClient = new Client(Clients.Count, name);
            Clients.Add(newClient);
            return newClient;
        }

        public void ListOfBankEmployees()
        {
            Console.WriteLine($"Список сотрудников :");
            if (Employees.Count == 0)
            {
                Console.WriteLine("Список сотрудников пуст!");
            }
            foreach (Employee listEmployees in Employees)
            {
                if (listEmployees.AllowedOperationTypes.HasFlag(OperationTypes.OpenAccount) || listEmployees.AllowedOperationTypes.HasFlag(OperationTypes.CloseAccount))
                {                   
                    Console.WriteLine($"{listEmployees.Number}, {listEmployees.Name} право доступа открыть/закрыть счет");
                }
                if (listEmployees.AllowedOperationTypes.HasFlag(OperationTypes.PutMoney) || listEmployees.AllowedOperationTypes.HasFlag(OperationTypes.WithdrawMoney))
                {
                    Console.WriteLine($"{listEmployees.Number}, {listEmployees.Name} право доступа положить/снять деньги");
                }
            }
        }

        public Account CreateAccount(Client ownerClient)
        {
            if (ownerClient == null)
            {
                return null;
            }

            Account newAccount = new Account(ownerClient, Accounts.Count);
            Accounts.Add(newAccount);
            return newAccount;
        }

        public void PutMoneyOperation(int id, decimal deltaMoney)
        {
            Account accounts = FindAccount(id);
            if (accounts == null)
            {
                Console.WriteLine("Счет не найден!");
            }

            PutMoneyOperation putMoneyOperation = new PutMoneyOperation(CurrentEmployee, accounts, deltaMoney);

            putMoneyOperation.Apply();
            Operations.Add(putMoneyOperation);
        }

        public void WithdrawMoneyOperation(int id, decimal deltaMoney)
        {
            Account accounts = FindAccount(id);
            if (accounts == null)
            {
                Console.WriteLine("Счет не найден!");
            }

            WithdrawMoneyOperation withdrawMoneyOperation = new WithdrawMoneyOperation(CurrentEmployee, accounts, deltaMoney);

            withdrawMoneyOperation.Apply();
            Operations.Add(withdrawMoneyOperation);
        }

        public void AddAccount(Client ownerClient)
        {
            if (ownerClient == null)
            {
                Account newAccount = new Account(CurrentClient, Accounts.Count);
                newAccount.Open();
                Accounts.Add(newAccount);
            }
            
            CreateAccount(ownerClient);
        }

        public void CloseAccount(int id)
        {
            int index;
            Account account = FindAccount(id, out index);
            if (account == null)
            {
                Console.WriteLine("Счет не найден");
            }

            account.Close();
            Accounts.Remove(account);
        }

        public Account FindAccount(int id)
        {
            foreach(Account listAccount in Accounts)
            {
                if (listAccount.NumberAccount == id)
                    return listAccount;
            }

            return null;
        }

        public Account FindAccount(int id, out int index)
        {
            foreach (Account listAccount in Accounts)
            {
                if (listAccount.NumberAccount == id)
                {
                    index = listAccount.NumberAccount;
                    return listAccount;
                }
            }

            index = -1;
            return null;
        }

        public Client FindClient(string name)
        {
            foreach (Client listClient in Clients)
            {
                if (listClient.Name == name)
                {
                    return listClient;
                }
            }

            return null;
        }

        public void FindEmployeeByName()
        {
            Console.Write("Введите имя сотрудника : ");
            string employeeName = Console.ReadLine();
            bool isEmployeeFound = false;
            foreach (Employee employee in Employees)
            {
                if (employee.Name == employeeName)
                {
                    Console.WriteLine("Сотрудник " + employee.Name + " найден!");
                    isEmployeeFound = true;
                    break;
                }
            }

            if (!isEmployeeFound)
            {
                Console.WriteLine("Сотрудник " + employeeName + " не найден!");
            }
        }

        public void FindCustomerByName()
        {
            Console.Write("Введите имя клиента : ");
            string clientName = Console.ReadLine();
            bool isCustomerFound = false;
            foreach (Client client in Clients)
            {
                if (client.Name == clientName)
                {
                    Console.WriteLine($"Клиент {client.Name} найден!");
                    isCustomerFound = true;
                    break;
                }
            }

            if (!isCustomerFound)
            {
                Console.WriteLine($"Клиент {clientName} не найден!");
            }
        }

        public void PrintAllClients()
        {
            if (Clients.Count == 0)
            {
                Console.WriteLine("Ни одного клиента не найдено!");
            }
            else
            {
                Console.WriteLine("Список наших клиентов : ");
                foreach (Client clientName in Clients)
                {
                    Console.WriteLine(clientName.Name);
                }
            }
        }
    }
}
