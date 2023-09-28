namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercise =0;
            Console.WriteLine("Please enter the exercise number:");
            exercise = int.Parse(Console.ReadLine());

            //VARIABLES
            int num1, num2, num3, sum1, sum2, sum3;

            switch (exercise)
            {
                case 1:
                    Console.WriteLine("Exercise 1");

                    //EXERCISE 1
                    
                    //START
                    Console.WriteLine("Please enter number 1:");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter number 2:");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter number 3:");
                    num3 = int.Parse(Console.ReadLine());

                    sum1 = num1 + num2;
                    sum2 = num2 + num3;
                    sum3 = num1 + num3;

                    if (sum1 == num3)
                    {
                        Console.WriteLine("num3 is the sum of num 1 + num 2");
                    }
                    else if (sum2 == num1)
                    {
                        Console.WriteLine("num1 is the sum of num 2 + num 3");
                    }
                    else if (sum3 == num2)
                    {
                        Console.WriteLine("num2 is the sum of num 1 + num 3");
                    }
                    else
                    {
                        Console.WriteLine("No solution");
                    }

                    break;
                case 2:
                    Console.WriteLine("Exercise 2");
                    break;
                default:
                  Console.WriteLine("Wrong option");
                  break;
            }


            

            //EXERCISE 2


        }
    }
}