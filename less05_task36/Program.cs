/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();

void FillingArrey(int[] array) // Заполнение массива рандомными числами с демонстрацией
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 10); // [-99, 100] заполнили
    Console.WriteLine($"Массив для задачи: [{string.Join(", ", array)}]"); // вывели на экран
}

void SummaArray(int[] array) // Подсчет суммы чисел на нечетных пзициях 1, 3, 5,..
{
    int summ = 0;
  
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
        summ += array[i];
    Console.WriteLine($"Сумма чисел на нечетных позициях: {summ}");
}

Console.Clear();
Console.Write("Введите количество чисел для задачи: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillingArrey(array);
SummaArray(array);
