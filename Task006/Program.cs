// Выяснить является ли вещественное m
// - целой степенью числа 3
// - корнем целой степени из 5, 
// - синусом угла кратного 45 градусам


// - целой степенью числа 3
double m = 25;
// double m = new Random().Next(1, 1000);
Console.WriteLine($"m = {m}");
double a = 3;
double j = Math.Log(m, a);
if (Math.Truncate(j) - j == 0) Console.WriteLine($"Число {m} Является целой степенью числа 3");
else Console.WriteLine($"Число {m} НЕ является степенью числа 3");

// - корнем целой степени из 5, 
double b = 5;
double k = Math.Log(Math.Pow(m, 2), b);
Console.WriteLine(k);
// if (k - Math.Floor(k) < 0.0001) k = Math.Floor(k);
if (Math.Truncate(k) - k == 0) Console.WriteLine($"Число {m} Является корнем целой степени из 5");
else Console.WriteLine($"Число {m} НЕ является корнем целой степени из 5");

// - синусом угла кратного 45 градусам
if(m == Math.Sin(45 * Math.PI / 180) || m == Math.Sin(90 * Math.PI / 180) || m == Math.Sin(135 * Math.PI / 180) || m == Math.Sin(180 * Math.PI / 180)) Console.WriteLine($"Число {m} Является синусом угла кратного 45 градусам");
else Console.WriteLine($"Число {m} НЕ является синусом угла кратного 45 градусам");
