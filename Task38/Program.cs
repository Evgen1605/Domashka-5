// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

int size = 5;
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = numbers[0];
double max = numbers[0];

for (int z = 0; z < numbers.Length; z++)
{
  if (numbers[z] > max)
  {
    max = numbers[z];
  }
  if (numbers[z] < min)
  {
    min = numbers[z];
  }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min:f3}");

void FillArrayRandomNumbers(double[] numbers)
{
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
  }
}
void PrintArray(double[] numbers)
{
  Console.Write("[ ");
  for (int i = 0; i < numbers.Length; i++)
  {
    Console.Write(numbers[i] + " ");
  }
  Console.Write("]");
  Console.WriteLine();
}