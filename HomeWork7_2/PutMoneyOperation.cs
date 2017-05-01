using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HomeWork7_2
{
    public class PutMoneyOperation : OperationMoney
    {
        public PutMoneyOperation(Employee creator, Account createAnAccountOperation, decimal deltaMoney) 
            : base(creator, createAnAccountOperation, deltaMoney)
        {
        }

        public override void Apply()
        {
            CreateAnAccountOperation.IncreaseMoney(DeltaMoney);
        }
    }
}
