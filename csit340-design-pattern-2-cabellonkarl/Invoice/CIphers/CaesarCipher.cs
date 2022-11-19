using InvoiceApp.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.CIphers
{
    public class CaesarCipher : Cipher
    {
        public CaesarCipher(string data) : base(data)
        {
            _data = data;
        }
        
        public override string CipherInvoice()
        {
            const int key = 4;
            string output = string.Empty;

            foreach (char ch in _data)
            {
                if (!char.IsLetter(ch))
                {

                    output += ch;
                }

                char d = char.IsUpper(ch) ? 'A' : 'a';
                output += (char)((ch + key - d) % 26 + d);
            }

            return output;
        }
    }
}
