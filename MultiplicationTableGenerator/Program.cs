namespace MultiplicationTableGenerator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        if (!int.TryParse(Console.ReadLine(), out int firstNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.Write("Enter the second number: ");
        if (!int.TryParse(Console.ReadLine(), out int secondNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        for (int i = 0; i <= firstNumber; i++)
        {
            for (int j = 0; j <= secondNumber; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}
