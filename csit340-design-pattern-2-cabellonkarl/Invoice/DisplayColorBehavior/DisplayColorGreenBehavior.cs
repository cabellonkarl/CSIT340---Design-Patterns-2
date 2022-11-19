using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.DisplayColorBehavior
{
    internal class DisplayColorGreenBehavior : DisplayBehavior
    {
        public void DisplayInvoice()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
