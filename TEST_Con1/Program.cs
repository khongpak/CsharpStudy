using System;
using System.Runtime.CompilerServices;

class Program{
    private Number1 thisNumber = new Number1();
    public static void Main(){
        Program program = new Program();
        Console.WriteLine("Hello World");
        Console.WriteLine(program.thisNumber.GetNumber());

    }
}