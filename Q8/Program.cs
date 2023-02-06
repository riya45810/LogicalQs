

decimal[] fare = new decimal[10];
string[] destination= new string[10];
Console.WriteLine("Enter limit: ");
int l = int.Parse(Console.ReadLine());
Console.WriteLine("Enter fares: ");
for (int i = 0; i < l; i++)
{
    fare[i] = decimal.Parse(Console.ReadLine());
}
Console.WriteLine("Enter destination: ");
for (int i = 0; i < l; i++)
{
    destination[i] = Console.ReadLine();
}
Console.WriteLine("Enter index: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Fare and destination at index ,"+ n + "is");
Console.WriteLine(fare[n]);
Console.WriteLine(destination[n]);
