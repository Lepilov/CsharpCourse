using System;

namespace HomeWork7
{
    public abstract class Accaunt : IAccount 
    {
        protected int id;
        private static int count = 0;
        protected decimal sum;
        protected int percentage;
        protected int days = 0;

        public decimal CurrentSum { get { return sum; } }

        public int Percentage { get { return percentage; } }

        public int Id { get { return id; } }

        public Accaunt()
        {
        }

        public Accaunt(decimal sum, int percentage)
        {
            this.sum = sum;
            this.percentage = percentage;
            id = ++count;
        }

        public virtual void Put(decimal sum)
        {
            this.sum += sum;
            Console.Write("На счет поступило : " + sum); 
        }

        public virtual decimal Withdraw(decimal sum)
        {
            decimal result = 0;
            if (sum <= this.sum)
            {
                this.sum -= sum;
                result = sum;
                Console.WriteLine("Сумма " + sum + " снята со счета " + id);
            }
            else
            {
                Console.WriteLine("Недостаточно денег на счете : " + id);
            }

            return result;
        }

        protected internal virtual void Open()
        {
            Console.WriteLine("Открыт новый счет! № счета : " + this.id);
        }

        protected internal virtual void Close()
        {
            Console.WriteLine("Счет " + id + " закрыт. Итоговая сумма : " + CurrentSum);
        }

        protected internal void IncrementDays()
        {
            days++;
        }

        protected internal virtual void Calculate()
        {
            decimal increment = sum * percentage / 100;
            sum = sum + increment;
            Console.WriteLine("Начислины проценты в размере : " + increment);
        }
    }
}