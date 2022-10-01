//Написать программу, котора из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальныйй массив можно ввести с клавиатуры, либо задать на старте выполнени алгоритма. 
//При решении не рекомендуется пользоватьс коллекциями, лучше обойтись исключительно массивами.


string[] array = new string[5] {";-)", "0101", "hello", "ok", "..."};
string[] finalarray = new string[array.Length];
int count = 0;
void ArrayThreeSymbol(string[] array, string[] finalarray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        finalarray[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayThreeSymbol(array, finalarray);
PrintArray(finalarray);