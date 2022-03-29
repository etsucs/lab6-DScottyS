/*/     
 *--------------------------------------------------------------------
 * 	   File name: {Homework 6}
 * 	Project name: {Homework 6}
 *--------------------------------------------------------------------
 * Author’s name and email:	{Scotty Snyder | snyderds@etsu.edu}				
 *          Course-Section: {CSCI 1250-001}
 *           Creation Date:	{3/24/22}		
 * -------------------------------------------------------------------
/*/

// Calls:

// ShowCharacter call

System.Console.Write("Please enter your word: ");
var word = Console.ReadLine();

System.Console.Write("Please enter the number of the character you want from this word (note: spaces count as characters): ");
var letterNum = Int32.Parse(Console.ReadLine());

ShowCharacter(word, letterNum);

// CalculateRetail call

System.Console.Write($"\nPlease enter the wholesale price of your item: ");
var wholesale = double.Parse(Console.ReadLine());

System.Console.Write("Please enter the markup percentage of the item: ");
var markupPercent = double.Parse(Console.ReadLine());

CalculateRetail(wholesale, markupPercent);

// Celsius call

System.Console.Write($"\nPlease enter a temperature in Fahrenheit and we will convert it to Celsius: ");
double tempF = double.Parse(Console.ReadLine());

System.Console.WriteLine($"The temperature in Celsius is {Math.Round(Celsius(tempF), 2)} °C");

System.Console.WriteLine("The temperatures 80-100 in farenheit converted to celsius are the following: ");

for (int i = 80; i <= 100; i++)
{
    System.Console.WriteLine($"{Math.Round(Celsius(i), 2)}");
}

// IsPrime call

System.Console.Write($"\nPlease enter a number and we will determine whether or not it is a prime number: ");
double num = double.Parse(Console.ReadLine());
bool isPrime = IsPrime(num);

if(isPrime == true)
{
    System.Console.WriteLine($"{num} is a prime number.");
}
else
{
    System.Console.WriteLine($"{num} is not a prime number.");
}

// Methods

// ShowCharacter method

static void ShowCharacter(string word, int letterNum)
{
    if(letterNum - 1 > word.Length)
    {
        System.Console.Write("There are not this many characters in the word above, please try again: ");
        letterNum = Int32.Parse(Console.ReadLine());
    }
    else if(letterNum < 0)
    {
        System.Console.WriteLine("I don't think I can do that...");
    }
    else
    {
        System.Console.WriteLine(word[letterNum - 1]);   
    }
}

// CalculateRetail method

static void CalculateRetail(double wholesale, double markupPercent)
{
    double retailPrice = wholesale + (wholesale * (markupPercent / 100)); retailPrice = Math.Round(retailPrice, 2);

    System.Console.WriteLine($"The retail price of the item is ${retailPrice}.");
}

// Celsius method

static double Celsius(double tempF)
{
    return 5.0/9.0 * (tempF - 32.0);
}

//IsPrime method

static bool IsPrime(double num)
{
    int primeCheck = 0;
    
    for (int i = 1; i <= num; i++)
    {
        if(num % i == 0)
        {
            primeCheck++;
        }        
    }
    if(primeCheck == 2)
    {
        return true;
    }
    else
    {
        return false;
    }
}