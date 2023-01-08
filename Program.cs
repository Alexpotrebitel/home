//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*int func(int num)
{
 int number1=num/10;
 int number2=number1%10;
 return number2;
}
Console.WriteLine("Введите трехзначное число");
int num=Convert.ToInt32(Console.ReadLine());
if((num<999&&num>100)||(num>-999&&num<-100))
    {
        if(num<999&&num>100)
        Console.WriteLine($"Второе число"+(func(num)));
        else
        {
            Console.WriteLine($"Второе число"+(-1*(func(num))));
        }
    }
   else
   {
   Console.WriteLine("Введено не трехзначное число");
   }
*/
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*int cutnumber(int number)
{
    while (number > 999 || number < 0)
    {
    number = number / 10;
        }
   number = number % 10;
   
    return number;  
}
int plus(int number)
{
    while(number < 0)
  {
    number = -1*number;
  }
  return number;
}

Console.WriteLine("Please input your number ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 || number <= -100)
{ 
    number = plus(number);
    Console.WriteLine($"Third number is {cutnumber(number)}");
}
else
{
    Console.WriteLine("Please input correct number");
}

*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*bool vihod(int den)
{
    {
    if (den>5||den<0)
    return true;
    
    else 
return false;
   }
}
Console.WriteLine("Пожалуйста введите день недели в цифрах от 1 до 7");
int den = Convert.ToInt32(Console.ReadLine());
if (den>1 || den<7)
{
bool nedelya = vihod(den);
    if (nedelya){Console.WriteLine("Это выходной" );}
    else{Console.WriteLine("Это не выходной!");}
}
else
{
    Console.WriteLine("Не верное число");
}
*/