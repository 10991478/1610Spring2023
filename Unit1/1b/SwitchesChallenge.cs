using System;
using System.Collections.Generic;

class Program {
    static Attack thunderThighs = new Attack("thunder thighs", "electric", 30);
    static Attack headButt = new Attack("head butt", "normal", 15);
    static Attack lightningPunch = new Attack("lightning punch", "electric", 40);
    static Pikachu myPikachu = new Pikachu();
    public static void Main (string[] args) {
        Console.WriteLine("What would you like your Pikachu's name to be?");
        myPikachu.name = Console.ReadLine();
        myPikachu.attacks.Add(thunderThighs);
        myPikachu.attacks.Add(headButt);
        myPikachu.attacks.Add(lightningPunch);
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
}
