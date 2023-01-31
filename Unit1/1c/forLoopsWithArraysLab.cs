using System;

public class Program{
    public static void Main(string[] args){
        string[] myStuff = {"keys","wallet","car","dog","cat","mortgage","divorce papers","lawyer"};
        Console.WriteLine("Here's all the stuff I currently have: ");
        for (int i = 0; i < myStuff.Length; i++){
            Console.Write(myStuff[i]);
            if (i != myStuff.Length - 1){
                Console.Write(", ");
            }
            else {
                Console.WriteLine(".\n");
            }
        }
        Console.WriteLine("Let's change a couple of those!");
        myStuff[myStuff.Length - 2] = "happy marriage";
        myStuff[myStuff.Length - 1] = "child on the way";
        Console.WriteLine("\nOkay, the changes have been made! Let's see what I've got now: ");
        for (int i = 0; i < myStuff.Length; i++){
            Console.Write(myStuff[i]);
            if (i != myStuff.Length - 1){
                Console.Write(", ");
            }
            else {
                Console.WriteLine(".\n");
                Console.WriteLine("There! Isn't that much better?");
            }
        }
    }
}
