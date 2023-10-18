using FizzBuzz;
using FizzBuzz.Contracts;

// Create an instance of a class that implements IFizBuzzService
IFizzBuzzService service = new FizzBuzzService();

// Create a list of strings to be processed
List<int> inputs = Enumerable.Range(1, 100).ToList();

// Call the ShowResult method and print the output array
string[] output = service.ShowResult(inputs);

Console.WriteLine(string.Join(", ", output));