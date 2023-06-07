Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); /* Reads the terminal input */
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();
string c = "of Doom"; 
string d = "3000"; //It stores the number as a string
Console.WriteLine("The " + a + " " + b + " " + c + " " + d + "!"); //The error was the extra 'of' in the string