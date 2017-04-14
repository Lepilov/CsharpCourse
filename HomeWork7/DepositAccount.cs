using System;

namespace HomeWork7
{
    public class DepositAccount : Accaunt
    {
        public DepositAccount(decimal sum, int percentage) : base(sum, percentage)
        {
        }

        protected internal override void Open()
        {
            Console.WriteLine("Открыт новый депозитный счет!Id счета: " + this.id);
        }

        public override void Put(decimal sum)
        {
            if (days % 30 == 0)
            {
                base.Put(sum);
            }
            else
            {
                Console.WriteLine("На счет можно положить только после 30-ти дневного периода");
            }
        }

        public override decimal Withdraw(decimal sum)
        {
            if (days % 30 == 0)
            {
                return base.Withdraw(sum);
            }
            else
            {
                Console.WriteLine("Вывести средства можно только после 30-ти дневного периода");
            }

            return 0;
        }

        protected internal override void Calculate()
        {
            if (days % 30 == 0)
            {
                base.Calculate();
            }
        }
    }
}