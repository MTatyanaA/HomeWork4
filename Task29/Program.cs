//  Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//  6, 1, 33 -> [6, 1, 33]


Console.WriteLine("Программа задаёт массив из N элементов и выводит их на экран.");
int[] ArrayElement = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Введите элемент c индексом " + i);
    ArrayElement[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(" Массив: {0}", String.Join(" ", ArrayElement));