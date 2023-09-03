/*
The purpose of this code is to reverse 
a string and to count the number of 
times a particular character appears, 
then it prints the results to the console
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
  if (letter == 'o')
  {
    letterCount++;
  }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");