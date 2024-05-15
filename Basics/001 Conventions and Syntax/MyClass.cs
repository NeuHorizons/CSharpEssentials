//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
using System;
					
public class Program
{

 public Health PresidentsHealth;
 public Damage Bullet;
	
	public void Main()
	{
        PresidentsHealth = new Health();
		Bullet = new Damage();

        
		Health.PresidentsHealth -= Damage.Bullet;
		//this is for the program to write it out in the display
		Console.WriteLine("Hello Wor... IM ALIVE");
        Console.WriteLine("GET DOWN MR PRESIDENT!!!");
        Console.WriteLine("BANG!!!");
		// adding some code to the WriteLine
        Console.WriteLine("Health.Name + " WARNING HEALTH HALF WAY!!! " + Health.PresidentsHealth + ".");

	}
public class Health { 
	// this is the health of the president 
	public int PresidentsHealth = 50;
    public string Name = "President";
}
public class Damage { 
	// this is the damage i could add to the presidents health
	public int Bullet = 25;
}

}