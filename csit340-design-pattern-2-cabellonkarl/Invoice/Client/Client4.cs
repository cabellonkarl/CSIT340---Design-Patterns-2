using InvoiceApp.CIphers;
using InvoiceApp.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Client
{
    public class Client4 : AClient
    {
        public override Cipher Cipher()
        {
            return new NoCipher(Invoice().CreateInvoice());
        }

        public override Invoice Invoice()
        {
            Invoice invoice = new InvoiceWithHeaderFooterDecorator(base.Invoice());


            invoice.FontColor = new DisplayRedColorBehavior();
            invoice.FontColor.DisplayInvoice();

            return invoice;
        }
    }
}
