Console.WriteLine("Enter passenger name: ");
string name = Console.ReadLine();
Console.WriteLine("Miles travelled: ");
int m = int.Parse(Console.ReadLine());
int fp = 0;
if (m > 10000 && m <20000)
{
    fp = fp + 10;
    Console.WriteLine("flying points awarded: " + fp);
}
else if(m > 20000 && m<50000)
{
    fp = fp + 20;
    Console.WriteLine("flying points awarded: "+ fp);
}
else if(m > 50000 && m<100000)
{
    fp = fp + 30;
    Console.WriteLine("flying points awarded, for "+ name +":" +fp);
}
else
{
    fp = fp + 50;
    Console.WriteLine("flying points awarded: " + fp);
}
