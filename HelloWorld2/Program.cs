// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("Bread is ready");
Console.WriteLine("Who is the bread for?");
string name;
name = Console.ReadLine();// this warning is expected and a none issue
Console.WriteLine("Noted: " + name + " got bread");
*/
/*
Practice exercise chapter 4 on comments
Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); //stores input in string a
Console.WriteLine("How would you describe it? Big? Azure? Tattered?"); 
string b = Console.ReadLine(); // stores input of string b
string c = "of Doom"; // stores input of string c
string d = "3000"; /* stores input of string d 
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");

byte smallBit = 34;
smallBit = 17;
Console.WriteLine(smallBit);
var name = "Hey Buddy";
var number = 1;
Console.WriteLine(name is String); // checking if type inference works should be true.
//Console.WriteLine(number is int);


Console.WriteLine("Give me a number");
string inputNumber = Console.ReadLine();
int number = Convert.ToInt32(inputNumber); //testing out how to convert input to int
Console.WriteLine(number);
Console.WriteLine(number is Int32); //proving the string was converted to an int

int number2 = int.Parse("1000");
Console.WriteLine(number2 is Int32); // other method of changing string to something
*/
//Chapter 7 Math***********************************************
//4 Sisters and Duckbear challenge
Console.WriteLine("How many chocolate eggs do you want to split up");
string numOfEggs = Console.ReadLine();
//Divide among 4 sisters, remainder goes to duckbear
int sisters = 0;
int duckBear = 0;
int eggs = Convert.ToInt32(numOfEggs); // take string input and convert to int to perform math on
sisters += eggs / 4; // how many eggs the sisters get
duckBear = eggs % 4; // how man eggs the Duckbear gets (Remainder from sisters division)
Console.WriteLine("The Sisters each get " + sisters + " eggs and Duckbear gets " + duckBear + " eggs");










