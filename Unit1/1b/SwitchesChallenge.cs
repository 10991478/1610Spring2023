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
        Pikachu.chooseName(myPikachu);
        myPikachu.attacks.Add(thunderThighs);
        myPikachu.attacks.Add(headButt);
        myPikachu.attacks.Add(yoMama);
        enemyPikachu.name = "baddie";
        enemyPikachu.attacks.Add(thunderThighs);
        enemyPikachu.attacks.Add(lightningPunch);

        Attack.fight(myPikachu, enemyPikachu);
    }
}

class Pikachu{
    public int health = 100;
    public string name;
    public string type = "electric";
    public List<Attack> attacks = new List<Attack>();

    public int isAnAttack(string s){
        int atk = -1;
        for (int i = 0; i < this.attacks.Count; i++){
            if (s == this.attacks[i].name){
                atk = i;
                break;
            }
        }
        return atk;
    }

    public static void chooseName(Pikachu pika){
        Console.WriteLine("Pick a number!");
        string nameNum = "invalid";
        while (nameNum != "1" && nameNum != "2" && nameNum != "3" && nameNum != "4" && nameNum != "5"){
            Console.WriteLine("1: Jonnyboi\n2: Antspants\n3: Scannerjohn\n4: :O (surprised pikachu face)\n5: Carl");
            nameNum = Console.ReadLine();
        }
        switch (nameNum){
            case "1":
            pika.name = "Jonnyboi";
            break;
            case "2":
            pika.name = "Antspants";
            break;
            case "3":
            pika.name = "Scannerjohn";
            break;
            case "4":
            pika.name = ":O";
            break;
            case "5":
            pika.name = "Carl";
            break;
        }
    }
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
    
    public static void fight(Pikachu peepee, Pikachu enem){
        bool continueAsking = true;
        string chosen = ("notChosenYet");
        while (continueAsking == true){
            Console.WriteLine("You've encountered a wild pikachu!\n\nWhich attack would you like to use?");
            for (int i = 0; i < peepee.attacks.Count; i++){
                Console.WriteLine(peepee.attacks[i].name);
            }
            chosen = Console.ReadLine();
            chosen = chosen.ToLower();
            if (peepee.isAnAttack(chosen) > -1){
                continueAsking = false;
            }
            else {
                Console.WriteLine("Pick a valid option.");
            }
        }
        int atkIndex = peepee.isAnAttack(chosen);
        Attack currentAttack = peepee.attacks[atkIndex];
        Console.WriteLine(peepee.name + " used " + currentAttack.name + " against enemy pikachu!");
        int damageDone = currentAttack.damage;
        if (currentAttack.type == enem.type){
            Console.WriteLine("It was kinda weak, ngl");
            damageDone -= 10;
        }
        else if (currentAttack.type == "normal"){
            Console.WriteLine("It wasn't very effective");
        }
        else {
            Console.WriteLine("It was super effective!");
            damageDone += 15;
        }
        enem.health -= damageDone;
        Console.WriteLine(peepee.name + " did " + damageDone + " damage");
        Console.WriteLine(enem.name + " has " + enem.health + " hp left.");
    }
}
