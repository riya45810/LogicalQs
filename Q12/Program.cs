Console.WriteLine("Enter the number of passengers: ");
int n = int.Parse(Console.ReadLine());
string[] name = new string[n];
Console.WriteLine("enter the number of destination: ");
int m = int.Parse(Console.ReadLine()); 
string[] destn= new string[m];
Console.WriteLine("Enter passengers: ");
for(int i = 0; i < n; i++)
{
    name[i] = Console.ReadLine();
}
Console.WriteLine("Enter destinations: ");
for (int i = 0; i < m; i++)
{
    destn[i] = Console.ReadLine();
}
string[] arr = new string[m+n];
int count = 0;
for (int i = 0;i < n; i++)
{
    arr[i] = name[i];
    count++;
}
for (int i = 0; i < m; i++)
{
    arr[count] = destn[i];
    count++;
}
Console.WriteLine("Merged array is: ");
for (int i=0; i < m+n; i++)
{
    Console.WriteLine(arr[i]);
}
