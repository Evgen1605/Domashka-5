// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0


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

int[] array = GetArray(4, 1, 10);
Console.WriteLine($"[{String.Join(", ", array)}]"); //Выводим случайный массив

int sum = 0;
for (int i = 1; i < array.Length; i+= 2) // циклом проходим по массиву
{
  sum = sum + array[i]; 
}

Console.WriteLine($"всего {array.Length} чисел, сумма элементов на нечётных позициях = {sum}");