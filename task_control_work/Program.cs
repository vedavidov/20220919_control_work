// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.

string[] array = new string[8] { "123", "1567", "-2", "computer science", "NEW", "Denmark", "Kz", "757" };
string[] arrayNew = new string[array.Length];

SecondArray(array, arrayNew);

void SecondArray(string[] array, string[] arrayNew)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[num] = array[i];
            num++;
            Console.Write($"{array[i]}, ");
        }
    }
}