// See https://aka.ms/new-console-template for more information
// UNDERSTANDING DATA TYPES 
//Q1
//Telephone = long
//Height = string (to denote cm or ft or in), if no units then float
//Age = int
//Gender = string
//Salary = int
//Book ISB = string (for the '-')
//Book price = int
//Book shipping weight = string (denote the units), if no units then float
//country's population = long
//number of stars = long
//num of employee's = int

//Q2
//value type vs reference type
//value holds that value in the variable
//reference points to an address for the actual value
//value's are stored in stacks while the value of the reference is stored in heaps
//boxing and unboxing
//boxing is when you make a value into a reference
//unboxing is when you make a reference into a value

//Q3
//managed vs unmanaged
//managed resources is anything under control of .net and the garbage collector deals with
//unmanaged resources is when you access a resource outside of .net usually under control of OS, garbage collector doesn't deal with

//Q4
//purpose of garbage collector manages the allocations and deallocations of memory 

//PRACTICE NUMBER SIZE AND RANGES

//in another file


//CONTROLLING FLOW AND CONVERTING TYPES 

//Q1
//gives an error

//Q2
//give infinity

//Q3
//gives an error

//Q4
// y++ makes x into y then adds one if there is more after
// ++y makes x into y and adds one on the first iteration

//Q5
//break terminates the loop and and moves on with the code
//continue starts a new loop after the code sees "continue", any code after continue gets skipped
//return will exit current method/loop and move on with the code

//Q6
//initalizer
//condition
//iterator
//all 3 are reqiured

//Q7
// = sets the varible
// == compares the 2 data types

//Q8
// yes but it will be stuck forever in the loop

//Q9
// underscore means deafult, so if it doesn't meet any of the cases it goes to the default expression

//Q10
//The IEnumerable interface

//PRACTIVING LOOPS AND OPERATORS
//Q1
for (int i = 1; i < 101; i++) 
{
    bool three = false;
    bool five = false;
    if (i % 3 == 0) { 
        three = true;
    }
    if (i % 5 == 0)
    {
        five = true;
    }
    if (three && five)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (three)
    {
        Console.WriteLine("fizz");
    }
    else if (five)
    {
        Console.WriteLine("buzz");
    }
    else 
    {
        Console.WriteLine(i);
    }
}

/*int max = 500;
for (byte i = 0; i < max; i++)
{
    WriteLine(i);
}*/
//loops infinitly

//Q2
int max = 5;
for (int i = 1; i < max; i++) 
{
    for (int j = 0+i; j < max; j++) 
    {
        Console.Write(" ");
    }
    for (int k = 0; k < i+i-1; k++) 
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}

//Q3
int correctNumber = new Random().Next(3) + 1;
int guessedNumber = int.Parse(Console.ReadLine());

if (guessedNumber > correctNumber)
{
    Console.WriteLine("your guess was high");
}
if (guessedNumber < correctNumber)
{
    Console.WriteLine("your guess was low");
}
if (guessedNumber == correctNumber)
{
    Console.WriteLine("you got the correct answer!");
}
if (guessedNumber < 1 || guessedNumber > 3) 
{
    Console.WriteLine("your guess was outside of the range of vaild guesses (1 - 3)");
}

//Q4
DateTime bDay = new DateTime(2000, 05, 19);
DateTime today = DateTime.Today;
Console.WriteLine(today.ToString("dd/MM/yyyy"));
var dayDiff = today - bDay;
int days = dayDiff.Days;
int daysToNextAnniversary = 10000 - (days % 10000);
Console.WriteLine("this is my birthday: " + bDay);
Console.WriteLine("this is today: " + today);
Console.WriteLine("this is how many days are between today and my birthday: " + days);
Console.WriteLine("this is how many days there are until my next 10000 day anniversary: " + daysToNextAnniversary);

//Q5
DateTime now = DateTime.Now;

if (now.Hour >= 6 && now.Hour < 12) 
{
    Console.WriteLine("Good Morning");
}
if (now.Hour >= 12 && now.Hour < 17)
{
    Console.WriteLine("Good Afternoon");
}
if (now.Hour >= 17 && now.Hour < 20)
{
    Console.WriteLine("Good Evening");
}
if (now.Hour >= 20 && now.Hour < 24)
{
    Console.WriteLine("Good Night");
}
if (now.Hour >= 0 && now.Hour < 6)
{
    Console.WriteLine("Good Night");
}

//Q6
for (int i = 1; i < 5; i++) 
{
    for (int j = 0; j < 24 + 1; j += i) 
    {
        Console.Write(j);
        if (j != 24) {
            Console.Write(",");
        }
        
    }
    Console.WriteLine("");
}

