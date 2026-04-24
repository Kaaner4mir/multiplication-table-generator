# Multiplication Table Generator

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

A simple, interactive console application written in C# that generates a customized multiplication table based on user input.

## Features
- **Dynamic Range Generation**: Define the ranges for both the multiplicands and multipliers by inputting two upper limits.
- **Easy to Use**: Follow simple console prompts to quickly generate tables.
- **Input Validation**: Gracefully handles invalid numeric inputs to prevent unexpected crashes or errors.

## Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

## Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Kaaner4mir/multiplication-table-generator.git
   ```

2. **Navigate to the project directory:**
   ```bash
   cd multiplication-table-generator/MultiplicationTableGenerator
   ```

3. **Run the application:**
   ```bash
   dotnet run
   ```

## Usage

When you run the application, it will prompt you to enter two numbers:
1. **First number**: Determines the upper limit of the first factor in the multiplication table (iterating from `0` up to your entered number).
2. **Second number**: Determines the upper limit of the second factor (iterating from `0` up to your entered number).

### Example Output
If you enter `2` as the first number and `3` as the second number, the output will look like this:
```
Enter the first number: 2
Enter the second number: 3
0 x 0 = 0
0 x 1 = 0
0 x 2 = 0
0 x 3 = 0
--------------------
1 x 0 = 0
1 x 1 = 1
1 x 2 = 2
1 x 3 = 3
--------------------
2 x 0 = 0
2 x 1 = 2
2 x 2 = 4
2 x 3 = 6
--------------------
```

## Contributing
Contributions, issues, and feature requests are welcome! Feel free to check [issues page](https://github.com/Kaaner4mir/multiplication-table-generator/issues).

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
