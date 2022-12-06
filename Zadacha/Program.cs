// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string text = "hello, 2, world, :)";
string[] array = text.Split(" ");
string[] newArray = new string[array.Length];

void FillArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result = result + array[i];               
    }
    Console.WriteLine($"Массив из элементов длиной <= 3: {result}");
}