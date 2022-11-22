using System;
 
 
 class Test {
   
    
    static int diff(int []arr)
    {
        Array.Sort(arr);
        int mid = arr[arr.Length / 2];
        int sum = 0;
        for (int i = 0; i < arr.Length; i++) {
            sum = sum + Math.Abs(arr[i] - mid);
        }
          
        return sum;       
    }
   
    public static void Main()
    {
        int []arr = { 5, 13, 14, 10, 3};
        Console.Write(diff(arr));        
    }
 }