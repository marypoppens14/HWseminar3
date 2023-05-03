// принимает на вход координаты двух точек 
// находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координаты: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double squareX = Math.Pow(x2 - x1, 2);
double squareY = Math.Pow(y2 - y1, 2);
double squareZ = Math.Pow(z2 - z1, 2);

double length = Math.Sqrt(squareX + squareY + squareZ);
length = Math.Round(length, 2);
Console.WriteLine(length);
