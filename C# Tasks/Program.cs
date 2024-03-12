#region Task 1
//Console.WriteLine("Vvedite chislo ot 1 do 100:");

//// Stroku s if , ya delal ne sam , ya propustil urok gde mi 
//// proxodili ReadLine i TryParse 
//// V blijayshee vremya ya vse uroki peresmotryu

//if (int.TryParse(Console.ReadLine(), out int number))
//{
//    if (number >= 1 && number <= 100)
//    {
//        if (number % 3 == 0 && number % 5 == 0)
//        {
//            Console.WriteLine("Fizz Buzz");
//        }
//        else if (number % 3 == 0)
//        {
//            Console.WriteLine("Fizz");
//        }
//        else if (number % 5 == 0)
//        {
//            Console.WriteLine("Buzz");
//        }
//        else
//        {
//            Console.WriteLine(number);
//        }
//    }
//    else
//    {
//        Console.WriteLine("Error");
//    }
//}
//else
//{
//    Console.WriteLine("Error");
//}
#endregion

#region Task 2
//Console.WriteLine("Vvedite chislo i procent:");
//if (double.TryParse(Console.ReadLine(), out double value) && double.TryParse(Console.ReadLine(), out double percent))
//{
//    double result = (value * percent) / 100;
//    Console.WriteLine($"Result: {result}");
//}
//else
//{
//    Console.WriteLine("Error");
//}
#endregion

#region Task 3 
//Console.WriteLine("Vvedite 4 chisla:");
//string input = Console.ReadLine();

//if (input.Length == 4 && int.TryParse(input, out _))
//{
//    int number = int.Parse(input);
//    Console.WriteLine($"Number: {number}");
//}
//else
//{
//    Console.WriteLine("Error");
//}
#endregion

#region Task 4
string number = Console.ReadLine();
if (number.Length != 6)
{
    Console.WriteLine("Error");
}

string pos1 = Console.ReadLine();
string pos2 = Console.ReadLine();
if (pos1.Length != 1 && pos2.Length != 1)
{
    Console.WriteLine("Error");
}
int poss1 = int.Parse(pos1);
int poss2 = int.Parse(pos2);

char[] digits = number.ToCharArray();
char temp = digits[poss1 - 1];
digits[poss1 - 1] = digits[poss2 - 1];
digits[poss2 - 1] = temp;

string result = new string(digits);
Console.WriteLine("Результат обмена цифр: " + result);
#endregion