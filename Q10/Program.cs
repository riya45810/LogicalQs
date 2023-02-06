using System.Collections;

int[] arr = new int[10];
Queue q1 = new Queue();
Queue q2 = new Queue();
Queue q3= new Queue();
Random rand = new Random();
Console.WriteLine("Enter boarding passes: ");
for (int i = 0; i < 10; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
for (int i = 0;i < 3; i++)
{
    q1.Enqueue(arr[i]);
}
for (int i = 3;i<6; i++)
{
    q2.Enqueue(arr[i]);
}
for(int i = 6; i < 9; i++)
{
    q3.Enqueue(arr[i]);
}
//foreach(object obj in q1)
//{
//    Console.WriteLine(obj);
//}
int m = rand.Next(1, 4);

switch (m)
{
    case 1:
        q1.Dequeue();
        q1.Enqueue(arr[9]);
        Console.WriteLine("Queue is :");
        foreach(object i in q1)
        {
            Console.WriteLine(i);
        }
        break;
    case 2:
        q2.Dequeue();
        q2.Enqueue(arr[9]);
        Console.WriteLine("Queue is :");
        foreach (object i in q2)
        {
            Console.WriteLine(i);
        }
        break;
    case 3:
        q3.Dequeue();
        q3.Enqueue(arr[9]);
        Console.WriteLine("Queue is :");
        foreach (object i in q3)
        {
            Console.WriteLine(i);
        }
        break;
    default:
        break;
}




