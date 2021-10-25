string input;
do 
{
    Console.WriteLine("Please enter a fraction: #/#");
    input = Console.ReadLine();
} while(String.IsNullOrWhiteSpace(input));

Console.WriteLine("\n----Calculating----\n");

string[] fraction = input.Split('/');
int numerator = Int32.Parse(fraction[0]);
int denominator = Int32.Parse(fraction[1]);
CalculateSmallestFraction(numerator, denominator);
static void CalculateSmallestFraction(int a, int b )
{
    int tempA;
    int tempB;
    if ((a%b) == 0)
    {
        tempA = a/b;
        Console.WriteLine($"{tempA}");
    }
    else if(b%a == 0)
    {
        tempB = b/a;
        Console.WriteLine($"1/{tempB}");
    }
    else if((a%2)== 0 && (b%2)==0)
    {
        tempA = (a/2);
        tempB = (b/2);
        CalculateSmallestFraction(tempA, tempB);
    } else {
        for(int j = 2; j<10; j++)
        {
            if(a%j == 0 && b%j == 0)
            {
                tempA = a/j;
                tempB = b/j;
                Console.WriteLine($"{tempA}/{tempB}");
                return;
            } 
        }
        Console.WriteLine($"{a}/{b}");
    }
}