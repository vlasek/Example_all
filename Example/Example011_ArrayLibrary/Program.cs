void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collect) // если ничего не возвращаем то используем void  и тогда не нужен return
{
    int count = collect.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collect[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position =-1; //искуственный прием если не нашли

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; // создай новый массив с 10 элементами
FillArray(array);
array[4]=4; //принудительно
array[6]=4;
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array,444);
Console.WriteLine(pos);
