using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1_Application_Ereed6 {
    internal class Program {
        static void Main(string[] args) {

            // Initialization of variables
            double[] numberArray = new double[999];
            double number = 0;
            int count = 0;
            String choice = "Y";


            // Loop to enter any number into array, and prompt to ask the client if they wish to continue.
            do {

                // prompts clinet what number they wish to enter. 
                Console.Write("Enter the amount of numbers you wish to input: ");

                // A try catch method to make sure the client entered a valid  number.
                try {
                    number = Convert.ToDouble(Console.ReadLine());
                } catch (FormatException) {
                    Console.Write("Not a valid number please type a valid number: ");
                    number = Convert.ToDouble(Console.ReadLine());
                }
               

                // The client input is stored in the array, and the count for the array is increased.
                numberArray.SetValue(number, count);
                count++;

                // The client is prompted if they wish to continue and Y to continue and N to quit.
                Console.Write("Do you wish to continue? Y or N: ");
                choice = Console.ReadLine();

            } while (choice.Equals("Y") || choice.Equals("y"));  // If client types y or Y the loop continues.


            // For loop that displays the clients inputs.
            Console.Write("The numbers you inputted are: ");
            Console.Write(numberArray[0]);
            for (int i = 0; !i.Equals(count - 1); i++) {
                Console.Write(", " + numberArray[i+1]);
            }

            
            

            Console.ReadLine();
        }
    }
}
