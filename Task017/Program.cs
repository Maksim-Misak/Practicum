// Задача
// Cформировать случайным образом целочисленный массив A 
// из натуральных двузначных чисел.

// Создать на его основе массив В, отбрасывая те, которые
// 1 нарушают порядок возрастания
// 2 больше среднего арифметического элементов А
// 3 чётные

// Задать массив
int[] array = new int[10];
int index = 0;

// Заполнить массив
while (index < 10)
{
     array[index] = new Random().Next(10, 100);
     index++;
}

// Печатаем массив
Console.Write("Массив = ");
index = 0;
while (index <= 9)
{
     int val = array[index]; 
     Console.Write(val + " ");
     index++;
}
Console.WriteLine();

// отбрасываем числа порядок возрастания
// index = 1;
// int currentElement =  array[0];
// Console.WriteLine(currentElement);
// while (index <= 9)
// {
//      if(array[index] > currentElement)
//      {
//          Console.WriteLine(array[index]);
//          currentElement = array[index];
//      }
//      index++;
// }

// отбрасываем числа больше среднего арифметического элементов А

// double avr()
//      {
//           double Average = 0;
//           double result = 0;
//           for (int i = 0; i < array.Length; i++)
//           {
//               result = result + array[i];
//           }
//           Average = result / array.Length;
//           Console.WriteLine("Среднее = " + Average);
//           return Average;
//      }
// double AVR = avr();
// Console.WriteLine();
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] <= AVR) 
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// // отбрасываем чётные числа
Console.WriteLine();
for (index = 0; index < array.Length; index++)
{
    if (array[index] % 2 != 0) Console.WriteLine(array[index]);
}

