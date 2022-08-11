// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("     /|");
Console.WriteLine("    / |");
Console.WriteLine("   /  |");
Console.WriteLine("  /   |");
Console.WriteLine(" /____|");


// Variables
string charName = "John Smith";
int charAge = 50;

Console.WriteLine("There was once a man named " + charName);
Console.WriteLine($"He was {charAge} years old");

charName = "Mike";
Console.WriteLine("He really liked the name " + charName);
Console.WriteLine("But didn't like being " + charAge);


// Data Types
//  i. Strings and Characters
string phrase = "Queen";
char alpha = 'B';
Console.WriteLine(phrase);
System.Console.WriteLine(alpha);
// ii. Numbers
int age = 50;
System.Console.WriteLine(age);
double weight = 50.6;
System.Console.WriteLine(weight);

// iii. Boolean
bool isMale = false;
System.Console.WriteLine(isMale);

// Working with strings

// Printing sting on a new line
string story = "Welcome\nEveryone";
Console.WriteLine(story);

// Concatenating strings



// Arrays
int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

luckyNumbers[1] = 500;
Console.WriteLine(luckyNumbers[1]);
Console.WriteLine(luckyNumbers);

string[] mine = new string[5];
mine[0] = "Kelly";
mine[1] = "Gold";
mine[2] = "Silver";
string[] friends = { "Jack", "Bill", "John", "Mary", "Amanda" };


// Methods in C-sharp


Greet();
static void Greet()
{
    Console.WriteLine("Hello user!");
}

GreetUser("John", 5);
static void GreetUser(string name, int age)
{
    Console.WriteLine("Nice to meet you " + name + " you are " + age);
}

// Return Statements
Console.WriteLine(cuboid(6));
static int cuboid(int num)
{
    int result = num * num * num;
    return result;

}

// if Statements
bool isFeMale = false;
bool isTall = false;
if (isFeMale && isTall)
{
    Console.WriteLine("You are a tall female");
}
else
{
    Console.WriteLine("You are a tall male");
}

if (isFeMale || isTall)
{
    Console.WriteLine("You are a tall female");
}
else if (isFeMale && !isTall)
{
    Console.WriteLine("You are a short female");

}
else if (!isFeMale && isTall)
{
    Console.WriteLine("You are not a female and not tall");
}
else
{
    Console.WriteLine("You are not tall at all");
}

// if Statements cont...
Console.WriteLine(GetMax(5, 50));
static int GetMax(int num_one, int num_two)
{
    int result;

    if (num_one > num_two)
    {
        result = num_one;
    }
    else
    {
        result = num_two;
    }
    return result;
}

Console.WriteLine(GetMin(500, 60, 5000));
static int GetMin(int num_one, int num_two, int num_three)
{
    int results;

    if (num_one < num_two && num_one > num_three)
    {
        results = num_one;
    }
    else if (num_three < num_two && num_three <= num_one)
    {
        results = num_three;
    }
    else
    {
        results = num_two;
    }

    return results;
}

// Classes and Objects
