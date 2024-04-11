/*Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.*/
/*void Natur (int rezult)
{
if (rezult == 0) return;
Natur(rezult - 1);
Console.Write($"{rezult} ");
}
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Natur(num);*/

/*Задача 3: Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.*/

/*
void element (char [] mas, int len)
{
   
    if ( len == 0) return;
    Console.Write($"{mas[len-1]} ");
    element (mas, len-1);
}
char[] chars = new char[] {'a', '1', 'c', 'd', 'z'};
element(chars, chars.Length);*/


/*Задача 2: Напишите программу вычисления функции
Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n. */

int Accerman(int m, int n)
{
   if (m == 0) return (n + 1);
   if ((m > 0) && (n==0))  return (Accerman (m - 1, 1));
   if ((m > 0) && (n > 0)) return (Accerman((m - 1), (Accerman (m, n - 1))));
   else return 0;
   
}
     
Console.WriteLine("Введите число n: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m: ");
int num2 = Convert.ToInt32(Console.ReadLine());
 Console.Write(Accerman(num1, num2));