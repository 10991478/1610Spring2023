using System;
using System.Collections.Generic;

class Program {
    static Attack thunderThighs = new Attack("thunder thighs", "electric", 30);
    static Attack headButt = new Attack("head butt", "normal", 15);
    static Attack lightningPunch = new Attack("lightning punch", "electric", 40);
    static Attack yoMama = new Attack("yo mama", "fire", 75);
    static Pikachu myPikachu = new Pikachu();
    static Pikachu enemyPikachu = new Pikachu();
    public static void Main (string[] args) {
        Console.WriteLine("What would you like your Pikachu's name to be?");
        myPikachu.name = Console.ReadLine();
        myPikachu.attacks.Add(thunderThighs);
        myPikachu.attacks.Add(headButt);
        myPikachu.attacks.Add(lightningPunch);
        enemyPikachu.name = ">:(";
        enemyPikachu.attacks.Add(thunderThighs);
        enemyPikachu.attacks.Add(yoMama);
    }
}

class Pikachu{
    public int health = 100;
    public string name;
    public List<Attack> attacks = new List<Attack>();
}

class Attack{
    public string name;
    public string type;
    public int damage;
    public Attack(string n, string t, int d){
        this.name = n;
        this.type = t;
        this.damage = d;
    }
    
    public void fight(Pikachu peepee){
        bool continueAsking = true;
        while (continueAsking == true){
            Console.WriteLine("You've encountered a wild pikachu! \n \n Which attack would you like to use?");
            for (int i = 1; i <= peepee.attacks.Count; i++){
                Console.WriteLine(i + ": " + peepee.attacks[i-1]);
            }
            string chosen = Console.ReadLine();
        }
    }
}
