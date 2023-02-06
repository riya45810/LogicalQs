DateTime bd = new DateTime();
Console.WriteLine("Enter DOB (yyyy-mm-dd) of passenger: ");
DateTime.TryParse(Console.ReadLine(), out bd);
DateTime now= DateTime.Now;
TimeSpan time = now- bd;

double hours = time.TotalHours;
Console.WriteLine(" age in Hours : " + hours);

double days = time.TotalDays;
Console.WriteLine("age in days : " + days);

double weeks = days / 7;
Console.WriteLine("age in weeks : " + weeks);

double months = days / 30;
Console.WriteLine("age in months : " +months );

double years = days / 365;
Console.WriteLine("age in years : "+years);

if((bd.Year) % 4 == 0)
{
    Console.WriteLine("Birthyear is leapyear.");
}
else
{
    Console.WriteLine("Birthyear is not a leap year.");
}
