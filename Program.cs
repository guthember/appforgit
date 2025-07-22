Console.WriteLine("Hello, World!");
Console.WriteLine("Swiftful thinking is awesome!");
Console.WriteLine("This is a new line added to the Program.cs file.");
Console.WriteLine("this line is added after stashes modification");
Console.WriteLine("add a line in remote repo");
Console.WriteLine("This is a new line added to the Program.cs file.");
Console.WriteLine("This is the end of the writing some line.");

Console.WriteLine("Using the Solver class to perform calculations.");
var solver = new Solver(4);
Console.WriteLine($"Add 2: {solver.Add(2)}");
Console.WriteLine($"Subtract 2: {solver.Subtract(2)}");
Console.WriteLine($"Multiply by 2: {solver.Multiply(2)}");
Console.WriteLine($"Divide by 2: {solver.Divide(2)}");
Console.WriteLine("End of calculations.");  

solver.ChangeNumberOfSolutions(10);
Console.WriteLine($"Add 2: {solver.Add(2)}");
Console.WriteLine($"Subtract 2: {solver.Subtract(2)}");
Console.WriteLine($"Multiply by 2: {solver.Multiply(2)}");
Console.WriteLine($"Divide by 2: {solver.Divide(2)}");
Console.WriteLine("End of calculations with the new number of solutions."); 