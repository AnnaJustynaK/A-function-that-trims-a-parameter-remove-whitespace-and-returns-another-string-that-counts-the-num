// C# implementation of the approach
using System;
 
class GFG
{
     
    static int MAX = 26;
     
    // Function to print the frequency
    // of each of the characters of
    // s in alphabetical order
    static void compressString(string s, int n)
    {
        // To store the frequency
        // of the characters
        int []freq = new int[MAX] ;
     
        // Update the frequency array
        for (int i = 0; i < n; i++)
        {
            freq[s[i] - 'a']++;
        }
     
        // Print the frequency in alphatecial order
        for (int i = 0; i < MAX; i++)
        {
     
            // If the current alphabet doesn't
            // appear in the string
            if (freq[i] == 0)
                continue;
     
            Console.Write((char)(i + 'a') +""+ freq[i]);
        }
    }
     
    // Driver code
    public static void Main()
    {
        string s = "aabbccaabb";
        int n = s.Length;
     
        compressString(s, n);
    }
}