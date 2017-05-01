namespace HomeWork7_2
{
    public class Employee : Person
    {
        public OperationTypes AllowedOperationTypes { get; private set; }

        public Employee(int number, string name, OperationTypes allowedOperationTypes) 
            : base(number, name)
        {
            AllowedOperationTypes = allowedOperationTypes;
        }
    }
}
