using InvoiceApp.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.DisplayColorBehavior
{
    public interface DisplayBehavior
    {
        /// <summary>
        /// [Cipher]
        /// <insert an interface where we can change the font color of the invoice text. I added A green since it was mentioned that can be used in the future.
        /// and A default color to simpley use the concreteclass instead of the base class in calling the Defaultcolor. It is simply white
        /// >
        /// </summary
        public void DisplayInvoice();
    }
}
