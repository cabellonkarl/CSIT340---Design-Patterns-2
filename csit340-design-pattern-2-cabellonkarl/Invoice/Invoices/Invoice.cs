using InvoiceApp.CIphers;
using InvoiceApp.DisplayColorBehavior;

namespace InvoiceApp.Invoices
{
    public class Invoice
    {
        protected string _invoiceData = string.Empty;
        public DisplayBehavior? FontColor { get; set; }

        public string Data { get => _invoiceData; }

        public virtual string CreateInvoice()
        {
            string invoiceData = string.Empty;
            invoiceData += "\n";
            invoiceData += "\tCustomer Name : Jhon Ambrad\n";
            invoiceData += "\tCustomer Address : Apas, Cebu\n";
            invoiceData += "\tOrder No : 696969\n";
            invoiceData += "\tOrder Amount : PHP 5100/- \n";
            invoiceData += "\tOrder Date : 11-11-2022 \n";
            invoiceData += "\n";

            return invoiceData;
        }
        
    }
}
