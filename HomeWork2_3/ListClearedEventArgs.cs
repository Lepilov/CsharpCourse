﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_3
{
    class ListClearedEventArgs<T> : EventArgs
    {
        public T Item { get; set; }
    }
}
