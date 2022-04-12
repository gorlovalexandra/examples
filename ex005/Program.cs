Console.Write("write user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("yeah, it`s Masha!");
}
else
{
    Console.Write("hello, ");
    Console.WriteLine(username);
}
