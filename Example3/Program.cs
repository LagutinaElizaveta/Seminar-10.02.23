Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
int y = x;
x = -x;
while(x<=y)
{
    Console.Write(x + " , ");
    x++;
}
