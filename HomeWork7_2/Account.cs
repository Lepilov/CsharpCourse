using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2
{
    public class Account
    {
        public decimal Balance { get; private set; }
        public bool IsOpen { get; private set; }
        public Client OwnerClient { get; private set; }
        public int NumberAccount { get; private set; }

        public Account(Client ownerClient, int numberAccount)
        {
            Open();
            Balance = 0;
            OwnerClient = ownerClient;
            NumberAccount = numberAccount;
        }

        public void Open()
        {
            IsOpen = true;
            Console.WriteLine($"Открыт новый счет! № счета : {NumberAccount}");
        }

        public void Close()
        {
            IsOpen = false;
            Console.WriteLine($"Счет №{NumberAccount} закрыт. Итоговая сумма : {Balance}");
        }

        public void DecreaseMoney(decimal value)
        {
            if (Balance < value)
            {
                Console.WriteLine($"Не достаточно средств на счете №{NumberAccount}");
            }
            else
            {
                Balance -= value;
                Console.WriteLine($"Сумма {value} снята со счета №{NumberAccount}. Осталось на счете {Balance}");
            }
        }

        public void IncreaseMoney(decimal value)
        {
            Balance += value;
            Console.WriteLine($"На счет {NumberAccount} поступило : {Balance}");
        }
    }
}
