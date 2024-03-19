// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");


//Hero and Monster start with 10 health points
string hero = "Hero";
int heroHealth = 10;

string monster = "Monster";
int monsterHealth = 10;
Random random = new Random();
do
{
    int heroAttack = random.Next(1, 11);
    int monsterAttack = random.Next(1, 11);
    // heroAttack = random.Next(1, 11);
    // monsterAttack = random.Next(1, 11);

    if (heroHealth <= 0 || monsterHealth <= 0) break;

    monsterHealth -= heroAttack;
    heroHealth -= monsterAttack;

    Console.WriteLine($"{hero} attacks {monster} for {heroAttack} damage. {monster} has {monsterHealth} health points left.");
    Console.WriteLine($"{monster} attacks {hero} for {monsterAttack} damage. {hero} has {heroHealth} health points left.");
} while (heroHealth > 0 && monsterHealth > 0);
Console.WriteLine(heroHealth <= 0 ? $"{monster} wins!" : $"{hero} wins!");
