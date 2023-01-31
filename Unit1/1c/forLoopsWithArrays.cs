using System;

public class Program{
    public static void Main(string[] args){
        int[] numbersTil10 = new int[10];
        Console.WriteLine("Here's all the numbers 1-10: ");
        for (int i = 0; i < numbersTil10.Length; i++){
            numbersTil10[i] = i  + 1;
            Console.Write(numbersTil10[i]);
            if (i != 9){
                Console.Write(", ");
            }
            else {
                Console.WriteLine(".\n");
            }
        }
        Console.WriteLine("Here's all the odd numbers 1-10: ");
        for (int i = 0; i < 10; i += 2){
            Console.Write(numbersTil10[i]);
            if (i != 8){
                Console.Write(", ");
            }
            else {
                Console.WriteLine(".\n");
            }
        }
        Console.WriteLine("Here's all the even numbers 1-10: ");
        for (int i = 1; i < numbersTil10.Length; i += 2){
            Console.Write(numbersTil10[i]);
            if (i != 9){
                Console.Write(", ");
            }
            else {
                Console.WriteLine(".\n");
            }
        }
    }
}