internal class Program
{
    private static void Main(string[] args)
    {
        List<string> sehirler = new List<string>();
        sehirler.Add("Ankara");
        sehirler.Add("Ankara");
        sehirler.Add("Ankara");
        sehirler.Add("Ankara");
        sehirler.Add("Ankara");
        Console.WriteLine(sehirler.Count);

        myList<string> sehirler2 = new myList<string>();
        
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        Console.WriteLine(sehirler2.Count);
    }
}
class myList<T>
{

    T[] _array;
    T[] _tempArray;

    

    public myList()
    {
        _array = new T[0];
    }
   


    public int Count
    {
        get { return _array.Length; }

    }
    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1];

        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }

        _array[_array.Length - 1] = item;
    }
}