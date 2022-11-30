// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int aX = 0;
int aY = 0;
int aZ = 0;

int bX = 0;
int bY = 0;
int bZ = 0;



void EnterNumber(){
Console.WriteLine("Введите координаты для точки А: ");

Console.Write("Введите координту Х: ");
aX=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координту Y: ");
aY=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координту Z: ");
aZ=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты для точки B: ");

Console.Write("Введите координту Х: ");
bX=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координту Y: ");
bY=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координту Z: ");
bZ=Convert.ToInt32(Console.ReadLine());
}

EnterNumber();
double numberXY = Math.Sqrt(((aX-bX)*(aX-bX)) + ((aY-bY)*(aY-bY)));
Console.Write(numberXY);
double number = Math.Sqrt((numberXY * numberXY) + ((aZ-bZ)*(aZ-bZ)));

Console.Write($"Расстояние между координатами: {Math.Round(number, 2)}");
