// C++ implementation of the approach
#include <bits/stdc++.h>
using namespace std;
 
const int MAX = 26;
 
// Function to print the frequency
// of each of the characters of
// s in alphabetical order
void compressString(string s, int n)
{
    // To store the frequency
    // of the characters
    int freq[MAX] = { 0 };
 
    // Update the frequency array
    for (int i = 0; i < n; i++) {
        freq[s[i] - 'a']++;
    }
 
    // Print the frequency in alphatecial order
    for (int i = 0; i < MAX; i++) {
 
        // If the current alphabet doesn't
        // appear in the string
        if (freq[i] == 0)
            continue;
 
        cout << (char)(i + 'a') << freq[i];
    }
}
 
// Driver code
int main()
{
    string s = "aaaabc";
    int n = s.length();
 
    compressString(s, n);
 
    return 0;
}

