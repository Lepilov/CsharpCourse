using System;

namespace HomeWork7
{
    public class DemandAccount : Accaunt
    {
        public DemandAccount(decimal sum, int percentage) : base(sum, percentage)
        {
        }

        protected internal override void Open()
        {
            Console.WriteLine("Открыт новый счет до востребования! № счета : " + this.id);
        }
    }
}