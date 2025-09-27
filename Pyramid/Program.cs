namespace Pyramid
{
    internal class Program
    {
        static void Main(string []args)
        {
            bool validInput = false;
            int height = 0;

            while(!validInput) {
            // Asking the user the pyramid size
            Console.Write("Enter the height (a number) of the pyramid and press ENTER: ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parsedHeight))
            {
                if (parsedHeight > 1 && parsedHeight < 41) 
                {
                    validInput = true;
                    height = parsedHeight;
                    }
                 else
                 {
                    Console.WriteLine("You need to enter a value between 2 and 40. Try again.");
                    validInput = false;
                    }
                    }
                 else 
                 {
                    Console.WriteLine("You need to enter a number! Try again.");
                    validInput = false;
                    }
            }
            // Build rows
            for (int row = 1; row <= height; row++)
            {
                // Step 1: Print the spaces for this row
                    int numberOfSpaces = height - row;
                    for (int s = 0; s < numberOfSpaces; s++)
                    {
                        // Print one space per iteration
                        Console.Write(" "); 
                    }
                // Step 2: Print the stars for this row                    
                    int numberOfStars = 2*row - 1;
                    for (int st = 0; st < numberOfStars; st++)
                    {
                        // Print one star per iteration
                        Console.Write("*"); 
                    }
                
                
                // Step 3: Move to the next line
                Console.WriteLine();
            }
        }
    }
}