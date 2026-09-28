using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

/*  1  
 public class ArschStats
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int MaxExperience { get; set; }
    public string Title { get; set; }
    public int CurrentReputation { get; set; }
    public int MaxReputation { get; set; }
    public int CurrentHealth { get; set; }
    public int MaxHealth { get; set; }
    public int CurrentStamina { get; set; }
    public int MaxStamina { get; set; }
    public int CurrentEndurance { get; set; }
    public int MaxEndurance { get; set; }
    public int Break { get; set; }
    public int Toughness { get; set; }
    public int MinAttack { get; set; }
    public int MaxAttack { get; set; }
    public int Defense { get; set; }
    public double CriticalRatePercentage { get; set; }   
    public double CriticalDamagePercentage { get; set; } 
    public int Luck { get; set; }

    public ArschStats(
        string name, int level, int Exp, int maxExp,
        string title, int currentRep, int maxRep,
        int currentHp, int maxHp, int currentStamina, int maxStamina,
        int currentEndurance, int maxEndurance, int breakValue, int toughness,
        int minAttack, int maxAttack, int defense, double critRate, double critDmg, int luck)
    {
        Name = name;
        Level = level;
        Experience = Exp;
        MaxExperience = maxExp;
        Title = title;
        CurrentReputation = currentRep;
        MaxReputation = maxRep;
        CurrentHealth = currentHp;
        MaxHealth = maxHp;
        CurrentStamina = currentStamina;
        MaxStamina = maxStamina;
        CurrentEndurance = currentEndurance;
        MaxEndurance = maxEndurance;
        Break = breakValue;
        Toughness = toughness;
        MinAttack = minAttack;
        MaxAttack = maxAttack;
        Defense = defense;
        CriticalRatePercentage = critRate;
        CriticalDamagePercentage = critDmg;
        Luck = luck;
    }

    public void DisplayStats()
    {
        Console.WriteLine($"=== Character: {Name} (Lvl {Level}) ===");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"EXP: {Experience} / {MaxExperience}");
        Console.WriteLine($"REP: {CurrentReputation} / {MaxReputation}");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"Health: {CurrentHealth} / {MaxHealth}");
        Console.WriteLine($"Stamina: {CurrentStamina} / {MaxStamina}");
        Console.WriteLine($"Endurance: {CurrentEndurance} / {MaxEndurance}");
        Console.WriteLine($"BREAK: {Break}");
        Console.WriteLine($"Toughness: {Toughness}");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"Attack: {MinAttack}-{MaxAttack}");
        Console.WriteLine($"Defense: {Defense}");
        Console.WriteLine($"Critical Rate: {CriticalRatePercentage * 100}%");
        Console.WriteLine($"Critical Damage: {CriticalDamagePercentage * 100}%");
        Console.WriteLine($"Luck: {Luck}");
    }
}

class Program
{
    static void Main()
    {

        ArschStats player = new ArschStats(
            name: "Art",
            level: 54,
            Exp: 208613,
            maxExp: 239503,
            title: "Blank Slate",
            currentRep: 38193,
            maxRep: 150000,
            currentHp: 9218,
            maxHp: 9218,
            currentStamina: 742,
            maxStamina: 742,
            currentEndurance: 149,
            maxEndurance: 149,
            breakValue: 3,
            toughness: 16,
            minAttack: 943,
            maxAttack: 1014,
            defense: 749,
            critRate: 0.41,
            critDmg: 1.58,
            luck: 482
        );

        player.DisplayStats();
    }
}
*/

/*            2  
public class WalterKurzStats
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int MaxLevel { get; set; }
    public int Experience { get; set; }
    public int MaxExperience { get; set; }
    public int CurrentHealth { get; set; }
    public int MaxHealth { get; set; }
    public int KillingOfVietnamese { get; set; }
    public int KillingOfAmericans { get; set; }
    public int CuttedHeads { get; set; }
    public int TotalKills { get; set; }
    public int CurrentReputation { get; set; }
    public int MaxReputation { get; set; }

    public WalterKurzStats(
        string name, int level, int maxLevel, int exp,
        int maxExp, int currentHp, int maxHp,
        int killingOfVietnamese, int killingOfAmericans,
        int cuttedHeads, int currentRep, int maxRep)
    {
        Name = name;
        Level = level;
        MaxLevel = maxLevel;
        Experience = exp;
        MaxExperience = maxExp;
        CurrentHealth = currentHp;
        MaxHealth = maxHp;
        KillingOfAmericans = killingOfAmericans;
        KillingOfVietnamese = killingOfVietnamese;
        CuttedHeads = cuttedHeads;
        CurrentReputation = currentRep;
        MaxReputation = maxRep;

    }

    public void DisplayStats()
    {
        Console.WriteLine($"=== Character: {Name} (Lvl {Level}/{MaxLevel}) ===");
        Console.WriteLine($"EXP: {Experience} / {MaxExperience}");
        Console.WriteLine($"REP: {CurrentReputation} / {MaxReputation}");
        Console.WriteLine($"Health: {CurrentHealth} / {MaxHealth}");
        Console.WriteLine($"Killing of Vietnamese: {KillingOfVietnamese}");
        Console.WriteLine($"Killing of Americans: {KillingOfAmericans}");
        Console.WriteLine($"Cutted Heads: {CuttedHeads}");
        Console.WriteLine($"Total Kills: {KillingOfVietnamese + KillingOfAmericans}");
        Console.WriteLine("---------------------------------------");
    }
}
class Program
{
    static void Main()
    {

        WalterKurzStats player = new WalterKurzStats(
            name: "Walter Kurz",
            level: 101,
            maxLevel: 100,
            exp: 208613,
            maxExp: 200000,
            currentRep: 101,
            maxRep: 100,
            currentHp: 1001,
            maxHp: 1000,
            killingOfVietnamese: 1793,
            killingOfAmericans: 94,
            cuttedHeads: 987
        );

        player.DisplayStats();
    }
} */


/* 3
class Program
{
    class Player
    {
        public string Name { get; set; }
        public int TotalScore { get; set; }

        public Player(string name)
        {
            Name = name;
            TotalScore = 0;
        }
    }
    static Random random = new Random();

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Player player1 = new Player("Гравець 1");
        Player player2 = new Player("Гравець 2");

        Console.WriteLine("=== ПОЧАТОК ГРИ  (10 РАУНДІВ) ===\n");

        for (int round = 1; round <= 10; round++)
        {
            Console.WriteLine($"--- РАУНД {round} ---");
            int roundScore1 = oneRound(player1);

            int roundScore2 = oneRound(player2);

            if (roundScore1 > roundScore2)
            {
                Console.WriteLine($"Результат раунду: Переміг {player1.Name}!\n");
            }
            else if (roundScore2 > roundScore1)
            {
                Console.WriteLine($"Результат раунду: Переміг {player2.Name}!\n");
            }
            else
            {
                Console.WriteLine("Результат раунду: Нічия!\n");
            }
        }
        Console.WriteLine("=====================================");
        Console.WriteLine("ФІНАЛЬНІ РЕЗУЛЬТАТИ:");
        Console.WriteLine($"{player1.Name}: {player1.TotalScore} очок");
        Console.WriteLine($"{player2.Name}: {player2.TotalScore} очок");
        Console.WriteLine("----------------------------------------");

        if (player1.TotalScore > player2.TotalScore)
        {
            Console.WriteLine($"Переможець: {player1.Name}! ");
        }
        else if (player2.TotalScore > player1.TotalScore)
        {
            Console.WriteLine($"Переможець: {player2.Name}! ");
        }
        else
        {
            Console.WriteLine("Нічия! ");
        }
    }

    static int werfenDice()
    {
        return random.Next(1, 7);
    }

    static int oneRound(Player currentPlayer)
    {
        int dice1 = werfenDice();
        int dice2 = werfenDice();
        int roundTotal = dice1 + dice2;

        currentPlayer.TotalScore += roundTotal;

        Console.WriteLine($"{currentPlayer.Name} кидає кубики: [{dice1}] та [{dice2}] (Сума: {roundTotal})");

        return roundTotal;
    }
} */

