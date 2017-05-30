using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_3
{
    class ItemAddingEventArgs<T> : ItemAddedEventArgs<T>
    {
        public bool Cancel { get; set; }
    }
}
