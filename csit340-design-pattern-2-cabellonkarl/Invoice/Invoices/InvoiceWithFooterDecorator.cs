using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Invoices
{
    public class InvoiceWithFooterDecorator : BaseDecoratorInvoice
    {
        public InvoiceWithFooterDecorator(Invoice invoice) : base(invoice)
        {
            _invoice = invoice;
        }

        public override string CreateInvoice()
        {
            return _invoice.CreateInvoice() + CreateInvoiceFooter();
        }

        private string CreateInvoiceFooter()
        {
            string invoiceData = string.Empty;
            invoiceData += "\n\tCopyright @ 2020.All rights reserved\n";
            return invoiceData;
        }
    }
}
