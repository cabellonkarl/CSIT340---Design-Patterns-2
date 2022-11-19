using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Invoices
{
    public class BaseDecoratorInvoice : Invoice
    {
        protected Invoice _invoice;
        /// <summary>
        /// [BaseDecorator]
        /// <insert a Decorator Pattern was used here so that I can dynamically change behavior without affecting the behavior of the other 
        /// objects from the same class. Basically a wrapper
        /// >
        /// </summary

        public BaseDecoratorInvoice(Invoice invoice)
        {
            _invoice = invoice;
        }

        public override string CreateInvoice()
        {
           return _invoice.CreateInvoice();
        }
    }
}
