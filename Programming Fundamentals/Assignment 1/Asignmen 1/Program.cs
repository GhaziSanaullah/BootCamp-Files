using System;

namespace Assignment_1_Section_3_and_ahead
{
    public class Program
    {
        public static void Question1()
        {
            Console.WriteLine("Hello, World!"); // This statement prints the greeting to screen
        }
        public static void Question2()
        {
            Console.WriteLine("Enter Username:"); //This line prints on the console Enter Username: asking for a name input
            string username = Console.ReadLine(); //Readline command waits for the user to enter characters and press enters. I made a variable which stores the entered username in it. i defined the class of variable as string before the variable name so that it can store alphabets in the variable. my variable is a string.
            Console.WriteLine("Hello, " + username); //This line prints the hello (with a space added for formatting) and the string. the plus sign is added so that it prints the string after the thing in commas
        }
        public static void Question3()
        {
            Console.WriteLine("This program will ask for two Integers Numbers and then prints their sum"); //displays to user at the top in console what the program is about
            Console.WriteLine("Please Enter Number 1:"); //asks user for 1st number
            int number1 = Convert.ToInt32(Console.ReadLine()); //Documentation says readline only takes strings as input. since i defined that class as int i have to convert it into a integer
            Console.WriteLine("Please Enter Number 2:"); //asks user for 2nd number
            int number2 = Convert.ToInt32(Console.ReadLine()); //Documentation says readline only takes strings as input. since i defined that class as int i have to convert it into a integer
            int sum = number1 + number2; // the two input numbers are stored in var sum
            Console.WriteLine("The sum of numbers is " + sum); //Prints the text in commas and var sum
        }
        public static void Question4()
        {
            Console.WriteLine("This program will ask for a Integer Number and then prints its square"); //displays to user at the top in console what the program is about
            Console.WriteLine("Please Enter Number:"); //asks user for number
            int number = Convert.ToInt32(Console.ReadLine()); //Documentation says readline only takes strings as input. since i defined that class as int i have to convert it into a integer
            int square = number * number; // the input number is squared and stored in square vare
            Console.WriteLine("The square of input number is " + square); //Prints the text in commas and var square
        }
        public static void Question5()
        {
            Console.WriteLine("The even numbers between 1 and 100 are:");
            for(int i=1;i<100;i++)
            {
                if(i%2==0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static void Question6()
        {
            Console.WriteLine("Please Enter the nth number. The program will print sum of numbers from 1 to n");
            double number = Convert.ToInt32(Console.ReadLine()); //i added double because i used arithmetic formula and it corupts the formula if i get a point value
            double sum = number * ((1 + number) / 2); // this is the simplified arithmetic formula which is s=n(a1+an/2)
            Console.WriteLine("The sume of number from 1 to " + number + " is " + sum);
        }
        public static void Question7()
        {
            Console.WriteLine("Please Enter the number for which you want table. The program will print the table upto 12 iterations");
            int number = Convert.ToInt32(Console.ReadLine()); //user enters the number for which they want table here
            int counter = 1;
            Console.WriteLine("The table of " + number + " till 12 iterations is: ");
            while (counter != 13)
            {
                Console.WriteLine(number + " x " + counter + " = " + number * counter); // this makes a nice formatted table
                counter = counter + 1; // this is counter for the loop to function properly
            }
        }
        public static void Question8()
        {
            Console.WriteLine("Please enter the range n till which you want prime numbers:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            int j;
            bool isPrime;
            
            Console.WriteLine("The prime numbers upto {0} are: ", n);
            for (i = 2; i <= n; i++)
            {
                isPrime = true;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static void Question9()
        {
            Console.WriteLine("Enter a number for the factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("The factorial of number is " + factorial);
        }
        public static void Question10()
        {
            Console.WriteLine("Enter the number of terms for sequence");
            int n = Convert.ToInt32(Console.ReadLine());
            int term1 = 0;
            int term2 = 1;
            int term3 = 0;
            Console.WriteLine("Fibonacci sequence upto "+ n + " terms is: ");
            Console.Write(term1 + " ");
            Console.Write(term2 + " ");
            for (int counter=1;counter<=n-2;counter++)
            {
                term3 = term1 + term2;
                Console.Write(term3 + " ");
                term1 = term2;
                term2 = term3;
            }
        }
        public static void Question11()
        {
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + "st number of the array: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the number you want to search in your array: ");
            int n = int.Parse(Console.ReadLine());
            int numposition = 1;
            bool isNotFound = true;
            foreach (int num in array)
            {
                if (n == num)
                {
                    isNotFound = false;
                    Console.WriteLine("Your number is found in the array at " + numposition + " position ");
                }
                numposition++;
            }
            if (isNotFound)
            {
                Console.WriteLine("Your entered number is not found in the array at any position");
            }
        }

        public static void Question12()
        {
            Console.WriteLine("Enter your string:");
            string strng = Console.ReadLine();
            string reversestrng = "";
            for(int i=strng.Length-1;i>=0;i--)
            {
                reversestrng = reversestrng + strng[i];
            }
            if (strng == reversestrng)
                Console.WriteLine("Your entered string is a palindrome");
            else
                Console.WriteLine("Your entered string is not a palindrome");

        }
        public static void Question13()
        {
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + " entry of the array: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<array.Length;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if (array[i]>array[j])
                    {
                        int swapvar = array[i];
                        array[i] = array[j];
                        array[j] = swapvar;
                    }
                }
            }
            Console.WriteLine("The smallest number in the array is " + array[0]);
            Console.WriteLine("The smallest number in the array is " + array[array.Length - 1]);
        }
        public static void Question14()
        {
            Console.WriteLine("Enter the height of triangle:");
            int height = int.Parse(Console.ReadLine());
            for (int i = 1; i <= height; i++)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
            }
        }

        public static void Question15()
        {
            Console.WriteLine("Enter the height of triangle:");
            int height = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= counter; k++)
                {
                    Console.Write("*");
                }
                counter += 2;
                Console.WriteLine();
            }
        }
        public static void Question16()
        {
            Console.WriteLine("Enter your string:");
            string strng = Console.ReadLine();
            string reversestrng = "";
            for (int i = strng.Length - 1; i >= 0; i--)
            {
                reversestrng = reversestrng + strng[i];
            }
            Console.WriteLine("Reversed string is " + reversestrng);
        }
        public static void Question17()
        {
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + " entry of the array: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int swapvar = array[i];
                        array[i] = array[j];
                        array[j] = swapvar;
                    }
                }
            }
            Console.Write("The sorted array is ");
            Console.Write("[");
            for(int k=0;k<array.Length;k++)
            {
                Console.Write(array[k] + ",");
            }
            Console.Write("]");
        }
        
        public static void Question18()
        {
            Console.WriteLine("Enter the number you want to check as perfect: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("Entered number is a perfect number");
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");
            }
        }
        public static void Question19()
        {
            Console.WriteLine("Enter the height of triangle:");
            int height = int.Parse(Console.ReadLine());
            for (int i = 1; i <= height; i++)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write(j);
                    j++;
                }
                Console.WriteLine();
            }
        }
        public static void Question20()
        {
            Console.WriteLine("Enter the first string: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the first string: ");
            string str2 = Console.ReadLine();
            int m = str1.Length;
            int n = str2.Length;
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 0; i <= str1.Length; i++)
            {
                for (int j = 0; j <= str2.Length; j++)
                {
                    if (i == 0 || j == 0)
                        dp[i, j] = 0;
                    else if (str1[i - 1] == str2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
            int lcsLength = dp[m, n];
            char[] lcs = new char[lcsLength];
            int index = lcsLength - 1;
            int p = m;
            int q = n;
            while (p > 0 && q > 0)
            {
                if (str1[p - 1] == str2[q - 1])
                {
                    lcs[index] = str1[p - 1];
                    p--;
                    q--;
                    index--;
                }
                else if (dp[p - 1, q] > dp[p, q - 1])
                    p--;
                else
                    q--;
            }
            Console.WriteLine("Largest Common Subsequence: " + new string(lcs));
        }

        static void Main(string[] args)
        {
            //Question1();
            //Question2();
            //Question3();
            //Question4();
            //Question5();
            //Question6();
            //Question7();
            //Question8();
            //Question9();
            //Question10();
            //Question11();
            //Question12();
            //Question13();
            //Question14();
            //Question15();
            //Question16();
            //Question17();
            //Question18();
            //Question19();
            //Question20();
        }
    }
}

