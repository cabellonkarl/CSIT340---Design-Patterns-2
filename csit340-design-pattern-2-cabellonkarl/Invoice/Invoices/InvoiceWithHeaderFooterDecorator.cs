using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Invoices
{
    public class InvoiceWithHeaderFooterDecorator : BaseDecoratorInvoice
    {
        public InvoiceWithHeaderFooterDecorator(Invoice invoice) : base(invoice)
        {
            _invoice = invoice;
        }

        public override string CreateInvoice()
        {
            return CreateInvoiceWithHeaderFooter() + _invoice.CreateInvoice();
        }

        private string CreateInvoiceWithHeaderFooter()
        {
            string invoiceData = string.Empty;
            invoiceData += "\n\tBlue Heaven Inc.\n";
            invoiceData += "\tBay Area, NC\n";
            invoiceData += "\t+1 784251485\n\n";
            invoiceData += "\n";
            invoiceData += "\tCustomer Name : Jhon Ambrad\n";
            invoiceData += "\tCustomer Address : Apas, Cebu\n";
            invoiceData += "\tOrder No : 696969\n";
            invoiceData += "\tOrder Amount : PHP 5100/- \n";
            invoiceData += "\tOrder Date : 11-11-2022 \n";
            invoiceData += "\n";
            invoiceData += "\n\tCopyright @ 2020.All rights reserved\n";

            return invoiceData;
        }
    }
}
