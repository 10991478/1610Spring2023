
using System;
using System.Collections.Generic;



//setting up the gameplay
public class Program
{
    public static void Main(string[] args)
    {
        //dealing player in
        List<Card> player = new List<Card>();
        player.Add(new Card());
        player[0].randCard(true);
        player.Add(new Card());
        player[1].randCard(true);
        Card.checkAce(player);
        bool playerTurn = true;

        //dealing the house in
        List<Card> house = new List<Card>();
        house.Add(new Card());
        house[0].randCard(false);
        house.Add(new Card());
        house[1].randCard(true);
        Card.checkAce(house);

        //running the player's turn
        Console.WriteLine("\n\nHouse's hand: ");
        Card.printHand(house);
        Card.printHandValue(house);
        Console.WriteLine("\n\nPlayer's hand: ");
        Card.printHand(player);
        Card.printHandValue(player);
        while (playerTurn == true)
        {
            if (Card.getHandValue(player) <= 21)
            {
                string answer = " ";
                while (answer != "stand" && answer != "hit")
                {
                    Console.WriteLine("Would you like to stand, or hit?");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                }
                if (answer == "hit")
                {
                    player.Add(new Card());
                    player[player.Count - 1].randCard(true);
                    Card.checkAce(player);
                    Card.printHand(player);
                    Card.printHandValue(player);
                    if (Card.getHandValue(player) > 21)
                    {
                        Console.WriteLine("Bust! House wins!");
                        playerTurn = false;
                    }
                    else
                    {
                        answer = " ";
                    }
                }
                else
                {
                    playerTurn = false;
                }
            }
        }
        //running the house/s turn
        house[0].flipCard();
        Console.WriteLine("\n\nHouse's hand: ");
        Card.printHand(house);
        Card.printHandValue(house);
        if (Card.getHandValue(player) <= 21)
        {
            while (Card.getHandValue(house) < 17)
            {
                Console.WriteLine("Hit");
                house.Add(new Card());
                house[house.Count - 1].randCard(true);
                Card.checkAce(house);
                Console.WriteLine("\n\nHouse's hand: ");
                Card.printHand(house);
                Card.printHandValue(house);
                if (Card.getHandValue(house) > 21)
                {
                    Console.WriteLine("Bust! Player wins!");
                }
            }
        }
        if (Card.getHandValue(player) <= 21)
        {
            if (Card.getHandValue(house) == 21 || Card.getHandValue(house) == Card.getHandValue(player) || Card.getHandValue(house) > Card.getHandValue(player) && Card.getHandValue(house) <= 21)
            {
                Console.WriteLine("House wins!");
            }
            else if (Card.getHandValue(player) > Card.getHandValue(house) && Card.getHandValue(house) <= 21)
            {
                Console.WriteLine("Player wins!");
            }
        }
    }
}






//making the card class
public class Card
{
    Random rand = new Random();

    //making all the arrays containing the faces and values
    string[] valueStr = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
    int[] valueInt = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
    string[] faceStr = { "clubs", "hearts", "diamonds", "spades" };
    string[] faceSym = { "♣", "♥", "♦", "♠" };

    //declaring all the card variables
    private string face;
    private string value;
    private string symbol;
    private int numVal;
    private bool revealed;

    //making the randomizing methods
    public void randCard(bool rev)
    {
        int i = rand.Next(13);
        this.value = valueStr[i];
        this.numVal = valueInt[i];
        i = rand.Next(4);
        this.face = faceStr[i];
        this.symbol = faceSym[i];
        this.revealed = rev;
    }

    //making the getter methods + numVal setter method & flipCard setter method
    public string getFace()
    {
        return this.face;
    }
    public string getValue()
    {
        return this.value;
    }
    public string getSymbol()
    {
        return this.symbol;
    }
    public int getNumVal()
    {
        return this.numVal;
    }
    public bool isRevealed()
    {
        return this.revealed;
    }
    public void flipCard()
    {
        this.revealed = !this.revealed;
    }
    public void setNumVal(int i)
    {
        this.numVal = i;
    }

    //making the hand value methods
    public static int getHandValue(List<Card> lst)
    {
        int total = 0;
        foreach (Card c in lst)
        {
            total += c.getNumVal();
        }
        return total;
    }

    public static void printHandValue(List<Card> lst)
    {
        int total = 0;
        bool allShowing = true;
        foreach (Card c in lst)
        {
            if (c.isRevealed() == true)
            {
                total += c.getNumVal();
            }
            else
            {
                allShowing = false;
            }
        }
        Console.Write("Hand total = " + total);
        if (allShowing == false)
        {
            Console.Write(" + ?");
        }
        Console.WriteLine("");
    }

    //making the checkAce method
    public static void checkAce(List<Card> lst)
    {
        if (getHandValue(lst) > 21)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].getValue() == "A" && lst[i].getNumVal() != 1)
                {
                    lst[i].setNumVal(1);
                    break;
                }
            }
        }
    }

    //making the printHand method
    public static string[] cardDisplay = { " ---------------- ", "|                |", "|  ", "             |", "|                |", "|                |", "|                |", "|                |", "|       ", "        |", "|                |", "|                |", "|                |", "|                |", "|             ", "  |", "|                |", " ---------------- " };
    public static void printHand(List<Card> hand)
    {
        for (int i = 0; i < 18; i++)
        {
            for (int p = 0; p < hand.Count; p++)
            {
                if (hand[p].isRevealed() == true)
                {
                    switch (i)
                    {
                        case 2:
                            Console.Write(cardDisplay[i] + hand[p].getValue());
                            if (hand[p].getValue() == "10")
                            {
                                Console.Write("            |   ");
                            }
                            else
                            {
                                Console.Write(cardDisplay[i + 1] + "   ");
                            }
                            break;
                        case 14:
                            Console.Write(cardDisplay[i] + hand[p].getValue());
                            if (hand[p].getValue() == "10")
                            {
                                Console.Write(" |   ");
                            }
                            else
                            {
                                Console.Write(cardDisplay[i + 1] + "   ");
                            }
                            break;
                        case 8:
                            Console.Write(cardDisplay[i] + hand[p].getSymbol() + cardDisplay[i + 1] + "   ");
                            break;
                        default:
                            Console.Write(cardDisplay[i] + "   ");
                            break;
                    }
                }
                else if (i == 2 || i == 8 || i == 14)
                {
                    if (i == 8)
                    {
                        Console.Write(cardDisplay[i] + " " + cardDisplay[i + 1] + "   ");
                    }
                    else
                    {
                        Console.Write(cardDisplay[i] + "?" + cardDisplay[i + 1] + "   ");
                    }
                }
                else
                {
                    Console.Write(cardDisplay[i] + "   ");
                }
            }
            if (i == 2 || i == 8 || i == 14)
            {
                i++;
            }
            Console.WriteLine("");
        }
    }
}
