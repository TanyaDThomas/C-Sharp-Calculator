# C-Sharp-Calculator Applicaion

A simple command-line calculator application built in C#. This program allows the user to perform basic arithmetic operations such as addition, subtraction, multiplication, and division. It also handles input validation and ensures that division by zero is prevented.

## Features

- **Basic Arithmetic Operations**: Add, Subtract, Multiply, and Divide.
- **User Input Validation**: Ensures that the user inputs valid numbers and operations.
- **Error Handling for Division by Zero**: If the user attempts to divide by zero, the program will prompt them to enter new numbers.
- **Interactive Command-Line Interface**: Easy-to-follow text-based interface that guides the user through each operation.

## How to Use

1. **Clone the Repository**  
   Clone the repository to your local machine:
   ```bash
   git clone https://github.com/your-username/calculator-app.git
    ```
2. **Run the Program**  
   Open the project in Visual Studio or another C# IDE. Then, build and run the project.

3. **Choose an Operation**  
   The program will ask you to choose an operation:
      - 1 for Addition
      - 2 for Subtraction
      - 3 for Multiplication
      - 4 for Division
  
  4. **Input Numbers**  
     After selecting an operation, you will be prompted to enter two numbers. For multiplication and division, the program uses double data types to handle   
     decimal numbers.

   5. **Exit the Program** 
      Type quit when prompted to exit the program, or simply press Enter to continue with another operation.

## Example
### Sample Interaction:
```vbnet
Choose the number of an operation:
1. ADDITION
2. SUBTRACTION
3. MULTIPLICATION
4. DIVISION

1
YOU CHOSE ADDITION
Please enter a number to add to: 5
Please enter another number to add: 10
5 + 10 = 15
Press ENTER to continue or type quit to exit.
```

### Division Example (with error handling):
```vbnet
Choose the number of an operation:
1. ADDITION
2. SUBTRACTION
3. MULTIPLICATION
4. DIVISION

4
YOU CHOSE DIVISION
Please enter a number to divide from: 10
Please enter another number to divide: 0
Cannot divide by zero. Please try again.
Enter number: 10
Enter other number: 2
10 / 2 = 5
Press ENTER to continue or type quit to exit.
```

## Functions
- Add (int num1, int num2)
 Adds two integers and returns the result.

- Subtract (int num1, int num2)
 Subtracts the second integer from the first and returns the result.

- Multiply (double num1, double num2)
 Multiplies two floating-point numbers and returns the result.

- Divide (double num1, double num2)
 Divides the first floating-point number by the second. If division by zero is attempted, it prompts the user for new input.

## Installation
 1. Install Visual Studio or your preferred C# development environment.
 2. Clone this repository:
 ```bash
 git clone https://github.com/TanyaDThomas/calculator-app.git
 ```
 3. Open the project in your development environment and build it.

## Contributing
Contributions are welcome! If you have any suggestions or find bugs, feel free to open an issue or submit a pull request.
 1. Fork the repository.
 2. Create a new branch for your feature or bug fix.
 3. Make your changes.
 4. Commit and push your changes.
 5. Open a pull request.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

