public class Solver
{
    private int _numberOfSolutions;
    public Solver(int numberOfSolutions)
    {
        _numberOfSolutions = numberOfSolutions;
    }

    public int Add(int number)
    {
        return _numberOfSolutions + number;
    }

    public int Subtract(int number)
    {
        return _numberOfSolutions - number;
    }

    public int Multiply(int number)
    {
        return _numberOfSolutions * number;
    }
    public int Divide(int number)
    {
        if (number == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return _numberOfSolutions / number;
    }

    public void ChangeNumberOfSolutions(int newNumber)
    {
        if (newNumber <= 0)
        {
            _numberOfSolutions = 1; // Default to 1 if invalid input
            Console.WriteLine("Invalid number of solutions provided. Defaulting to 1.");
        }
        else
        {
            _numberOfSolutions = newNumber;
        }
    }
}
