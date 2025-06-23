/*The application that receives two number and one operator option and executes the
calculation. The result must be returned.
The operation codes are:
• SUM;
• SUB;
• MLT;
• DIV;
A Switch must be used;*/

using System.Diagnostics;

Console.WriteLine("For start, give me your first number:");
string input1 = Console.ReadLine();
float number1 = float.Parse(input1);
Console.WriteLine($"Your first number is {number1}.");

Console.WriteLine("Now your second number, please:");
string input2 = Console.ReadLine();
float number2 = float.Parse(input2);
Console.WriteLine($"And your second number is the number {number2}.");

Console.WriteLine("Now choice your operator:");
Console.WriteLine("1. SUM");
Console.WriteLine("2. SUB");
Console.WriteLine("3. MLT");
Console.WriteLine("4. DIV");

string input3 = Console.ReadLine();
int operatorChoice = int.Parse(input3);

switch (operatorChoice)
{
    case 1:
        #region Summation
        float resultSum = number1 + number2;
        Console.WriteLine("You choice the SUMMARY operator.");
        Console.WriteLine($"{number1} + {number2} = {Sum(number1, number2)}");
        #endregion
        break;
    case 2:
        #region Subtraction
        float resultSub = number1 - number2;
        Console.WriteLine("You choice the SUBTRACTION operator.");
        Console.WriteLine($"{number1} - {number2} = {Sub(number1, number2)}");
        #endregion
        break;
    case 3:
        #region Multiplication
        float resultMlt = number1 * number2;
        Console.WriteLine("You choice the MULTIPLICATION operator.");
        Console.WriteLine($"{number1} * {number2} = {Mlt(number1, number2)}");
        #endregion
        break;
    case 4:
        #region Division
        float resultDiv = number1 / number2;
        Console.WriteLine("You choice the DIVISION operator.");
        Console.WriteLine($"{number1} / {number2} = {Div(number1, number2)}");
        #endregion
        break;
}

static float Sum(float a, float b)
{
    return a + b;
}
static float Sub(float a, float b)
    { return a - b; }
static float Mlt(float a, float b)
    { return a * b; }
static float Div(float a, float b) { return a / b; }