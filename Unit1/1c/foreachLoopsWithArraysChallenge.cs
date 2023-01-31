using System;

public class Program{

    public static void Main(string[] args){
        bool valid = false;
        string answer;
        do {
            Console.WriteLine("How many items would you like in your array?");
            answer = Console.ReadLine();
            valid = Convert.toInt(answer).getValid();
            if (!valid){
                Console.WriteLine("Please enter a valid number\n");
            }
        } while (!valid);
        string[] myArray = new string[Convert.toInt(answer).getInt()];
        int i = 0;
        foreach (string item in myArray){
            Console.WriteLine("What would you like item " + (i+1) + " to be?");
            myArray[i] = Console.ReadLine();
            i++;
        }

        i = 1;
        Console.WriteLine("\n\nOk, here's all your items!\n");
        foreach (string item in myArray){
            Console.Write(item);
            if (i == myArray.Length){
                Console.WriteLine(".");
            }
            else {
                Console.Write(", ");
            }
            i++;
        }
    }
}

public class Convert{
    bool isValid;
    int intValue;
    public Convert(bool b, int n){
        this.isValid = b;
        this.intValue = n;
    }

    public int getInt(){
        return this.intValue;
    }
    public bool getValid(){
        return this.isValid;
    }

    public static Convert toInt(string str){
        bool valid = true;
        int i = 0;
        Convert converted = new Convert(true, 0);
        while (valid){
            char character = str[i];
            switch (character){
                case '0':
                    converted.intValue *= 10;
                    break;
                case '1':
                    converted.intValue *= 10;
                    converted.intValue++;
                    break;
                case '2':
                    converted.intValue *= 10;
                    converted.intValue += 2;
                    break;
                case '3':
                    converted.intValue *= 10;
                    converted.intValue += 3;
                    break;
                case '4':
                    converted.intValue *= 10;
                    converted.intValue += 4;
                    break;
                case '5':
                    converted.intValue *= 10;
                    converted.intValue += 5;
                    break;
                case '6':
                    converted.intValue *= 10;
                    converted.intValue += 6;
                    break;
                case '7':
                    converted.intValue *= 10;
                    converted.intValue += 7;
                    break;
                case '8':
                    converted.intValue *= 10;
                    converted.intValue += 8;
                    break;
                case '9':
                    converted.intValue *= 10;
                    converted.intValue += 9;
                    break;
                case ' ':
                    break;
                default:
                    valid = false;
                    converted.isValid = false;
                    break;
            }
            i++;
            if (i == str.Length){
                valid = false;
            }
        }

        return converted;
    }
}
