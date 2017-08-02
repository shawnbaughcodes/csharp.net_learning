using System;

namespace human {
	public class Human
	{
		public string name { get; set; }

		//The { get; set; } format creates accessor methods for the field specified
		//This is done to allow flexibility
		public int health { get; set; }
		public int strength { get; set; }
		public int intelligence { get; set; }
		public int dexterity { get; set; }

		public Human(string person)
		{
			name = person;
			strength = 3;
			intelligence = 3;
			dexterity = 3;
			health = 100;
		}
		public Human(string person, int str, int intel, int dex, int hp)
		{
			name = person;
			strength = str;
			intelligence = intel;
			dexterity = dex;
			health = hp;
		}
		public void attack(object obj)
		{
			Human enemy = obj as Human;
			if (enemy == null)
			{
				
			}
			else{
				enemy.health -= strength * 5;
			}
		}
	}
	public class Wizard : Human
    {
		public Wizard(string name) : base(name)
		{
			health = 50;
			intelligence = 25;
		}

		public void heal(Human obj){
			health += 10;
		}
		public void fireball(object obj){
			Random rand = new Random();
			int num = rand.Next(20,50);
			health -= num;
		}
    }
	public class Ninja : Human {
		public Ninja(string name) : base(name){
			dexterity = 175;
		}
		public void steal(Human obj){
			health += 10;
		}
		public void get_away(){
			health -= 15;
		}
	}
	public class Samurai : Human {
		public Samurai(string name) : base(name){
			health = 200;
		}
		public void death_blow(Human obj){
			if (obj.health < 50)
			{
				obj.health = 0;
			} else {
				health = 50;
			}

		}
		public void meditate(){
			health = 100;
			Console.WriteLine("I'm and happy little jewish boy");
		}

	}
}