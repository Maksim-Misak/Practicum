// Даны пять целых чисел. Выяснить, что 
// - три из них равны пяти
// - больше трёх из них равны пяти
// - менее трёх из них равны пяти

// int[] array = new int[5];
// int index = 0;
// while (index < 5)
// {
//     array[index] = new Random().Next (-10, 10);
//     index++; 
// }
// index = 0;
// while (index <= 4)
// {
//      int value = array[index];
//      Console.Write(array[index] + " ");
//      index++;
// }

int[] array = {5, 2, 3, 5, 0};
int count = 0;
for (int index = 0; index < array.Length; index++)
{
    if(array[index] == 5) count = count + 1;
}
if(count == 3) Console.WriteLine("Три из пяти целых чисел равны пяти");
if(count > 3) Console.WriteLine("Больше трёх из пяти целых чисел равны пяти");
if(count < 3) Console.WriteLine("Меньше трёх из пяти целых чисел равны пяти");