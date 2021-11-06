// Подсчитать количество натуральных чисел, не превосходящих заданного числа n, которые
// - делятся на k, но не на l
// - делятся хотябы на k или на l
// - не делятся на (k + l)

// int n = 128;

// int i = 1;
// int k = 3;
// int l = 5;


int Check(int n, int k, int l)
{
    int count = 0;
    int i = 1;
    while (i <= n)
    {
            // bool flag1 = i % k == 0;
            // bool flag2 = i % l != 0;
            
            if ((i % k == 0) && (i % l != 0)) count ++;
         
            i++;
    }
    return count;
 }

Console.Write("n = ");
int nUser = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"count = {count}");
Console.WriteLine($"count = {Check(nUser, 3, 5)}");
