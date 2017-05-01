namespace HomeWork7_2
{
    public abstract class OperationMoney : Operation
    {
        public decimal DeltaMoney { get; private set; }
        public OperationMoney(Employee creator, Account createAnAccountOperation, decimal deltaMoney) 
            : base(creator, createAnAccountOperation)
        {
            DeltaMoney = deltaMoney;
        }
    }
}
