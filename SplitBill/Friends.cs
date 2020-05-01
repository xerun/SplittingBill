using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter
{
    public class Friends
    {
        public int Friend { get; private set; }
        public decimal Amount { get; private set; }

        public Friends(int f, decimal a)
        {
            Friend = f;
            Amount = a;
        }
    }
}
