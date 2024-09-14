using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ConsoleApp4
{
    internal class Program
    {

        public static void Filter(string text)
        {
            string vowels = "AEIOUaeuoi";
            string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXY";
            char[] vowel = new char[text.Length];
            char[] consonant = new char[text.Length];
            char[] simbols = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                    vowel[i] = text[i];
                }
                else if (consonants.Contains(text[i]))
                {
                    consonant[i] = text[i];
                }
                else
                {
                    simbols[i] = text[i];
                }
            }
            Console.Write("Vowels are: ");
            for (int i = 0; i < vowel.Length; i++)
            {
                Console.Write(vowel[i]);
            }
            Console.Write("\n");
            Console.Write("Consonants are: ");
            for (int i = 0; i < consonant.Length; i++)
            {
                Console.Write(consonant[i]);
            }
            Console.Write("\n");
            Console.Write("Simbols are: ");
            for (int i = 0; i < simbols.Length; i++)
            {
                Console.Write(simbols[i]);
            }
        }

        //IsPalindrome
        public static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;

        }



        //square root of float

        public static void SquareRoot(double num)
        {
            Console.Write($"Square root of {num} is {Math.Sqrt(num)}");

            Console.Write("\n");
        }


        //Sorting by descending
        public static float[] SortDesc(float[] arr)
        {
            float min = 0;
            int minIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minIndex = j;
                        ;
                    }
                }
                arr[minIndex] = arr[i];
                arr[i] = min;
            }
            return arr;
        }

        //Revercing array of chars
        public static char[] ReverseArrayOfChars(char[] arr)
        {
            char keep = 'A';
            for (int i = 0; i < arr.Length; i += 2)
            {
                keep = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = keep;
            }
            return arr;
        }


        //Homework
        //Factorial
        public static void FactorialOfNum(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"Factorial of {num} is {fact}");
        }


        // MultiplicationOfNum

        public static void MultiplicationOfNum(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" {num} * {i} = {i * num}");
            }
        }


        //FirtsNFibonacciNumbers

        public static void FirtsNFibNums(int num)
        {
            int a = 0;
            int b = 1;
            int fib = a + b;
            if (num == 1)
            {
                Console.Write($"First {num} Fibonacci number is: {a}");
            }

            if (num == 2)
            {
                Console.Write($"First {num} Fibonacci numbers are: {a},{b}");
            }

            if (num == 3)
            {
                Console.Write($"First {num} Fibonacci numbers are: {a},{b},{fib}");
            }

            if (num > 3)
            {
                Console.Write($"First {num} Fibonacci numbers are: {a},{b},{fib},");
                for (int i = 0; i < num - 3; i++)
                {
                    a = b;
                    b = fib;
                    fib = a + b;
                    Console.Write(fib + ",");
                }
            }

            Console.Write("\n");
        }



        //Reversing a number

        public static void ReversingNumber(int num)
        {
            int revNum = 0;
            while (num > 0)
            {
                revNum = revNum * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine($"Reversed number is {revNum}");
        }


        // DigitsOfNumber

        public static void DigitsOfNumber(int num)
        {
            int count = 0;
            int newNum = num;
            while (num > 0)
            {
                num /= 10;
                count++;
            }
            Console.WriteLine($"Digits of {newNum} is {count}");
        }



        //SumOfDigits

        public static void SumOfDigits(int num)
        {
            int sum = 0;
            int newNum = num;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"Sum of digits {newNum} is {sum}");
        }



        //PrimeOrNo

        public static void PrimeNumber(int num)
        {
            bool prime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Number is not Prime");
                    prime = false;
                    break;
                }



            }
            if (prime)
            {
                Console.WriteLine("Number is Prime");
            }

        }


        //ArmStrongOrNo

        public static void ArmStrongOrNo(int num)
        {
            int sumMult = 0;
            int newNum = num;

            while (num > 0)
            {
                int digit = num % 10;
                sumMult += digit * digit * digit;

                num /= 10;
            }
            if (sumMult == newNum)
            {
                Console.WriteLine("Number is ArmStrong ");
            }
            else
            {
                Console.WriteLine("Number is not ArmStrong ");
            }

        }

        //Pyramid

        public static void Pyramid(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                for (int k = 0; k < num - i; k++)
                {
                    Console.Write(' ');

                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.Write("\n");

            }
        }

        //Season finder
        //public static int MonthNumber(string month)
        //{
        //    switch (month)
        //    {
        //        case "January": return 1;
        //        case "February": return 2;
        //        case "March": return 3;
        //        case "April": return 4;
        //        case "May": return 5;
        //        case "June": return 6;
        //        case "July": return 7;
        //        case "August": return 8;
        //        case "September": return 9;
        //        case "October": return 10;
        //        case "November": return 11;
        //        case "December": return 12;
        //        default: return 0;

        //    }
        //}

        public static void SeasonFinder(int num)
        {
            switch (num)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("Wrong number");
                    break;
            }
        }


        //Vowel or Consonant

        public static void VowelOrConsonant(char letter)
        {
            string vowels = "AEIOUaeiou";
            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels.Contains(letter))
                {
                    Console.WriteLine($"{letter} is a vowel!");
                    break;
                }
                else
                {
                    Console.WriteLine($"{letter} is a consonant!");
                    break;
                }
            }
        }


        //Even or Odd

        public static void EvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is ODD");
            }
            else
            {
                Console.WriteLine($"{num} is EVEN");
            }
        }


        //Positive, Negative or Zero

        public static void CheckSign(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }



        //LeapOrNo

        public static void LeapOrNo(int num)
        {
            if (num % 100 == 0 && num % 400 == 0)
            {
                Console.WriteLine("Leap");
            }
            else if (num % 100 != 0 && num % 4 == 0)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Not Leap");
            }
        }

        public static void MaxOfThreeNums(int num1, int num2, int num3)
        {
            int max = 0;
            max = num1 > num2 ? num1 : num2;
            max = max > num3 ? max : num3;
            Console.WriteLine($"Max is {max}");
        }


        //GradeScore

        public static void GradeScore(int score)
        {
            if (score >= 0 && score <= 20)
            {
                Console.WriteLine("Fail");

            }
            else if (score > 20 && score <= 40)
            {
                Console.WriteLine('A');

            }
            else if (score > 40 && score <= 60)
            {
                Console.WriteLine('B');
            }
            else if (score > 60 && score <= 80)
            {
                Console.WriteLine('C');
            }
            else if (score > 80 && score <= 100)
            {
                Console.WriteLine('D');
            }
            else
            {
                Console.WriteLine("Wrong percentage");
            }
        }

        //GradeDescription
        public static void GradeDescription(char grade)
        {
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Good");
                    break;
                case 'C':
                    Console.WriteLine("Average");
                    break;
                case 'D':
                    Console.WriteLine("Normal");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default: Console.WriteLine("Wrong Grade");
                    break;
            }
        }



        static void Main(string[] args)
        {






            //Filter("Barev arev//loi@");

            //IsPalindrome
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a text: ");
            //    string str = Console.ReadLine();
            //    bool result = IsPalindrome(str);
            //    Console.WriteLine($"Result is {result}");
            //   
            //}

            //Square root
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a float num: ");
            //    double num = Convert.ToDouble(Console.ReadLine());
            //    SquareRoot(num);
            //}

            //Sorting by descending
            //Console.Write("Type the length of array: ");
            //int length = Convert.ToInt32(Console.ReadLine());
            //float[] arr = new float[length];

            //Console.WriteLine($"Type {length} elements:");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Element N{i + 1}: ");
            //    arr[i] = float.Parse(Console.ReadLine());
            //}
            //Console.Write("Elements are: ");
            //for (int i = 0; i < arr.Length; i++)
            //{

            //    Console.Write(arr[i] + " ");
            //}
            //Console.Write("\n");
            //Console.Write("Sorted array is: ");
            //float[] result = SortDesc(arr);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write(result[i] + " ");
            //}

            //Revercing array of chars

            //Console.Write("Type the length of array: ");
            //int length = Convert.ToInt32(Console.ReadLine());
            //char[] arr = new char[length];

            //Console.WriteLine($"Type {length} char elements:");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Element N{i + 1}: ");
            //    arr[i] = Convert.ToChar(Console.ReadLine());
            //}
            //Console.Write("Elements are: ");
            //for (int i = 0; i < arr.Length; i++)
            //{

            //    Console.Write(arr[i] + " ");
            //}
            //Console.Write("\n");
            //char[] result = ReverseArrayOfChars(arr);
            //Console.Write("Reverced array is: ");

            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write(result[i] + " ");
            //}



            //Homework


            //Factorial of a Number: Write a program to find the factorial of a number.
            //Solution
            //Console.WriteLine("Factorial of a number!");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    FactorialOfNum(num);
            //}




            //Multiplication Table: Write a program to print the multiplication table of a given number.
            //Solution

            //Console.WriteLine("Multiplication of a given number!");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    MultiplicationOfNum(num);
            //}





            //Fibonacci Series: Write a program to print the first N terms of the Fibonacci series.
            //Solution
            //Console.WriteLine("Firts N Fibonacci numbers!");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    FirtsNFibNums(num);
            //}



            //Reverse a Number: Write a program to reverse a given number.
            //Solution
            //Console.WriteLine("Reverse a number!");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    ReversingNumber(num);
            //}




            //Count Digits: Write a program to count the number of digits in a given number.
            //Solution
            //Console.WriteLine("Counting digits of number!");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    DigitsOfNumber(num);
            //}



            //Sum of Digits: Write a program to find the sum of the digits of a given number.
            //Solution
            //Console.WriteLine("Sum of digits in a given number!");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    SumOfDigits(num);
            //}




            //Prime Number Check: Write a program to check if a number is prime.
            //Solution
            //Console.WriteLine("Prime or no!");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    PrimeNumber(num);
            //}




            //Armstrong Number Check: Write a program to check if a number is an Armstrong number.
            //Solution
            //Console.WriteLine("Armstrong or no!");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    ArmStrongOrNo(num);
            //}

            //Pattern Printing: Write a program to print a pyramid pattern of stars.
            //Solution
            //Console.WriteLine("Printing pyramid paterrn of stars");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number of stars for pyramid: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Pyramid(num);
            //}





            //Season Finder: Write a program to find the season based on the month number
            //(e.g., 1 for January, 2 for February, etc.).
            //Solution
            //Console.WriteLine("Finding  season by month number!");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number of month from 1 to 12: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    SeasonFinder(num);
            //}



            //Vowel or Consonant: Write a program to check if a character is a vowel or a consonant.
            //Solution
            //Console.WriteLine("Vowel or Consonant!");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a letter: ");
            //    char letter = Convert.ToChar(Console.ReadLine());
            //    VowelOrConsonant(letter);
            //}



            //Grade to Description: Write a program to print a description(Excellent, Good, Average, etc.)
            //based on a grade(A, B, C, etc.).
            //Solution
            //Console.WriteLine("Description based on grade A,B,C,D,F");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type your Grade: ");
            //    char grade = Convert.ToChar(Console.ReadLine());

            //    GradeDescription(grade);
            //}




            //Check Even or Odd: Write a program to check if a number is even or odd.

            //Solution
            //Console.WriteLine("EVEN or ODD");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    EvenOrOdd(num);
            //}



            //Positive, Negative, or Zero: Write a program to determine if a number is positive, negative, or zero.

            //Solution
            //Console.WriteLine("Positive, Negative or Zero");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    CheckSign(num);
            //}




            //Leap Year: Write a program to check if a year is a leap year.

            //Solution
            //Console.WriteLine("Leap year or no");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    LeapOrNo(num);
            //}



            //Max of Three Numbers: Write a program to find the maximum of three numbers.
            //Solution
            //Console.WriteLine("Max of three numbers");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type the firt number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Type the second number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Type the third number: ");
            //    int num3 = Convert.ToInt32(Console.ReadLine());
            //    MaxOfThreeNums(num1, num2, num3);
            //}




            //Grade Calculation: Write a program to determine the grade(A, B, C, etc.) based on a percentage score.
            //Solution
            //Console.WriteLine("Grade based on percentage score from 0 to 100");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Type your score: ");
            //    int score = Convert.ToInt32(Console.ReadLine());

            //    GradeScore(score);
            //}


            Console.WriteLine("ConsoleApp4");
            Console.ReadLine();
        }
    }
}
