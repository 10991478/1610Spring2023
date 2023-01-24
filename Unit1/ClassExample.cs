//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

public class ClassExample
{
    
}

public class ClassWithVariables
{
    public int number = 2;
    public string userName = "Bob";
    private static bool weirdName = true;
    public int x;
    x = 3;
    x++;
}

public class ClassWithFunctions
{
    public void RunFunction()
    {
        Console.WriteLine("Running Function");
    }
    
    public void countToNum(int s){
        for (int i = 1; i < s+1; i++){
            Console.WriteLine(i + "...");
        }
    }
}   
