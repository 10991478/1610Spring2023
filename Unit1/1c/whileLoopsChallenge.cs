using System;

public class Program{
    public static void Main(string[] args){
        string answer;
        bool valid = false;
        do {
            Console.WriteLine("How long would you like your scream to be?");
            answer = Console.ReadLine();
            if (Convert.toInt(answer).getValid()){
                valid = true;
            }
            else {
                Console.WriteLine("Please give a valid number.\n");
            }
        } while (!valid);
        int l = Convert.toInt(answer).getInt();
        Say.scream(l);
    }
}

public class Say{
    public static void scream(int lngth){
        string scrm = "AH";
        while (scrm.Length < lngth){
            if (scrm.Length % 4 == 0){
                scrm = "A" + scrm;
            }
            else {
                scrm += "H";
            }
        }

        Console.WriteLine(scrm);
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
            converted.intValue *= 10;
            switch (character){
                case '0':
                    break;
                case '1':
                    converted.intValue++;
                    break;
                case '2':
                    converted.intValue += 2;
                    break;
                case '3':
                    converted.intValue += 3;
                    break;
                case '4':
                    converted.intValue += 4;
                    break;
                case '5':
                    converted.intValue += 5;
                    break;
                case '6':
                    converted.intValue += 6;
                    break;
                case '7':
                    converted.intValue += 7;
                    break;
                case '8':
                    converted.intValue += 8;
                    break;
                case '9':
                    converted.intValue += 9;
                    break;
                case ' ':
                    converted.intValue /= 10;
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