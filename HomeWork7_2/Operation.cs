namespace HomeWork7_2
{
    public abstract class Operation
    {
        public Employee Creator { get; private set; }
        public Account CreateAnAccountOperation { get; private set; }

        public Operation(Employee creator, Account createAnAccountOperation)
        {
            Creator = creator;
            CreateAnAccountOperation = createAnAccountOperation;
        }

        public abstract void Apply();
    }
}
