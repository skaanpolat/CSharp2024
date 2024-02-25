
string[] students = new string[3];
string student1 = "Engin";
string student2 = "Derin";
string student3 = "Salih";

string[] students2 = { "Engin", "Derin", "Salih" };

students[0] = student1;
students[1] = student2;
students[2] = student3;

foreach (var student in students2)
{
    Console.WriteLine(student);

}

string[,] regions = new string[5, 3]
{
    {"İstanbul","İzmit","Balıkesir"},
    {"Ankara","Konya","Kırıkkale" },
    {"Antalya","Adana","Mersin" },
    {"Rize","Trabzon","Samsun" },
    {"İzmir","Muğla","Manisa" }

};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("****************");
    
}


