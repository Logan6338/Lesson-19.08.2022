int[] arr = new int[] { 6, 7, 19, 345, 3 }; 
 
bool FindNumber(int N, int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] == N) 
        { 
            return true; 
        } 
    } 
    return false; 
} 
int M = Convert.ToInt32(Console.ReadLine()); 
bool res = FindNumber(M, arr); 
Console.WriteLine(res);