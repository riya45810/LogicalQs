Console.WriteLine("Enter flight fare: ");
double fare = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter booking time");
int time = Convert.ToInt32(Console.ReadLine());
if (time > 6 && time < 9)
{
    fare = (fare * 0.1) + fare;
    Console.WriteLine("Fare :" + fare);
}
else if (time > 9 && time < 17)
{

    fare = (fare * 0.20) + fare;
    Console.WriteLine("Fare :" + fare);
}
else if (time > 17 && time < 23)
{
    fare = (fare * 0.07) + fare;
    Console.WriteLine("Fare :" + fare);
}
else
{
    fare = (fare * 0.05) + fare;
    Console.WriteLine("Fare :" + fare);
}
