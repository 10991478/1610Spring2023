using System;

class Program {
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
