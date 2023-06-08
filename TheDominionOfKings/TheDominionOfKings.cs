Console.Write("Enter how many provinces: ");
int provinces = int.Parse(Console.ReadLine());
Console.Write("Enter how many duchies: ");
int duchies = int.Parse(Console.ReadLine());
Console.Write("Enter how many estates: ");
int estates = int.Parse(Console.ReadLine());
int total = provinces * 6 + duchies * 3 + estates;
Console.WriteLine("Total score: " + total);