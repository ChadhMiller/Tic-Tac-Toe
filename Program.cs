// Tic Tac Toe

//test win if statement here

string a3b3 = "";
string a1b1 = "";
string a1b2 = "";
string a1b3 = "";
string a2b1 = "";
string a2b2 = "";
string a2b3 = "";
string a3b1 = "";
string a3b2 = "";


Console.WriteLine("Welcome to Tic Tac Toe");
Console.Write("Player one choose x or o: ");
string Player1 = Console.ReadLine();
Console.Write("Player two chose the option player one didn't: ");
string Player2 = Console.ReadLine();

//Console.WriteLine("   |   |   \n------------\n   |   |   \n------------\n   |   |   ");
Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
//create a variable x and set it equal to response1
Console.WriteLine("the columns from left to right are a1, a2, a3 and the rows from top to bottom are b1, b2, b3");

Console.WriteLine($"{Player1} chose your spot ex(a2-b3)");
string response1 = Console.ReadLine();

while (true)
{
    if (response1 == "a1-b1")
    {
        a1b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        //I need to make a1b1 the same as Player1
        break;
    }
    else if (response1 == "a2-b1")
    {
        a2b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response1 == "a3-b1")
    {
        a3b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response1 == "a1-b2")
    {
        a1b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response1 == "a2-b2")
    {
        a2b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response1 == "a3-b2")
    {
        a3b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response1 == "a1-b3")
    {
        a1b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response1 == "a2-b3")
    {
        a2b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response1 == "a3-b3")
    {
        a3b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else
    {
        Console.WriteLine("invalid response try something like a3-b2");
        response1 = Console.ReadLine();
    }

}

Console.WriteLine($"{Player2} chose your spot ex(a2-b3)");
string response2 = Console.ReadLine();

while (true)
{
    if (response2 == "a1-b1")
    {
        a1b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response2 == "a2-b1")
    {
        a2b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response2 == "a3-b1")
    {
        a3b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response2 == "a1-b2")
    {
        a1b2 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response2 == "a2-b2")
    {
        a2b2 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response2 == "a3-b2")
    {
        a3b2 = "0";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response2 == "a1-b3")
    {
        a1b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response2 == "a2-b3")
    {
        a2b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response2 == "a3-b3")
    {
        a3b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else
    {
        Console.WriteLine("invalid response try something like a3-b2");
        response2 = Console.ReadLine();
    }
}

Console.WriteLine($"{Player1} chose your spot ex(a2-b3)");
string response3 = Console.ReadLine();

while (true)
{
    if (response3 == "a1-b1")
    {
        a1b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        //I need to make a1b1 the same as Player1
        break;
    }
    else if (response3 == "a2-b1")
    {
        a2b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response3 == "a3-b1")
    {
        a3b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response3 == "a1-b2")
    {
        a1b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response3 == "a2-b2")
    {
        a2b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response3 == "a3-b2")
    {
        a3b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response3 == "a1-b3")
    {
        a1b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response3 == "a2-b3")
    {
        a2b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response3 == "a3-b3")
    {
        a3b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else
    {
        Console.WriteLine("invalid response try something like a3-b2");
        response3 = Console.ReadLine();
    }

}

Console.WriteLine($"{Player2} chose your spot ex(a2-b3)");
string response4 = Console.ReadLine();

while (true)
{
    if (response4 == "a1-b1")
    {
        a1b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response4 == "a2-b1")
    {
        a2b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response4 == "a3-b1")
    {
        a3b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response4 == "a1-b2")
    {
        a1b2 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response4 == "a2-b2")
    {
        a2b2 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response4 == "a3-b2")
    {
        a3b2 = "0";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response4 == "a1-b3")
    {
        a1b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response4 == "a2-b3")
    {
        a2b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response4 == "a3-b3")
    {
        a3b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else
    {
        Console.WriteLine("invalid response try something like a3-b2");
        response4 = Console.ReadLine();
    }
}

Console.WriteLine($"{Player1} chose your spot ex(a2-b3)");
string response5 = Console.ReadLine();

while (true)
{
    if (response5 == "a1-b1")
    {
        a1b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        //I need to make a1b1 the same as Player1
        break;
    }
    else if (response5 == "a2-b1")
    {
        a2b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response5 == "a3-b1")
    {
        a3b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response5 == "a1-b2")
    {
        a1b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response5 == "a2-b2")
    {
        a2b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response5 == "a3-b2")
    {
        a3b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response5 == "a1-b3")
    {
        a1b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response5 == "a2-b3")
    {
        a2b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response5 == "a3-b3")
    {
        a3b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else
    {
        Console.WriteLine("invalid response try something like a3-b2");
        response5 = Console.ReadLine();
    }

}

Console.WriteLine($"{Player2} chose your spot ex(a2-b3)");
string response6 = Console.ReadLine();

while (true)
{
    if (response6 == "a1-b1")
    {
        a1b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response6 == "a2-b1")
    {
        a2b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response6 == "a3-b1")
    {
        a3b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response6 == "a1-b2")
    {
        a1b2 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response6 == "a2-b2")
    {
        a2b2 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response6 == "a3-b2")
    {
        a3b2 = "0";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response6 == "a1-b3")
    {
        a1b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response6 == "a2-b3")
    {
        a2b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response6 == "a3-b3")
    {
        a3b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else
    {
        Console.WriteLine("invalid response try something like a3-b2");
        response6 = Console.ReadLine();
    }
}

Console.WriteLine($"{Player1} chose your spot ex(a2-b3)");
string response7 = Console.ReadLine();

while (true)
{
    if (response7 == "a1-b1")
    {
        a1b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        //I need to make a1b1 the same as Player1
        break;
    }
    else if (response7 == "a2-b1")
    {
        a2b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response7 == "a3-b1")
    {
        a3b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response7 == "a1-b2")
    {
        a1b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response7 == "a2-b2")
    {
        a2b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response7 == "a3-b2")
    {
        a3b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response7 == "a1-b3")
    {
        a1b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response7 == "a2-b3")
    {
        a2b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response7 == "a3-b3")
    {
        a3b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else
    {
        Console.WriteLine("invalid response try something like a3-b2");
        response7 = Console.ReadLine();
    }

}

Console.WriteLine($"{Player2} chose your spot ex(a2-b3)");
string response8 = Console.ReadLine();

while (true)
{
    if (response8 == "a1-b1")
    {
        a1b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response8 == "a2-b1")
    {
        a2b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response8 == "a3-b1")
    {
        a3b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response8 == "a1-b2")
    {
        a1b2 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response8 == "a2-b2")
    {
        a2b2 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response8 == "a3-b2")
    {
        a3b2 = "0";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response8 == "a1-b3")
    {
        a1b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response8 == "a2-b3")
    {
        a2b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response8 == "a3-b3")
    {
        a3b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else
    {
        Console.WriteLine("invalid response try something like a3-b2");
        response8 = Console.ReadLine();
    }
}

Console.WriteLine($"{Player1} chose your spot ex(a2-b3)");
string response9 = Console.ReadLine();

while (true)
{
    if (response9 == "a1-b1")
    {
        a1b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        //I need to make a1b1 the same as Player1
        break;
    }
    else if (response9 == "a2-b1")
    {
        a2b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response9 == "a3-b1")
    {
        a3b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response9 == "a1-b2")
    {
        a1b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response9 == "a2-b2")
    {
        a2b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response9 == "a3-b2")
    {
        a3b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response9 == "a1-b3")
    {
        a1b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response9 == "a2-b3")
    {
        a2b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response9 == "a3-b3")
    {
        a3b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else
    {
        Console.WriteLine("invalid response try something like a3-b2");
        response9 = Console.ReadLine();
    }

}

Console.WriteLine($"{Player2} chose your spot ex(a2-b3)");
string response10 = Console.ReadLine();

while (true)
{
    if (response10 == "a1-b1")
    {
        a1b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response10 == "a2-b1")
    {
        a2b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response10 == "a3-b1")
    {
        a3b1 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response10 == "a1-b2")
    {
        a1b2 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response10 == "a2-b2")
    {
        a2b2 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response10 == "a3-b2")
    {
        a3b2 = "0";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response10 == "a1-b3")
    {
        a1b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response10 == "a2-b3")
    {
        a2b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response10 == "a3-b3")
    {
        a3b3 = "o";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else
    {
        Console.WriteLine("invalid response try something like a3-b2");
        response10 = Console.ReadLine();
    }
}

Console.WriteLine($"{Player1} chose your spot ex(a2-b3)");
string response11 = Console.ReadLine();

while (true)
{
    if (response11 == "a1-b1")
    {
        a1b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        //I need to make a1b1 the same as Player1
        break;
    }
    else if (response11 == "a2-b1")
    {
        a2b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response11 == "a3-b1")
    {
        a3b1 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response11 == "a1-b2")
    {
        a1b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response11 == "a2-b2")
    {
        a2b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response11 == "a3-b2")
    {
        a3b2 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response11 == "a1-b3")
    {
        a1b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response11 == "a2-b3")
    {
        a2b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else if (response11 == "a3-b3")
    {
        a3b3 = "x";
        Console.WriteLine($" {a1b1} | {a2b1} | {a3b1} \n------------\n {a1b2} | {a2b2} | {a3b2} \n------------\n {a1b3} | {a2b3} | {a3b3} ");
        break;
    }
    else
    {
        Console.WriteLine("invalid response try something like a3-b2");
        response11 = Console.ReadLine();
    }

}

//if (a1b1 = a2b2 = a3b3) 
//{
//    Console.WriteLine("Player1 Wins!");
//}
//else
//{
//    Console.WriteLine("Player2 Wins!");
//}