using InvoiceApp.CIphers;
using InvoiceApp.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Client
{
    public class Client1 : AClient
    {
        public override Cipher Cipher()
        {
            return new CaesarCipher(this.Invoice().CreateInvoice());
        }

        public override Invoice Invoice()
        {
            Invoice invoice = new InvoiceWithHeaderDecorator(base.Invoice());
            return invoice;
        }
    }
}
