

/*
 * Create a Console Application that asks
 * the user for their name. Welcome Tim as professor
 * or anyone else as student. Make sure that "TIM"
 * also gets called professor.
 */


// Ask user for their name
Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

// Conver string to lower case
string converName = firstName.ToLower();

// If name is tim
// Welcome as professor
// Or else as student

if (converName == "tim")
{
    Console.WriteLine("Welcome Professor");
}
else
{
    Console.WriteLine("What's up Student");
}