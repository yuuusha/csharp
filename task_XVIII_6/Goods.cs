using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    abstract public class Goods
    {
        abstract internal void Show();
        abstract internal bool isExpired(DateTime curDate);
    }
}
