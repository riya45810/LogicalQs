Console.WriteLine("Enter the number of carry weights: ");
int n = int.Parse(Console.ReadLine());

int[] arr= new int[n];
Console.WriteLine("Enter weight's : ");
for (int i = 0;i < n; i++)
{
    arr[i] =int.Parse(Console.ReadLine());
}

int[] arr2 = new int[n];

for(int i = 0;i < n;i++)
{
    if (arr[i] > 23)
    {
        int over_weight =arr[i] - 23;
        //int price = over_weight * 15;
        arr2[i] = over_weight;
        
    }
    else
    {
        arr2[i] = 0;
    }

}
Console.WriteLine("overweight array");
for(int i = 0;i < n; i++)
{
    Console.WriteLine(arr2[i]);
}
Array.Sort(arr2);
Console.WriteLine("Max in overweight array : " + arr2[n - 1]);
Console.WriteLine("total overweight: ");
int total=0;
for(int i = 0;i < n;i++)
{
     total = total+ arr2[i];
}
Console.WriteLine(total);