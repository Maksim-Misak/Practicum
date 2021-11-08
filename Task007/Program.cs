// Даны четыре логические значения f1, f2, f3, f4. Записать условие того, что
// - более трёх значений истинны
// - хотя бы три значения истинны
// - менее трёх значений истинны

bool F1 = true, F2 = true, F3 = true, F4 = true;
int count = 0;
if(F1 == true) count++;
if(F2 == true) count++;
if(F3 == true) count++;
if(F4 == true) count++;
if (count > 3) Console.WriteLine("более трёх значений истинны");
if (count >= 3) Console.WriteLine("хотя бы три значения истинны");
if (count < 3) Console.WriteLine("менее трёх значений истинны");