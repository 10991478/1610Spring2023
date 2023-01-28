using System;

class Program {
    Attack thunderThighs = new Attack("thunder thighs", "electric", 30);
    Attack headButt = new Attack("head butt", "normal", 15);
    Attack lightningPunch = new Attack("lightning punch", "electric", 40);
    Pikachu myPikachu = new Pikachu();
    public static void Main (string[] args) {
    
    }
}

class Pikachu{
    public int health = 100;
    public string name;
    Attack[] attacks;
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
