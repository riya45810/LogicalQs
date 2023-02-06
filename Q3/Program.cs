decimal[] arr = new decimal[10];
Console.WriteLine("Enter limit: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter flight flare: ");

for (int i = 0;i < size; i++)
{
    arr[i]= Convert.ToDecimal(Console.ReadLine());
}

Console.WriteLine("Ascending order: ");
Array.Sort(arr);
for (int i = 0; i < size; i++)
{
    Console.WriteLine(arr[i]);
}


Console.WriteLine("Descending order: ");
Array.Reverse(arr);
for (int i = 0; i < size; i++)
{
    Console.WriteLine(arr[i]);
}
Console.WriteLine("Enter a element");

decimal element = Convert.ToDecimal(Console.ReadLine());
int flag = 0;
for (int i = 0; i < size; i++)
{
    if (arr[i] == element)
    {
        Console.WriteLine("Fare founded! :" + arr[i]);
        flag++;
        break;
    }

}
if (flag == 0)
{
    Console.WriteLine("Fare not found!!");
}
Console.WriteLine("Min and Max of array:");
Array.Sort(arr);
Console.WriteLine(arr[0] + "and" + arr[size-1]);
Console.WriteLine("Duplicate fare in array: ");
int f = 0;
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (arr[i] == arr[j])
        {
            Console.WriteLine(arr[i]);
            f = 1; break;
        }
    }
}
if (f == 0)
{
    Console.WriteLine("Fare not found!!");
}



