namespace human {
    public class Human {
        public string name {get; set;}
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }

        public Human(string val)
        {
            this.name = val;
            this.strength = 3;
            this.intelligence = 3;
            this.dexterity = 3;
            this.health = 100;
        }
        public int attack(Human human){
            int attack = this.strength *  5;
            human.health -= attack;
            return human.health;
        }
        
    }
}