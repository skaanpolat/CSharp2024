internal class Program
{
    //Interface newlenemez
    private static void Main(string[] args)
    {
        IPersonManager customerManager = new CustomerManager();

        IPersonManager employeeManager = new EmployeeManager();


        ProjectManager projectManager = new ProjectManager();

        projectManager.Add(new InternManager());
    }
}

interface IPersonManager

//Unimplemented Operation
{
    void Add();
    void Update();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        //Müşteri ekleme kodları

        Console.WriteLine("Müşteri eklendi!");
    }

    public void Update()
    {
        //Müşteri güncelleme kodları
        Console.WriteLine("Müşteri güncellendi!");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer Eklendi!");
    }
    public void Update()
    {
        Console.WriteLine("Stajyer güncellendi!");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //Personel ekleme kodları
        Console.WriteLine("Personel eklendi!");
    }

    public void Update()
    {
        Console.WriteLine("Personel güncellendi!");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}
