using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_3
{
    class ItemAddedEventArgs<T> : EventArgs
    {
        public T Item { get; set; }
    }
}
