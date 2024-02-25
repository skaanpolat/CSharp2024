
using intro.Business;
using intro.DataAccess.Concretes;
using intro.Entities;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string message1 = "Mesaj 1";
int term = 12;

double amount = 100000.0;

bool isAuthenticated = true;

Console.WriteLine(message1);



CourseManager courseManager = new(new DapperCourseDal());
List<Course> courses = courseManager.getAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price + " || Açıklama: " + courses[i].Description);
}

IndividualCustomer customer1 = new IndividualCustomer();
IndividualCustomer customer2 = new IndividualCustomer();
CorporateCustomer customer3 = new CorporateCustomer();
CorporateCustomer customer4 = new CorporateCustomer();

customer1.ID = 1;
customer1.FirstName = "Aslı";
customer1.LastName = "Karahan";
customer1.NationalIdentity = "123456";
customer1.CustomerNumber = "12987317890";

customer2.ID = 2;
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.NationalIdentity = "123456788";
customer2.CustomerNumber = "08923712375";
customer3.ID = 3;
customer3.CompanyName = "kodlama.io";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "1233456456";

customer4.ID = 4;
customer4.CompanyName = "ABC";
customer4.CustomerNumber = "129388";
customer4.TaxNumber = "1233487777";


string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}