//int [] array ={14,25,333,354,45, 18, 18, 76,27,48,93};

int n = array.Length;
int find = 18;
int index =0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // если нудно один раз
    }
    index++; //index =index +1;

}


