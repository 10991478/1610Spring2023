using System;

public class Program{
    public static void Main(string[] args){
        Console.WriteLine("A for loop that counts to 10 by 1s, starting at 1: ");
        for (int i = 1; i <= 10; i++){
            Console.WriteLine(i);
        }
        Console.WriteLine("\nA for loop that counts to 50 by 5s, starting at 0: ");
        for (int n = 0; n <= 50; n += 5){
            Console.WriteLine(n);
        }
        string[] daysOfTheWeek = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};
        Console.WriteLine("\nA foreach loop that prints all the days of the week: ");
        foreach(string day in daysOfTheWeek){
            Console.WriteLine(day);
        }
    }
}