using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //public void CheckOperationPermission(OperationTypes operationTypes)
        //{
        //    if (!CurrentEmployee.AllowedOperationTypes.HasFlag(operationTypes))
        //    {
        //        Console.WriteLine("У текущего сотрудника нет прав доступа на операцию");
        //    }
        //}

        public void PutMoneyOperation(int id, decimal deltaMoney)
        {
            Account accounts = FindAccount(id);
            if (accounts == null)
            {
                Console.WriteLine("Счет не найден!");
            }

            //CheckOperationPermission(OperationTypes.PutMoney);

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

            //CheckOperationPermission(OperationTypes.WithdrawMoney);

            WithdrawMoneyOperation withdrawMoneyOperation = new WithdrawMoneyOperation(CurrentEmployee, accounts, deltaMoney);

            withdrawMoneyOperation.Apply();
            Operations.Add(withdrawMoneyOperation);
        }

        public void AddAccount(Client ownerClient)
        {
            if (ownerClient == CurrentClient)
            {
                return;
            }
            ////CheckOperationPermission(OperationTypes.OpenAccount);    
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

            //CheckOperationPermission(OperationTypes.CloseAccount);

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
    }
}
