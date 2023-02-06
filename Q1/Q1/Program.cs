using System;
using System.Collections.Immutable;

class Q1
{
    public static void Main(string[] args)
    {
        string[] passengers;
        passengers = new string[10];

        Console.WriteLine("Enter a size:");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter elements: ");
        for (int i = 0; i < size; i++)
        {
            passengers[i] = Console.ReadLine();
        }
        //Console.WriteLine("Entered Passengers List: ");
        //for(int i=0;i<10;i++)
        //{
        //    Console.WriteLine(passengers[i]);
        //}
        //Console.WriteLine("Reverse order");
        //for (int i = size; i >= 0; i--)
        //{
        //    Console.WriteLine(passengers[i]);
        //}
        //Console.WriteLine("Enter a element: ");
        //string name = Console.ReadLine();
        //int flag = 0;
        //    for (int i = 0; i < size; i++)
        //    {
        //        if (passengers[i] == name)
        //        {
        //            Console.WriteLine("Name founded! :" + passengers[i]);
        //            flag++;
        //            break;
        //        } 

        //    }
        //if (flag == 0)
        //{
        //    Console.WriteLine("Not found!!");
        //}

        //Console.WriteLine("Duplicates in array: ");

        //for (int i = 0; i < size; i++)
        //{
        //    for (int j = 0; j < i; j++)
        //    {
        //        if (passengers[i] == passengers[j])
        //        {
        //            Console.WriteLine(passengers[i]);
        //        }
        //    }
        //}
        //Console.WriteLine("Length of each element in array: ");
        //foreach (string element in passengers) 
        //{
        //    Console.WriteLine(element.Length);
        //}
        //    Console.WriteLine("Printing as element when space: ");
        //    Console.WriteLine("array is: ");

        //    for (int i = 0; i < size; i++)
        //    {

        //        string s = passengers[i];
        //        string[] np = s.Split(' ');
        //        foreach (string str in np) { 
        //            Console.WriteLine(str);
        //        }
        //    }
        Console.WriteLine("Alphabetical Order: ");
        //string[] alp = passengers.Sort();
        //foreach (string str in alp)
        //{
        //    Console.WriteLine(str);
        //}
    }
}





