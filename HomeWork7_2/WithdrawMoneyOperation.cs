namespace HomeWork7_2
{
    public class WithdrawMoneyOperation : OperationMoney
    {
        public WithdrawMoneyOperation(Employee creator, Account createAnAccountOperation, decimal deltaMoney) 
            : base(creator, createAnAccountOperation, deltaMoney)
        {
        }

        public override void Apply()
        {
            CreateAnAccountOperation.DecreaseMoney(DeltaMoney);
        }
    }
}
