using System;

public class Program {
    public static void Main(string[] args){
        int i = 1;
        Console.WriteLine("i is starting at 1.\nWe're gonna run a while loop\nand a do while loop that run on the\ncondition that i is less than 1.\nWithin the loop, we'll print the value\nof i and then add 1 to i\nbefore the end of the loop.");
        Console.WriteLine("\nHere's the while loop: ");
        while (i < 1){
            Console.WriteLine("The value of i is " + i);
            i++;
        }
        Console.WriteLine("\nHere's the do while loop: ");
        do {
            Console.WriteLine("The value of i is " + i);
            i++;
        } while (i < 1);
        Console.WriteLine("\nNotice how the while loop didn't run?\nBecause i starts at 1,\nit doesn't meet the condition of i < 1\nfor the while loop to run.\nThe do while loop runs the loop before checking\nfor the condition, so it still ran once before checking i.");
    }
}
