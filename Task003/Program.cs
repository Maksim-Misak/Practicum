// Написать программу, вычисляющую значение периодической функции f(x),
// в произвольной точке x, если на промежутке [a;b], 
// который составляет один её период, значения функции вычисляются по формуле
// - [-3; 3],  f(x) = |x| - 1
// - [-10; -2],  f(x) = 1/x + 0.6
// - [-4; 3],  f(x) = Cos(|π*x|)

//Часть 1
// int a = -3;
// int b = 3;
// int x = new Random().Next(-5, 5);
// Console.WriteLine("x = " + x);
// int i = 0;  
// if(x <= b && x >= a) i = Math.Abs(x) - 1;
// else Console.WriteLine("Вне промежутка");
// Console.WriteLine("Значение функции = " + i);

// Часть 2
// int a = -10;
// int b = -2;
// int x = new Random().Next(-11, -1);
// Console.WriteLine("x = " + x);
// double i = 0;  
// if(x <= b && x >= a && x != 0) i = Math.Round(1.0 / x + 0.6, 2);
// else Console.WriteLine("Вычеслить нельзя");
// Console.WriteLine("Значение функции = " + i);

// Часть 3
int a = -4;
int b = 3;
int x = new Random().Next(-5, 4);
Console.WriteLine("x = " + x);
double i = 0;  
if(x <= b && x >= a && x != 0) i = Math.Cos(Math.Abs(Math.PI * x));
else Console.WriteLine("Вычеслить нельзя");
Console.WriteLine("Значение функции = " + i);
