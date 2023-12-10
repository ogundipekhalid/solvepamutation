// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string digits = "123";
int n = digits.Length;

// Create an array to store the current permutation
int[] permutation = new int[n];

// Initialize the permutation to the starting order (123)
for (int i = 0; i < n; i++)
{
    permutation[i] = i;
}

// Loop through all permutations
while (true)
{
    // Output the current permutation
    for (int i = 0; i < n; i++)
    {
        Console.Write(digits[permutation[i]]);
    }
    Console.WriteLine();

    // Find the next permutation
    int j = n - 2;
    while (j >= 0 && permutation[j] >= permutation[j + 1])
    {
        j--;
    }
    if (j < 0)
    {
        // No more permutations
        break;
    }
    int k = n - 1;
    while (permutation[j] >= permutation[k])
    {
        k--;
    }
    Swap(permutation, j, k);
    Reverse(permutation, j + 1, n - 1);
}

// Swaps the elements at indices i and j in the given array
static void Swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

// Reverses the elements in the given range of the given array
static void Reverse(int[] arr, int start, int end)
{
    while (start < end)
    {
        Swap(arr, start, end);
        start++;
        end--;
    }

        
    
}
