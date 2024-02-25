internal class Program
{
    private static void Main(string[] args)
    {

        IWorker[] workers = new IWorker[3]
        {

            new Manager(),
            new Worker(),
            new Robot()

        };

        IEat[] eats = new IEat[2]
        {
            new Worker(),
            new Manager(),
        };

        foreach (var worker in workers)
        {
            worker.Work();
        }

        foreach (var worker in eats)
        {
            worker.Eat();
        }

    }
}

interface IWorker
{

    void Work();

}

interface IEat
{

    void Eat();

}
interface IGetSalary
{
    void GetSalary();

}

interface IRobot
{
    void Work();

}

class Manager : IWorker, IEat, IGetSalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Worker : IWorker,IEat,IGetSalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}