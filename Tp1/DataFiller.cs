using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1
{
    public abstract class DataFiller
    {
        DataContext context;
        internal abstract void fill(DataContext context);
    }
}
