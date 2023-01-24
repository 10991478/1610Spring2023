//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
		
		heroThree.health = 69;
		heroThree.powerLevel = 7;
		heroThree.name = "Jojo";
		Console.WriteLine(heroThree.name + " has " + heroThree.health + " health and is level " + heroThree.powerLevel + ".");
		heroThree.die();
		Console.WriteLine(heroThree.name + " has " + heroThree.health + " health. " + heroThree.name + " is dead.");
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public string name;
	public void die(){
		this.health = 0;
	}
}
