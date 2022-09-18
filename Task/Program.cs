// Программа, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 

Console.Clear();

string[] array = { "Rus", "QA", "number", "163", "Hello world!", "qwe" };
string[] result = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) result[i] = array[i];
    else result[i] = string.Empty;
    if (result[i] != string.Empty) Console.Write($"{result[i]} ");
}
