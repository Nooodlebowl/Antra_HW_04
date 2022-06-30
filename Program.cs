// See https://aka.ms/new-console-template for more information
//sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
using System;
public static class assignment
{
    public static void Main() 
    {
        string[] types = { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal" };
        Console.WriteLine("{0,-10} {1,10} {2,-30} {3,-10}\n", "Name", "bytes", "Max", "Min");
        Console.WriteLine("{0,-10} {1,10} {2,-30} {3,-10}\n", types[0], sizeof(sbyte), sbyte.MaxValue, sbyte.MinValue);
        Console.WriteLine("{0,-10} {1,10} {2,-30} {3,-10}\n", types[1], sizeof(byte), byte.MaxValue, byte.MinValue);
        Console.WriteLine("{0,-10} {1,10} {2,-30} {3,-10}\n", types[2], sizeof(short), short.MaxValue, short.MinValue);
        Console.WriteLine("{0,-10} {1,10} {2,-30} {3,-10}\n", types[3], sizeof(ushort), ushort.MaxValue, ushort.MinValue);
        Console.WriteLine("{0,-10} {1,10} {2,-30} {3,-10}\n", types[4], sizeof(int), int.MaxValue, int.MinValue);
        Console.WriteLine("{0,-10} {1,10} {2,-30} {3,-10}\n", types[5], sizeof(uint), uint.MaxValue, uint.MinValue);
        Console.WriteLine("{0,-10} {1,10} {2,-30} {3,-10}\n", types[6], sizeof(long), long.MaxValue, long.MinValue);
        Console.WriteLine("{0,-10} {1,10} {2,-30} {3,-10}\n", types[7], sizeof(ulong), ulong.MaxValue, ulong.MinValue);
        Console.WriteLine("{0,-10} {1,10} {2,-30} {3,-10}\n", types[8], sizeof(float), float.MaxValue, float.MinValue);
        Console.WriteLine("{0,-10} {1,10} {2,-30} {3,-10}\n", types[9], sizeof(double), double.MaxValue, double.MinValue);
        Console.WriteLine("{0,-10} {1,10} {2,-30} {3,-10}\n", types[10], sizeof(decimal), decimal.MaxValue, decimal.MinValue); ;
        assignment.convertCen(5);
    }
    public static void convertCen(int i) 
    {
        Console.WriteLine($"{i} centuries = {i *100} years = {i * 36524} days = {i * 876576} hours = {i * 52594560} minutes = {i * 3155673600} seconds = {i * 3155673600000} milliseconds = {i* 3155673600000000} microseconds = {i * 3155673600000000000} nanoseconds");
    }
}

