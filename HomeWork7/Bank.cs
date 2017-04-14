using System;

namespace HomeWork7
{
    public class Bank : Accaunt
    {
        public string Name { get; private set; }

        public Bank(string name)
        {
            this.Name = name;
        }

        Accaunt[] accaunts;

        public void Open(AccountType accountType, decimal sum)
        {
            Accaunt newAccaunt = null;

            switch (accountType)
            {
                case AccountType.Ordinary:
                    newAccaunt = new DemandAccount(sum, 1);
                    break;
                case AccountType.Deposit:
                    newAccaunt = new DepositAccount(sum, 40);
                    break;
            }

            if (newAccaunt == null)
            {
                Console.WriteLine("Ошибка создания счета");
            }

            if (accaunts == null)
            {
                accaunts = new Accaunt[]{newAccaunt};
            }
            else
            {
                Accaunt[] tempAccaunts = new Accaunt[accaunts.Length + 1];
                for (int i = 0; i < accaunts.Length; i++)
                {
                    tempAccaunts[i] = accaunts[i];
                }
                tempAccaunts[tempAccaunts.Length - 1] = newAccaunt;
                accaunts = tempAccaunts;
            }

            newAccaunt.Open();
        }

        public void Put(decimal sum, int id)
        {
            Accaunt accaunt = FindAccount(id);
            if (accaunt == null)
            {
                Console.WriteLine("Счет не найден");
            }
            accaunt.Put(sum);
        }

        public void Withdraw(decimal sum, int id)
        {
            Accaunt accaunt = FindAccount(id);
            if (accaunt == null)
            {
                Console.WriteLine("Счет не найден");
            }
            accaunt.Withdraw(sum);
        }

        public void Close(int id)
        {
            int index;
            Accaunt accaunt = FindAccount(id, out index);
            if (accaunt == null)
            {
                Console.WriteLine("Счет не найден");
            }

            accaunt.Close();

            if (accaunts.Length <= 1)
            {
                accaunts = null;
            }
            else
            {
                Accaunt[] tempAccaunt = new Accaunt[accaunts.Length - 1];
                for (int i = 0, j = 0; i < accaunts.Length; i++)
                {
                    if (i != index)
                    {
                        tempAccaunt[j++] = accaunts[i];
                    }
                    accaunts = tempAccaunt;
                }
            }
        }

        public void CalculatePercentage()
        {
            if (accaunts == null)
            {
                return;
            }
            for (int i = 0; i < accaunts.Length; i++)
            {
                Accaunt accaunt = accaunts[i];
                accaunt.IncrementDays();
                accaunt.Calculate();
            }
        }

        public Accaunt FindAccount(int id)
        {
            for (int i = 0; i < accaunts.Length; i++)
            {
                if (accaunts[i].Id == id)
                    return accaunts[i];
            }
            return null;
        }

        public Accaunt FindAccount(int id, out int index)
        {
            for (int i = 0; i < accaunts.Length; i++)
            {
                if (accaunts[i].Id == id)
                {
                    index = i;
                    return accaunts[i];
                }
            }
            index = -1;
            return null;
        }
    }

    public enum AccountType
    {
        Ordinary,
        Deposit
    }
}