# PyramidBuilder 🏗️

A C# console application that builds ASCII pyramids based on user input. This project demonstrates fundamental programming concepts including nested loops, pattern recognition, and user input validation.

## 📋 Project Overview

**Assignment**: Labb 3 - Pyramidbyggaren  
**Course**: C# .NET Programming  
**Objective**: Create a console application that builds pyramids using nested loops and mathematical patterns

## 🎯 Features

- **Interactive Input**: User specifies pyramid height
- **Dynamic Pyramid Generation**: Builds pyramids of any reasonable size
- **Mathematical Pattern Implementation**: Uses formulas for spacing and character placement
- **Clean Console Output**: Properly formatted and centered pyramids

## 🏃‍♂️ How to Run

### Prerequisites
- .NET 6.0 or later
- Visual Studio, VS Code, or any C#-compatible IDE

### Running the Application
1. Clone this repository
2. Navigate to the project directory
3. Run the application:
   ```bash
   dotnet run
   ```
4. Enter the desired pyramid height when prompted
5. View your beautiful ASCII pyramid!

## 📊 Example Output

**Input: Height = 4**
```
Enter the height of the pyramid and press ENTER: 4
   *
  ***
 *****
*******
```

**Input: Height = 6**
```
Enter the height of the pyramid and press ENTER: 6
     *
    ***
   *****
  *******
 *********
***********
```

## 🧮 Algorithm & Logic

### Mathematical Patterns Identified
- **Spaces per row**: `height - row_number`
- **Stars per row**: `2 × row_number - 1`
- **Pattern sequence**: 1, 3, 5, 7, 9... (odd numbers)

### Implementation Strategy
1. **Outer Loop**: Iterates through each row (1 to height)
2. **Inner Loop 1**: Prints required spaces for centering
3. **Inner Loop 2**: Prints required stars for that row
4. **Line Break**: Moves to next row

### Code Structure
```csharp
for (int row = 1; row <= height; row++)
{
    // Print spaces: (height - row) times
    for (int s = 0; s < numberOfSpaces; s++)
        Console.Write(" ");
    
    // Print stars: (2 * row - 1) times  
    for (int st = 0; st < numberOfStars; st++)
        Console.Write("*");
    
    // Move to next line
    Console.WriteLine();
}
```

## 🔧 Technical Details

**Language**: C# (.NET)  
**Application Type**: Console Application  
**Key Concepts Demonstrated**:
- Nested loops
- User input handling with `Console.ReadLine()`
- String parsing with `int.Parse()`
- Mathematical pattern implementation
- Console output formatting

## 🎓 Learning Outcomes

This project reinforced several fundamental programming concepts:

1. **Pattern Recognition**: Identifying mathematical relationships in visual patterns
2. **Loop Design**: Understanding when and how to use nested loops effectively
3. **Algorithm Development**: Breaking down complex problems into simple, logical steps
4. **Input Validation**: Handling user input safely and effectively
5. **Code Organization**: Writing clean, readable, and well-commented code

## 🚀 Future Enhancements

Potential improvements that could be added:

- **Error Handling**: Validate user input and handle invalid entries gracefully
- **Custom Characters**: Allow users to choose the building character
- **Inverted Pyramids**: Option to build upside-down pyramids
- **Hollow Pyramids**: Create pyramid outlines instead of filled shapes
- **Color Support**: Add colored output for enhanced visual appeal
- **Size Limits**: Implement reasonable size constraints for better user experience

## 📂 Project Structure

```
PyramidBuilder/
├── Program.cs          # Main application logic
├── PyramidBuilder.csproj    # Project configuration
└── README.md          # This documentation
```

## 🎯 Assignment Requirements Met

- ✅ Console application created in Visual Studio
- ✅ Project named "PyramidBuilder" 
- ✅ User input for pyramid height
- ✅ Correct pyramid output with proper spacing
- ✅ Mathematical formulas implemented correctly
- ✅ Nested loops used effectively
- ✅ Clean, readable code with comments

## 👨‍💻 Development Process

This project was developed using a **problem-solving first** approach:

1. **Pattern Analysis**: Studied the example outputs to identify mathematical relationships
2. **Formula Derivation**: Developed equations for spaces and stars per row
3. **Algorithm Design**: Planned the nested loop structure before coding
4. **Incremental Development**: Built and tested one component at a time
5. **Code Refinement**: Cleaned up syntax and added meaningful comments

## 📝 Reflection

Building this pyramid generator was an excellent exercise in:
- **Mathematical thinking**: Converting visual patterns into formulas
- **Algorithmic design**: Breaking complex problems into simple steps  
- **Debugging skills**: Testing and refining loop logic
- **Code clarity**: Writing self-documenting, professional code

The most challenging aspect was visualizing how the nested loops would interact to create the final output, but working through the mathematical relationships step-by-step made the solution clear and elegant.

---

**Course**: SUT25 C# .NET Programming  
**Student**: Antonio Lingårdsson Luna  
**Date**: September 2025
