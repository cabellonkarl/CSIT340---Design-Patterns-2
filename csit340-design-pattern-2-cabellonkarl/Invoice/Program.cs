using InvoiceApp;

Console.Write("Generate invoice for client: ");
var client = Convert.ToInt32(Console.ReadLine());

var processor = new InvoiceProcessor();
processor.Process(client);



