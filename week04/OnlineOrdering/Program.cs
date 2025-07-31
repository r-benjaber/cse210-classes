using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address adr1 = new Address("1280W 820N", "Lehi", "Utah", "United Sates");
        Customer cus1 = new Customer("Robin Robinson", adr1);
        Order ord1 = new Order(cus1);
        Product or1Prod1 = new Product("Letuce", "2165421564", (float)1.75, 3);
        ord1.AddProduct(or1Prod1);
        Product or1Prod2 = new Product("Garlick", "5751587934", (float)0.98, 5);
        ord1.AddProduct(or1Prod2);
        Product or1Prod3 = new Product("PlayStation 5", "8764842581", (float)499.99, 1);
        ord1.AddProduct(or1Prod3);
        ord1.DisplayTicket();

        Address adr2 = new Address("Av Brasilia Esq. España", "Asunción", "Asunción", "Paraguay");
        Customer cus2 = new Customer("Juan Alvarenga", adr2);
        Order odr2 = new Order(cus2);
        Product or2Prod1 = new Product("Maple Syrup 500ml", "7896541258", (float)12.5, 1);
        odr2.AddProduct(or2Prod1);
        Product or2Prod2 = new Product("Frozen Waffles", "9651478465", (float)2.30, 3);
        odr2.AddProduct(or2Prod2);
        odr2.DisplayTicket();
    }
}