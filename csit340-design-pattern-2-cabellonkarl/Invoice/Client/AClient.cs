using InvoiceApp.CIphers;
using InvoiceApp.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Client
{
    /// <summary>
    /// [Client]
    /// <insert an abstract class for Clients it is to shorten the switch case and make it more presentable in the InvoiceProcessor
    /// this class has Invoice and Cipher classes.
    /// >
    /// </summary
    public abstract class AClient
    {
        public virtual Invoice Invoice()
        {
            return new Invoice();
        }

        public abstract Cipher Cipher();
    }
}
