using InvoiceApp.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InvoiceApp.CIphers
{
    public class WeirdCipher : Cipher
    {
        public WeirdCipher(string data) : base(data)
        {
            _data = data;
        }

        public override string CipherInvoice()
        {
            return _data.Replace('A', '$').Replace('H', '#');
        }
    }
}
