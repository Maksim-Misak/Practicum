// Выяснить является ли вещественное m
// - целой степенью числа 3
// - корнем целой степени из 5, 
// - синусом угла кратного 45 градусам


// - целой степенью числа 3
double m = 625;
// double m = new Random().Next(1, 1000);
Console.WriteLine($"m = {m}");
double a = 3;
double j = Math.Log(m, a);
if (Math.Ceiling(j) - j < 0.0001) j = Math.Ceiling(j);
if (Math.Pow(a, j) == m) Console.WriteLine($"Число {m} является степенью числа 3");
else Console.WriteLine($"Число {m} НЕ является степенью числа 3");

// - корнем целой степени из 5, 

double b = 5;
double k = Math.Log(m, b);
if (k - Math.Floor(k) < 0.0001) k = Math.Floor(k);
if (Math.Pow(b, k) == m) Console.WriteLine($"Число {m} является корнем целой степени из 5");
else Console.WriteLine($"Число {m} НЕ является корнем целой степени из 5");

// - синусом угла кратного 45 градусам

if(m == Math.Sin(45) || m == Math.Sin(90) || m == Math.Sin(135) || m == Math.Sin(180)) Console.WriteLine($"Число {m} является синусом угла кратного 45 градусам");
else Console.WriteLine($"Число {m} НЕ является синусом угла кратного 45 градусам");