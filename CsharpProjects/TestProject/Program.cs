// convert the message into a char array
// Reverse the chars
// count the o's
// convert it back to a string
// print it out

string origianlMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = origianlMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;
foreach (char letter in message) 
{ 
    if (letter == 'o') 
    { letterCount++; } 
}
string newMessage = new String(message);
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");