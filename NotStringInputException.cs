using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker
{
    public class NotStringInputException : FormatException
    {
        public NotStringInputException() : base() { }
        public NotStringInputException(string message) : base(message) { }
    }
}
