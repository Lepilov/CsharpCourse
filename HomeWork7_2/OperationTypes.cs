using System;

namespace HomeWork7_2
{
    [Flags]
    public enum OperationTypes
    {
        None = 0,
        OpenAccount = 0b1,
        CloseAccount = 0b10,
        PutMoney = 0b100,
        WithdrawMoney = 0b1000
    }
}
