namespace Pyramid
{
    internal class Program
    {
        static void Main(string []args)
        {
                Console.WriteLine("Welcome to the Pyramid Builder app!");
                Console.WriteLine("Enter a character to build the pyramid or press ENTER for \"*\": ");
            string? userString = Console.ReadLine();
            char pyramidChar;
            if (string.IsNullOrEmpty(userString))
            {
                // User pressed Enter, use the default
                pyramidChar = '*';
            }
            else
            {
                // User typed something, use the first charachter
                pyramidChar = userString[0];
            }

            bool validInput = false;
            int height = 0;

            while(!validInput) {
   

            // Now we ask the user the pyramid size
            Console.WriteLine("Enter the height (a number) of the pyramid and press ENTER: ");
            string? userInput = Console.ReadLine();
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
                        Console.Write(pyramidChar);
                        // TODO: so the user can choose char
                        // Console.Write($"{userChar}"); 
 
                    }
                
                
                // Step 3: Move to the next line
                Console.WriteLine();
            }
        }
    }
}