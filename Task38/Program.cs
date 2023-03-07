// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

int size = 5;// задаём длинну массива
double[] numbers = new double[size];// задаём массив с вещественными числами
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = numbers[0];// минимальный элемент массива
double max = numbers[0];// максимальный элемент массива

for (int i = 0; i < numbers.Length; i++)// циклом перебираем элементы 
{
  if (numbers[i] > max)// сравниваем если элемент массива больше максимального
  {
    max = numbers[i];// то в максимальный записываем больший элемент
  }
  if (numbers[i] < min)// сравниваем если элемент массива меньше минимального
  {
    min = numbers[i];// то в минимальный записываем меньший элемент
  }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min:f3}");// ввыводим данные в консоль

void FillArrayRandomNumbers(double[] numbers)// функция ничего не возвращает , но принимает массив вещественных чисел
{
  for (int i = 0; i < numbers.Length; i++)// перебираем числа циклом
  {
    numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;// double r = Convert.ToDouble(x.Next(-100, 100)/10.0); В данном случае мы имеем числа от - 10 до 9.9. Также самое, к примеру иметь положительные дробные числа double r = Convert.ToDouble(x.Next(100) / 10.0); В данном случае мы имеем генерацию от 0 до 9.9.
  }
}
void PrintArray(double[] numbers)// функция выводит в консоль массив чисел
{
  Console.Write("[ ");// выводим для красоты)
  for (int i = 0; i < numbers.Length; i++)// циклом перебираем элементы массива
  {
    Console.Write($"{numbers[i]} ");// вывод значения массива через пробел
  }
  Console.Write("]");//выводим для красоты)
  Console.WriteLine();
}