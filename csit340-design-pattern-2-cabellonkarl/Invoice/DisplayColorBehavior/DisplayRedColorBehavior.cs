using InvoiceApp.DisplayColorBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp
{
    internal class DisplayRedColorBehavior : DisplayBehavior
    {
        public void DisplayInvoice()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
