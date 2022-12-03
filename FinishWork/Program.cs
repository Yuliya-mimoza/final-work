// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void Selection(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3)
        {
            array[i] = string.Empty;
        }
    }
}
void Printarray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
string[] array = new string[4] { "Hello", "2", "world", ":-)" };
Selection(array);
Printarray(array);
