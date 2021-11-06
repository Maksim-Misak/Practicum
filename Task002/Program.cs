// Задать положительное вещественное число m. Cоставить целое число n из цифр
// - десятков и сотых m
// - единиц и сотых m
// - сотен и десятых m

double m = 465469.54489419;
double i1, i2, i3;
double k1, k2, k3;
int n1, n2, n3;

i1 = Math.Floor((Math.Floor(m) % 100) / 10);
i2 = Math.Floor(m) % 10;
i3 = Math.Floor((Math.Floor(m) % 1000) / 100);
Console.WriteLine($"i1 = {i1},  i2 = {i2},  i3 = {i3}");

k1 = (Math.Floor(Math.Round(1 - (Math.Ceiling(m) - m), 3) * 100)) / 10;
k1 = (1 - Math.Round(Math.Ceiling(k1) - k1, 1)) * 10;
k2 = k1;
k3 = Math.Floor(Math.Round(1 - (Math.Ceiling(m) - m), 3) * 10);
Console.WriteLine($"k1 = {k1},  k2 = {k2},  k3 = {k3}");

n1 = int.Parse(i1.ToString() + k1.ToString());
n2 = int.Parse(i2.ToString() + k2.ToString());
n3 = int.Parse(i3.ToString() + k3.ToString());
Console.WriteLine($"n1 = {n1}, n2 = {n2}, n3 = {n3}");
