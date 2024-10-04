Console.WriteLine("Welcome to Knight vs Goblin");
Console.WriteLine("---------------------------");

Random randomNumberGenerator = new Random();

int knightHealth;
int goblinHealth = randomNumberGenerator.Next(50, 101);

int attackKnight = 10;

Console.Write("Enter knight health (1-100): ");
string chosenHealthInput = Console.ReadLine();

if (int.TryParse(chosenHealthInput, out knightHealth))
{
    if (knightHealth <= 0 && knightHealth > 100)
    {
        //ongeldig getal ingegeven
        Console.WriteLine("Invalid input, value 100 is used.");
        knightHealth = 100;
    }
}
else {
    //ongeldig getal ingegeven
    Console.WriteLine("Invalid input, value 100 is used.");
    knightHealth = 100;
}
while (knightHealth > 0 && goblinHealth > 0)
{
    int attempts;
    attempts =+ 1;
    Console.WriteLine();
    Console.WriteLine($"Round {attempts}");

    int attackGoblin = randomNumberGenerator.Next(5, 16);

    Console.WriteLine("Pick a move:");
    Console.WriteLine("1. Attack");
    Console.WriteLine("2. Heal");

 
    switch (Console.ReadLine())
    {
        case "1":
            goblinHealth -= attackKnight;
            Console.WriteLine($"Knight attacks goblin for {attackKnight} hp.");
            Console.WriteLine($"Goblin now has {goblinHealth} hp.");
            break;
        case "2":
            knightHealth += 10;
            Console.WriteLine($"Knight healed for 10 hp.");
            Console.WriteLine($"Knight now has {knightHealth} hp.");

            break;
        default:
            Console.WriteLine("Invalid input, nothing happens.");
            break;
    }
    if (goblinHealth > 0)
    {
        knightHealth -= attackGoblin;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"The goblin attacked for {attackGoblin} damage.");
        Console.ResetColor();
    }

    if (knightHealth <= 0)
    {
        Console.WriteLine("The knight has died.");
    }
    else
    {
        Console.WriteLine($"The knight has {knightHealth} hp.");
    }
    if (goblinHealth <= 0)
    {
        Console.WriteLine("The goblin has died.");
    }
    else
    {
        Console.WriteLine($"The goblin has {goblinHealth} hp.");
    }
}




/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */

/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
