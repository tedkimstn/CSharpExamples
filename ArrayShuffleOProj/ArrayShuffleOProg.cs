// C# Code for Number of digits 
// in the product of two numbers 
using System; 

class GFG 
{ 
// A Function to generate a 
// random permutation of arr[] 
    static void randomize(int []arr, int n) 
    { 
        // Creating a object 
        // for Random class 
        Random r = new Random(); 
        
        // Start from the last element and 
        // swap one by one. We don't need to 
        // run for the first element 
        // that's why i > 0 
        for (int i = n - 1; i > 0; i--) 
        { 
            
            // Pick a random index 
            // from 0 to i 
            int j = r.Next(0, i+1); 
            
            // Swap arr[i] with the 
            // element at random index 
            int temp = arr[i]; 
            arr[i] = arr[j]; 
            arr[j] = temp; 
        } 
        // Prints the random array 
        for (int i = 0; i < n; i++) 
        Console.Write(arr[i] + " "); 
    } 
    
    
// Driver Code 
static void Main() 
{ 
    int[] arr = {1, 2, 3, 4, 
                5, 6, 7, 8}; 
    int n = arr.Length; 
    randomize (arr, n); 
} 
} 

// This code is contributed by Sam007 

