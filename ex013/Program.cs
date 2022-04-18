int numberA = 100;
int numberB = 5;

if(numberA % numberB == 0)
{
    Console.WriteLine("yes");
}
else
{
    int remains = numberA / numberB;
    Console.WriteLine("no, remains " + remains);
}
