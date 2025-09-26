namespace Pyramid
{
    internal class Program
    {
        static void Main(string []args)
        {
            // Asking the user the pyramid size
            Console.Write("Enter the height of the pyramid and press ENTER: ");
            string userInput = Console.ReadLine();
            int height = int.Parse(userInput);
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