Console.Write("Enter the number of chocolate eggs: ");
int numberOfEggs = int.Parse(Console.ReadLine());
int numberOfSisters = 4;
int numberOfEggsPerSister = numberOfEggs / numberOfSisters;
int numberOfEggsForDuckbear = numberOfEggs % numberOfSisters;
Console.WriteLine($"Each sister gets {numberOfEggsPerSister} eggs.");
Console.WriteLine($"The duckbear gets {numberOfEggsForDuckbear} eggs.");