// Задача 1. Написать программу которая выводит случайное трехзначное число и удаляет вторую цифру этого числа,

/*
int CutNum(int num)

{
   int sot = num / 100;
   int ed = num % 10;

   int result = sot * 10 + ed;
   return result; 
}

int randNum = new Random().Next(100, 1000);

int newNum = CutNum(randNum);

Console.WriteLine($"New version of a number {randNum} is {newNum}");
*/

// Программа которая выводит случайное число в отрезке от 10 до 99 включительно и показывает наибольшую цифру числа.

/*
int MaxNum(int num)
{
    int num1 = num / 10;
    int num2 = num % 10;

    int result;
{
    if(num1 > num2) result = num1;
    else result = num2;
}
    return result;
}

int randNum = new Random().Next(10, 99);

int newNum = MaxNum(randNum);
Console.WriteLine($"Максимальное значение в двухзначном числе {randNum} это {newNum}");
*/

// Пользователь вводит два числа ,кратно ли второе число первому?

/*
bool Go(int n1, int n2)
{
    if(n2 % n1 == 0) 
    {
    return true;
    }
    else
    { 
    return false;
    }
}

Console.Write("input a first number : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number : ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Go(number1, number2);
Console.WriteLine($"Второе число {number2} кратно первому {number1} {result} ");
*/
 // Напишите программу,которая на вход будет принимать одно число и проверяет кратно ли 
 // одновременно a и b

 /*

bool Met(int n1, int n2, int n3)
{
    if(n1 % n2 ==0 && n1 % n3 ==0) return true;
    else return false;
} 

Console.Write("Вводим число, которое нужно проверить на кратность : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вводим первый делитель : ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вводим второй делитель : ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool result = Met(number1, number2, number3);
Console.Write($"Введеное число {number1} является ли кратным, одновременно числу {number2} и {number3}- {result}");
*/


