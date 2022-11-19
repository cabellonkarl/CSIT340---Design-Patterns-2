using InvoiceApp.CIphers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InvoiceApp
{
    internal class NoCipher : Cipher
    {
        public NoCipher(string data) : base(data)
        {
            _data = data;
        }

        public override string CipherInvoice()
        {
            return _data;
        }
    }
}
