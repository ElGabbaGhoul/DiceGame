// Random Rolls

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// Test Doubles

// int roll1 = 6;
// int roll2 = 6;
// int roll3 = 5;

// Test Triples

// int roll3 = 6;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


if ((roll1 == roll2) && (roll2 == roll3))
{
  Console.WriteLine("You rolled triples! +6 bonus to total!");
  total += 6;
}
else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
  Console.WriteLine("You rolled doubles! +2 bonus to total!");
  total += 2;
}

if (total == 24)
{
  Console.WriteLine($"UNBELIEVABLE! YOU ROLLED A {total}! YOU WIN $10,000,000,000!!!!!!!");
}
else if (total > 19)
{
  Console.WriteLine($"You rolled a {total}! You win $1,000,000!");
}
else if (total >= 16)
{
  Console.WriteLine($"You rolled a {total}! You win a new car!");
}
else if (total >= 10)
{
  Console.WriteLine($"You rolled a {total}! You win a new laptop!");
}
else if (total == 7)
{
  Console.WriteLine($"You rolled a {total}! You win a trip for two!");
}
else
{
  Console.WriteLine($"You rolled a {total}! You win a kitten!");
}