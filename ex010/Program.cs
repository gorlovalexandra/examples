int[] array = { 15, 52, 73, 94, 25, 36, 73, 84, 19 };

int n = array.Length;
int find = 73;

int index = 0;

while (index < n)
{
    if(array[index] == find)   
    {
        Console.WriteLine(index);
        break; // чтобы найти индекс только первого числа
    }
    //index = index + 1;
    index++;
}
