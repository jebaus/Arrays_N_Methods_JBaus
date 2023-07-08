// See https://aka.ms/new-console-template for more information
namespace Arrays_N_Methods_JBaus
{
    class Program
    {
        //Establish the array that'll be granted random numbers when called 
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] ArrayOne = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                //Have the array choose random numbers ranging from 10-50
                ArrayOne[i] = random.Next(10,50);
            }
            return ArrayOne;
        }
        //Calculate the sum of all the numbers in the array
        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int y in array)
            {
                //Add up all of the numbers together
                sum += y;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //Establish while loop to help the if statment properly break
            while(true)
            {
                //Try/catch statement to catch inputs that aren't integers
                try
                {
                    //Prompt the user to select certain numbers
                    Console.WriteLine("Enter a number between 5 and 15: ");
                    int input = int.Parse(Console.ReadLine());
                    int[] ArrayTwo = random_array(input);

                    //If statement to catch any inputs that aren't between 5-15
                    if (input >= 5 && input <= 15)
                    {
                        Console.WriteLine("The numbers in the random array are: ");
                        foreach (int x in ArrayTwo)
                        {
                            //Have the numbers output in a single line in the console
                            Console.Write(x + " ");
                        }

                        Console.WriteLine(" ");
                        //Output the sum of the numbers in the console
                        Console.WriteLine("The sum of the numbers are: " + sum(ArrayTwo));
                        //End the function
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please choose a number between only 5 and 15.");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            }         
        }
    }
}


