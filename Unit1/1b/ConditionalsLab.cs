using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Welcome");
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 7);
		myOperator.DoMath(30, 15);
		myOperator.Compare(4,3);
		myOperator.Compare(3,4);
		myOperator.CheckPassword("SevenOF9");
		myOperator.CheckPassword("OU812");
	}
}

public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void DoMath (int value, int value2, int value3){
		var number = value + value2 + value3;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, the first greater.");
			if (value/value2 == 2) {
				Console.WriteLine("The first is twice a big");
			}
		} else {
			Console.WriteLine("False, the second is greater.");
		}
	}
	
	public void CheckPassword (string password) {
		if(password == "OU812") {
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");	
		}
	}
	
	public void CheckOneThruTen(int num){
		switch num{
			case 1:
				Console.WriteLine("That is a number 1 - 10. It is " + num + ".");
				break;
			case 2:
				Console.WriteLine("That is a number 1 - 10. It is " + num + ".");
				break;
			case 3:
				Console.WriteLine("That is a number 1 - 10. It is " + num + ".");
				break;
			case 4:
				Console.WriteLine("That is a number 1 - 10. It is " + num + ".");
				break;	
			case 5:
				Console.WriteLine("That is a number 1 - 10. It is " + num + ".");
				break;	
			case 6:
				Console.WriteLine("That is a number 1 - 10. It is " + num + ".");
				break;
			case 7:
				Console.WriteLine("That is a number 1 - 10. It is " + num + ".");
				break;
			case 8:
				Console.WriteLine("That is a number 1 - 10. It is " + num + ".");
				break;
			case 9:
				Console.WriteLine("That is a number 1 - 10. It is " + num + ".");
				break;
			case 10:
				Console.WriteLine("That is a number 1 - 10. It is " + num + ".");
				break;
			default:
				Console.WriteLine("That is not a number 1 - 10 (inclusive)");
				break;
		}
	}
}
