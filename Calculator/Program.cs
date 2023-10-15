using System;

namespace CalculatorInCSharp
{
    class Calculator
    {

        public static void Main (string[] args)
        {
            bool useAgain = true; //variable to be used when asking the user if they want to use the app again

            do //use a do loop for the program to run atleast once
            {
                //declare and initialize variables to be used in the calculator
                int a = 0;
                int b = 0;
                int c = 0;

                //provide information about the program and ask user to input a number based on the operation the user would like to use
                Console.WriteLine("This is a calculator that calculates the value between two whole numbers\n" +
                                    "Please type the corresponding number (1 to 4) to select an operation: \n" +
                                    "1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n");

                //declare an int variable called operation to hold the value of the input from the user
                int operation = Convert.ToInt32(Console.ReadLine());

                //use a switch case and pass the int variable operation as a parameter to determine which operation will be used based on the user input
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("\nYou chose Addition!\n");
                        break;
                    case 2:
                        Console.WriteLine("\nYou chose Subtraction!\n");
                        break;
                    case 3:
                        Console.WriteLine("\nYou chose Multiplication!\n");
                        break;
                    case 4:
                        Console.WriteLine("\nYou chose Division!\n");
                        break;
                    default: //created a default for values outside of definition (non 1, 2, 3, and 4 int inputs)
                        Console.WriteLine("\nYou entered the wrong number!\nThe program will exit now");
                        Console.ReadLine();
                        return; //return exits the program
                }


                Console.WriteLine("Enter your first number: "); //ask the the user to input the first number
                a = Convert.ToInt32(Console.ReadLine()); //read and convert it to int and then set the value to a
                Console.WriteLine("Enter your second nubmer: "); //ask the the user to input the second number
                b = Convert.ToInt32(Console.ReadLine()); //read and convert it to int and then set the value to b

                //use a switch case and pass the variable operation as a parameter to determine what operation will be used and print the output
                switch (operation)
                {
                    case 1:
                        c = a + b;
                        Console.WriteLine("\nThe sum of " + a + " + " + b + " is: " + c);
                        break;
                    case 2:
                        c = a - b;
                        Console.WriteLine("\nThe difference of " + a + " - " + b + " is: " + c);
                        break;
                    case 3:
                        c = a * b;
                        Console.WriteLine("\nThe product of " + a + " * " + b + " is: " + c);
                        break;
                    case 4:
                        c = a / b;
                        Console.WriteLine("\nThe quotient of " + a + " / " + b + " is: " + c);
                        break;
                }
                Console.Write("\nDo you want to use the Calculator again? (Y/N): ");
                String response = Console.ReadLine();
                response.ToLower();
                if (response == "y") 
                {
                    Console.Clear(); //if user wants to use the program again, clear the console and start the loop again
                }
                else //if user doesn't want to use the program again, set the useAgain bool variable to false and exit the loop
                {
                    useAgain = false;
                    Console.WriteLine("Thank you for using the Calculator app!");
                }
            } while (useAgain);
            Console.ReadLine();
        }
    }
}