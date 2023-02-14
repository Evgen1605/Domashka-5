// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.Clear();


int[] GetArray(int size, int minValue, int maxValue) // Задаём случайные числа массива
{
  int[] res = new int[size];

  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

int[] array = GetArray(4, 100, 1000);
Console.WriteLine($"[{String.Join(", ", array)}]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] % 2 == 0)
  count++;
}

Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные");
