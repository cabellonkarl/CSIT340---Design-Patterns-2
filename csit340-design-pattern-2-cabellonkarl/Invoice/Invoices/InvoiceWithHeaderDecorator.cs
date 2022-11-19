using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Invoices
{
    public class InvoiceWithHeaderDecorator : BaseDecoratorInvoice
    {
        public InvoiceWithHeaderDecorator(Invoice invoice) : base(invoice)
        {
            _invoice = invoice;
        }

        public override string CreateInvoice()
        {
            return CreateInvoiceHeader() + _invoice.CreateInvoice();
        }

        private string CreateInvoiceHeader()
        {
            string invoiceData = string.Empty;
            invoiceData += "\n\tBlue Heaven Inc.\n";
            invoiceData += "\tBay Area, NC\n";
            invoiceData += "\t+1 784251485\n\n";

            return invoiceData;
        }
    }
}
