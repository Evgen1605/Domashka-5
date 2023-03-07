// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0


Console.Clear();


int[] GetArray(int size, int minValue, int maxValue)// функция для заполнения массива случайными числами
{
  int[] res = new int[size];// объявляем массив

  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);// заполняем массив рандомными числами
  }
  return res;
}

int[] array = GetArray(10, -10, 10);
Console.WriteLine($"[{String.Join(", ", array)}]"); //Выводим случайный массив

int SumOfElementsInOddPositions(int[] array)// функция на вход принимает массив
{
  int sum = 0;// создаём переменную в которой будем считать сумму чисел
  for (int i = 1; i < array.Length; i += 2) // циклом проходим по массиву (i += 2)- означает что будем прибавлять только чётные числа массива
  {
    sum += array[i];//в переменную прибавляем элементы массива 
  }
  return sum;// после прохождения всего цикла, возвращаем всю сумму чисел
}

Console.WriteLine($"всего {array.Length} чисел, сумма элементов на нечётных позициях = {SumOfElementsInOddPositions(array)}");// ввыводим в консоль