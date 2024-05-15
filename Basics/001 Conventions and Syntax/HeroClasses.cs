//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	public Weapon sword;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();
		sword = new Weapon();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.defence = 4;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.defence = 2;

		heroThree.health = 10;
		heroThree.powerLevel = 5;
		heroThree.defence = 20;
		heroThree.sword = "Xcalibur";

		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		Console.WriteLine(heroOne.defence);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
		Console.WriteLine(heroTwo.defence);

		Console.WriteLine(heroThree.health);
		Console.WriteLine(heroThree.powerLevel);
		Console.WriteLine(heroThree.defence);
		Console.WriteLine(heroThree.Sword);
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public int defence; 
	public String sword; 
}