// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
//ARRAYS AND STRINGS
//Q1
//string is non-mutable
//StringBuilder object is mutable and uses less space

//Q2
//The Array class

//Q3
//sorting arrays    
//Array.Sort(ArrayName);

//Q4
//ArrayName.length

//Q5
//multiple data types in array?
//no
//Q6
//clone vs copyto
//clone creates a new array
//copyto puts the elements into an already existing array


//PRACTICING ARRAYS
//Q1
int[] myArray = {0,1,2,3,4,5,6,7,8,9};
int[] myArray2 = new int[10];

for (int i = 0; i < 10; i++) 
{
    myArray2[i] = myArray[i];
    Console.WriteLine(myArray[i]);
    Console.WriteLine(myArray2[i]);
}

//Q2
List<string> shoppingList = new List<string>();
int testC = 0;
while (testC < 5)
{
    Console.Write("Enter command (+ item, - item, or -- to clear)):");
    string command = Console.ReadLine();
    if (command == "--")
    {
        shoppingList.Clear();
    }
    else
    if (command[0] == '+')
    {
        shoppingList.Add(command.Substring(2));
    }
    else
    if (command[0] == '-')
    {
        shoppingList.Remove(command.Substring(2));
    }

    for (int i = 0; i < shoppingList.Count; i++)
    {
        Console.WriteLine(shoppingList[i]);
    }
    testC++;

}

//Q3

static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> primesL = new List<int>();
    for (int i = startNum; i < endNum; i++)
    {
        int canBeDiv = 0;
        for (int j = 1; j < startNum + 1; j++) 
        {
            if (i % j == 0) 
            {
                canBeDiv++;
            }
        }
        if (canBeDiv == 2) 
        {
            primesL.Add(i);
        }
    }
    int[] primes = new int[primesL.Count];
    for (int i = 0; i < primes.Length; i++) 
    {
        primes[i] = primesL[i];
    }
    return primes;
}
//Q4

static void rotatedSum(int[] n, int k) 
{
    int[] sum = new int[n.Length];
    int[,] rotated = new int[k + 1,n.Length];
    //puts in the n as 0
    for (int i = 0; i < n.Length; i++) 
    {
        rotated[0,i] = n[i];
    }


    for (int i = 1; i < k+1; i++) 
    {

        rotated[i, 0] = rotated[i - 1, n.Length - 1];
        for (int j = 1; j < n.Length; j++) 
        {
            rotated[i, j] = rotated[i-1,j-1];
        }
    }
    for(int i = 0; i < n.Length; i++) 
    {
        int sum1 = 0;
        for (int j = 1; j < k+1; j++) 
        {
            sum1 += rotated[j,i];
        }
        Console.Write(sum1 + " ");
    }
}
int[] n = { 3, 2, 4, -1 };
rotatedSum(n, 2);


//Q5

static void seqNum(int[] n) 
{
    List<List<int>> seqOcc = new List<List<int>>();
    List<int> ints = new List<int>();
    for (int i = 0; i < n.Length; i++)
    {
        List<int> subList = new List<int>();
        if (ints.Contains(n[i]))
        {
            seqOcc[ints.IndexOf(n[i])][1] += 1; 
        }
        else 
        {
            ints.Add(n[i]);
            subList.Add(n[i]);
            subList.Add(1);
            seqOcc.Add(subList);
        }
    }
    Console.WriteLine("");
    int highest = 0;
    List<int> HighestNumber = new List<int>();
    for (int i = 0; i < seqOcc.Count; i++) 
    {
        if (seqOcc[i][1] > highest)
        {
            HighestNumber.Clear();
            highest = seqOcc[i][1];
            HighestNumber.Add(seqOcc[i][0]);
        }
        else
        if (seqOcc[i][1] == highest) 
        {
            HighestNumber.Add(seqOcc[i][0]);
        }
    }
    if (HighestNumber.Count == 1)
    {
        Console.WriteLine($"The number {HighestNumber[0]} is the most frequent (occurs {highest} times)");
    }
    else
    {
        Console.Write("The numbers ");
        for (int i = 0; i < HighestNumber.Count; i++) 
        {
            if (i == HighestNumber.Count - 1)
            {
                Console.Write($"and {HighestNumber[i]} ");
            }
            else
            {
                Console.Write($"{HighestNumber[i]}, ");
            }
        }
        Console.WriteLine($"have the same maximal frequence(each occurs {highest} times).The leftmost of them is {HighestNumber[0]}.");
    }
}
int[] s = { 4,1,1,4,2,3,4,4,1,2,4,9,3};
seqNum(s);
int[] ss = { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 };
seqNum(ss);

//PRACTICE STRINGS
//Q1

static void reverseStr(string s) 
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    string reverseExample = new string(charArray);
    for (int i = 0; i < charArray.Length; i++) 
    {
        Console.Write(reverseExample[i]);
    }
}
string example = "example";
reverseStr(example);


//Q2

//Q3
Console.WriteLine("");
static void palindrome(string s) 
{
    var sb = new StringBuilder();
    foreach (char c in s) 
    {
        if (!char.IsPunctuation(c))
        {
            sb.Append(c);
        }
        else 
        {
            sb.Append(' ');
        }
    }

    string[] words = sb.ToString().Split(' ');
        List<string> palindromes = new List<string>();
    for (int i = 0; i < words.Length; i++) 
    {
        char[] charArray = words[i].ToCharArray();
        Array.Reverse(charArray);
        string reverseStr = new string(charArray);
        if (words[i] == reverseStr && !string.IsNullOrWhiteSpace(words[i])) 
        {
            palindromes.Add(words[i]);
        }
    }
    for (int i = 0; i < palindromes.Count; i++) 
    {
        Console.WriteLine(palindromes[i]);
    }
}
String s1 = "Hi, exe? ABBA! Hog fully a string: ExE.Bob";
palindrome(s1);
//Q4   
static void urlParse(Uri u)
{
    Console.WriteLine("[Protocol] = "+u.Scheme);
    Console.WriteLine("[Server] = "+u.IdnHost);
    Console.WriteLine("[Resource] = " + u.AbsolutePath);
}

Uri uriTest = new Uri("https://www.apple.com");
urlParse(uriTest);