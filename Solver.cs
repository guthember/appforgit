public class Solver
{
    private int _numberOfSolutions;
    public Solver(int numberOfSolutions)
    {
        _numberOfSolutions = numberOfSolutions;
    }

    public int add(int number)
    {
        return _numberOfSolutions + number;
    }
}
