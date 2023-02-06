
DateTime now = DateTime.Now;

Console.WriteLine("Enter the number of passengers:");
int n =int.Parse(Console.ReadLine());
DateTime[] dblist = new DateTime[n];
Console.WriteLine("Enter date of birth (yyyy-mm-dd)'s ");
for (int i = 0;i < n; i++)
{
    dblist[i] = DateTime.Parse(Console.ReadLine());
}
foreach (DateTime db in dblist)
{
    int age = now.Year - db.Year;
    if (age < 10)
    {
        Console.WriteLine("Passenger : Kid ");
    }
    else if((age > 10) && (age <30)) 
    {
        Console.WriteLine("Passenger : Youth");
    }
    else if((age>30)&& (age<60))
    {
        Console.WriteLine("Passenger : Adult");
    }
    else if(age >= 60)
    {
        Console.WriteLine("Passenger : Older");
    }
}
    




   