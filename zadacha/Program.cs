//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 

Console.Write("Введи цифру: ");
int number = Convert.ToInt32(Console.ReadLine());

void DividedByTwoNumbers (int number)
{
  if (number % 7 == 0 && number % 23 == 0) 
  {
     Console.WriteLine("это  число кратное 7 и 23");
  }
 
  else Console.WriteLine("это не кратное число");
}

DividedByTwoNumbers(number);

