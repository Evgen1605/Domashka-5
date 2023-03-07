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
Console.WriteLine($"[{String.Join(", ", array)}]"); //Выводим случайный массив

int count = 0;
for (int i = 0; i < array.Length; i++) // циклом проходим по массиву
{
  if (array[i] % 2 == 0)  // из массива вычлиняем чётные числа, сравниваем  если у числа нет остатка от деления 
  {
    count++;// то добавляем в переменную  
  }
}

Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные");
