var users = new List<string>
{
    "Jesper Petersen",
    "Kasper Olsen",
    "Michael Willumsen"
};
var number = new List<int>
{
    51
};


//First
var firstOne = users.First(); //Jesper Petersen
Console.WriteLine(firstOne);

var firstTwo = users.First(r => r.StartsWith("Michael")); // Michael Willumsen
Console.WriteLine(firstTwo);

var firstOrDefaultOne = users.FirstOrDefault(r => r.StartsWith("Kasm"), "Intet!");//Intet!!
Console.WriteLine(firstOrDefaultOne);


//Single
var singleOne = number.Single();//51
Console.WriteLine(singleOne);

var singleTwo = users.Single(r => r.StartsWith("Kasper")); //Kasper
Console.WriteLine(singleTwo);

var singleOrDefaultOne = users.SingleOrDefault(r => r.StartsWith("asf"), "Intet");//Intet
Console.WriteLine(singleOrDefaultOne);
