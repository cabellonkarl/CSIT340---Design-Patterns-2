using InvoiceApp.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.CIphers
{
    /// <summary>
    /// [Cipher]
    /// <insert an abstract class for CipherInvoice where you distiguish if its a Caesar Weird or A No Cipher 
    /// >
    /// </summary
    public abstract class Cipher 
    {
        protected string _data;
        public Cipher(string data)
        {
            _data = data; 
        }

        public abstract string CipherInvoice();
    }
}
