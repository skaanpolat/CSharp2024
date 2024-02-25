using Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        ProductManager productManager = new ProductManager();


        customerManager.Add();
        customerManager.Update();

        productManager.Add();
        productManager.Update();


        Customer customer = new Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.FirstName = "Engin";
        customer.LastName = "Demiroğ";


        Customer customer2 = new Customer { Id = 2, FirstName = "Derin", LastName = "Demiroğ", City = "İstanbul" };

        Console.WriteLine(customer2.FirstName);

    }


}
