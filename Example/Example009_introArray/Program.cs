﻿int Max(int arg1, int arg2, int arg3) // кусок кода отвечающих за макс из 3-х
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
} //            0  1  2 3  4  5  6  7   8
int [] array ={14,25,333,354,45,76,27,48,93};
// array [0]=12;
// Console.WriteLine(array[4]);

int result=Max(
    Max (array[0], array[1], array[2]),
    Max (array[3], array[4], array[5]), 
    Max (array[6], array[7], array[8])
);

Console.WriteLine("max = "+result);
