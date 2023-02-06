using System.Collections;

ArrayList arr = new ArrayList();

int count = 0;

while (count==0)
{
    Console.WriteLine(" 1.Enter new element  2.Quit :");
    Console.WriteLine("Enter your choice: ");
    int n = int.Parse(Console.ReadLine());
    switch (n)
    {
        case 1:
            Console.WriteLine("Enter flight number: ");
            arr.Add(Console.ReadLine());
            break;
        case 2:
            count = 1;
            break;     
        default:
            break;
    }
}
if(count==1)
{
    Console.WriteLine("Array of flight numbers: ");
    foreach ( var i in arr)
    {
        Console.WriteLine(i);
    }
   
}


  
