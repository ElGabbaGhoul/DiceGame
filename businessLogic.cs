Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Rules
// Rule 1: Your code should only display one message.
// The message that your code displays will depend on the other five rules. 
// For rules 2-6, the higher numbered rules take precedence over the lower numbered rules.
// Rule 2: If the user's subscription will expire in 10 days or less, display the message:
// Your subscription will expire soon. Renew now!
// Rule 3: If the user's subscription will expire in five days or less, display the messages:
// Your subscription expires in _ days.
// Renew now and save 10%!
// Rule 4: If the user's subscription will expire in one day, display the messages:
// Your subscription expires within a day!
// Renew now and save 20%!
// Rule 5: If the user's subscription has expired, display the message:
// Your subscription has expired.
// Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing.

// Your code goes here
// Create an if-else statement that displays a message about when the subscription will expire.
// Create a separate if statement that displays a discount offer.

if (daysUntilExpiration == 0)
{
  Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
  Console.WriteLine("Your subscription expires within a day!");
  discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
  Console.WriteLine($"Your subscription ends in {daysUntilExpiration} days.");
  discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
  Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days. Renew now!");
}
else
{
  Console.WriteLine($"Your subcription will expire in {daysUntilExpiration} days.");
}

if (discountPercentage > 0)
{
  Console.WriteLine($"Renew now and save {discountPercentage}%.");
}