using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork2_3
{
    class ItemRemovingEventArgs<T> : ItemRemovedEventArgs<T>
    {
        public bool Cancel { get; set; }
    }
}
