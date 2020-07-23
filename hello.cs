//Hello world without class declaration:
Console.WriteLine("Hello World!");
Console.WriteLine("\n");

//Experiments with strings: 
string aFriend("Bill");
Console.WriteLine(aFriend);

aFriend2 = "Maira";
Console.WriteLine(aFriend2);

Console.WriteLine("Hello, " + aFriend + " and " + aFriend2);
// or similarly to Python:
Console.WriteLine($"Hello, {aFriend} and {aFriend2}");

// doing the same specifying the strings first, you would have something like:
string firstFriend = "Maria";
string secondFriend = "Steven";

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

//if we wanted count the length of the given strings, we could write:
Console.WriteLine($"The name of {firstFriend} has {firstFriend.length} characters.");
Console.WriteLine($"Conversely, the name of {secondFriend} has {secondFriend.length} characters.");
