// принимает на вход пятизначное число 
// проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число: ");
string a = Console.ReadLine();
int length = a.Length;

if (length == 5)
{
    if (a[0] == a[4] && a[1] == a[3])
    {
        Console.WriteLine($"{a} - палиндром");
    }
    else
    {
        Console.WriteLine($"{a} - не палиндром");
    }
}

else
{
    Console.WriteLine("Число не является пятизначным");
}