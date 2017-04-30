using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2
{
    public class OpenOperation : Operation
    {
        public OpenOperation(Employee creator, Account createAnAccountOperation) 
            : base(creator, createAnAccountOperation)
        {
        }

        public override void Apply()
        {
            CreateAnAccountOperation.Open();
        }
    }
}
