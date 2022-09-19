/*

16. Напишите программу, которая принимает на вход два числа 
и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет

*/

int firstNumber = new Random().Next(1, 10);
int secondNumber = new Random().Next(1, 100);

string Square(int firstNumber, int secondNumber)
{
    string square = "";

    if (firstNumber * firstNumber == secondNumber ||
     secondNumber * secondNumber == firstNumber) 
    {
        square = "Да";
    }
    else square = "Нет";
    return square;
}

Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);
string result = Square(firstNumber, secondNumber);
Console.WriteLine(result);

