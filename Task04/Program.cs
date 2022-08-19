int[] array = new int[123];

int[] FillArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,124);

    }
    return arr;
}
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}


int Check(int[] arr)
{
    int count = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 10 && arr[i] <= 99)
        {
            count += 1;
        }
    }
    return count;
}


int[] result = FillArray(array);
PrintArr(array);
System.Console.WriteLine();
int count = Check(result);
Console.WriteLine(count);