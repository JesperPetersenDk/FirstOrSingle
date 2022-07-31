var users = new List<string>
{
    "Jesper Petersen",
    "Kasper Olsen",
    "Michael Willumsen"
};

var firstOne = users.First(); //Jesper Petersen
Console.WriteLine(firstOne);

var firstTwo = users.First(r => r.StartsWith("Michael")); // Michael Willumsen
Console.WriteLine(firstTwo);