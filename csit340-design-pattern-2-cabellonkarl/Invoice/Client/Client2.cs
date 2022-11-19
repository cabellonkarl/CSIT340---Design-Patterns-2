using InvoiceApp.CIphers;
using InvoiceApp.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Client
{
    internal class Client2 : AClient
    {
        public override Cipher Cipher()
        {
            return new WeirdCipher(Invoice().CreateInvoice());
        }

        public override Invoice Invoice()
        {
            Invoice invoice = new InvoiceWithFooterDecorator(base.Invoice());
            return invoice;
        }
    }
}
