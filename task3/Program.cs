// принимает на вход число (N) 
// выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int x = 1; x <= a; x++)
{
    Console.WriteLine($"{x * x * x}");
}