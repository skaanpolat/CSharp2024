using Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        //InterfacesIntro();
        //Demo2();

        ICustomerDal[] customerDals = new ICustomerDal[3]
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
            new MySQLCustomerDal()
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }



    }

    private static void Demo2()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new OracleCustomerDal());
    }

    private static void InterfacesIntro()
    {
        PersonManager personManager = new PersonManager();

        Customer customer = new Customer
        {
            Id = 2,
            FirstName = "Engin",
            LastName = "Demiroğ",
            Adress = "Ankara"
        };


        Student student = new Student
        {
            Id = 1,
            FirstName = "Derin",
            LastName = "Demiroğ",
            Department = "Bilgisayar Mühendisliği"
        };
        Worker worker = new Worker
        {
            Id = 1,
            FirstName = "Salih",
            LastName = "Demiroğ",
            Department = "Üretim"
        };

        personManager.Add(customer);
        personManager.Add(student);
        personManager.Add(worker);
    }
}

public interface IPerson
{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

class Customer : IPerson
{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Adress { get; set; }
}

class Student : IPerson
{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
}
class Worker : IPerson
{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
}

public class PersonManager
{

    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName + " eklendi!");
    }
}
