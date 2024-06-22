// // Exercise - Create effective code comments

// string firstName = "Bob";
// int widgetsPurchased = 7;
// // Testing a change to the message
// // int widgetsSold = 7;
// // Console.WriteLne($"{firstName} sold {widgetSold} widgets.");
// Console.WriteLine($"{firstName} purchaed {widgetsPurchased} widgets.");

// /*
//   The following code creates five random OrderIDs
//   to test the fraud detection process. OrderIDs
//   consist of a letter from A to E, and a three
//   digit number. Ex. A123.
// */
// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {

//   int prefixValue = random.Next(65, 70);

//   string prefix = Convert.ToChar(prefixValue).ToString();

//   string suffix = random.Next(1, 1000).ToString("000");

//   orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//   Console.WriteLine(orderID);
// }

// // Exercise - Use whitespace to make your code easier to read

// // Example 1:
// Console
// .
// WriteLine
// (
// "Hello Example 1!"
// )
// ;

// // Example 2:
// string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// bool doublesOrTriples = false;

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} {roll2} {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//   if ((roll1 == roll2) && (roll2 == roll3))
//   {
//     Console.WriteLine("You rolled triples!  +6 bonus to total!");
//     total += 6;
//     doublesOrTriples = true;
//   }
//   else
//   {
//     Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//     total += 2;
//     doublesOrTriples = true;
//   }
// }

// if (doublesOrTriples)
// {
//   Console.WriteLine($"New Total: {total}");
// }

// /*The high-level purpose of this code is to reverse a string
//   and count the number of times a particular character appears.
// */

// string str = "The quick brown fox jumps over the lazy dog.";
// // Conversts the message into the char array
// char[] charMessage = str.ToCharArray();
// // Reverse the chars
// Array.Reverse(charMessage);
// int x = 0;
// // count the o's
// foreach (char c in charMessage)
// {
//   if (c == 'o')
//   {
//     x++;
//   }
// }
// // Convert it back to a string
// string new_message = new String(charMessage);
// // Print out
// Console.WriteLine(new_message);
// Console.WriteLine($"'o' appeared {x} times.");

