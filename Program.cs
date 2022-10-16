// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пjльзоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Из введенного массива строк сформируем новый массив из строк, длина которых меньше либо равна 3 символа.");
Console.Write("Какое количество элементов будет в массиве? ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];
for(int i = 0; i < n; i++)
{
    Console.Write("Введите элемент: ");
    string m = Convert.ToString(Console.ReadLine());
    array[i] = m;
} 

Console.Write("Новый массив: ");
int l = 0;
string[] newArray = new string[n];
for(int j = 0; j < n; j++)
{
    if(array[j].Length <= n)
    {
        newArray[l] = array[j];
        Console.Write(newArray[l] + "  ");
        l++;
    }
}


