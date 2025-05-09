using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker
{
    public class NegativeAmountException : Exception
    {
        public NegativeAmountException() : base() { }
        public NegativeAmountException(string message) : base(message) { }
    }
}
