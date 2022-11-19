using InvoiceApp.CIphers;
using InvoiceApp.DisplayColorBehavior;
using InvoiceApp.Invoices;
using InvoiceApp.Client;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;

namespace InvoiceApp
{
    public class InvoiceProcessor
    {
        public void Process(int client)
        {
            Console.WriteLine("Processing invoice...");
            AClient cli;
       
            switch (client)
            {
                case 0:
                    cli = new Client0();
                    break;
                case 1:
                    cli = new Client1();
                    break;
                case 2:
                    cli = new Client2();
                    break;
                case 3:
                    cli = new Client3();
                    break;
                case 4:
                    cli = new Client4();
                    break;
                default:
                    throw new ArgumentException("Invalid client");
            }


            SaveInvoice(cli);
            DisplayInvoice(cli);
        }


        private void DisplayInvoice(AClient cli)
        {
           Console.WriteLine(cli.Invoice().CreateInvoice());
        }
        private void SaveInvoice(AClient cli)
        {
            string data = cli.Cipher().CipherInvoice();
            File.WriteAllText("Invoice.txt", data);

            Console.WriteLine("Invoice data saved!");
        }
    }
}
