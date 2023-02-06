int even = 0, odd =1;
Console.WriteLine("Enter the number of fares: ");
int n = int.Parse(Console.ReadLine());

double[] arr = new double[n*2];
Console.WriteLine("Enter fares: ");
for (int i = 0;i < n; i++)
{
    double fare = double.Parse(Console.ReadLine()); 
    if(fare % 2 == 0)
    {
        arr[even] = fare;
        even = even + 2;
    }
    else
    {
        arr[odd] = fare;
        odd = odd + 2;
    }
}
Console.WriteLine("array of fares: ");
foreach (double i in arr)
{
    Console.WriteLine(i);
}

