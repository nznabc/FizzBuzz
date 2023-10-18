namespace FizzBuzz.Contracts
{
    public interface IFizzBuzzService
    {
        /// <summary>
        /// Processes an enumerable of int and returns an array of strings with the FizzBuzz logic applied.
        /// </summary>
        /// <param name="inputs">An enumerable of int that represent numbers to be processed by the FizzBuzz logic. Each string must be a valid integer or an exception will be thrown.</param>
        /// <returns>A string array that contains the results of applying the FizzBuzz logic to each input string. The FizzBuzz logic is as follows:
        /// - If the input number is divisible by 3, return "Fizz".
        /// - If the input number is divisible by 5, return "Buzz".
        /// - If the input number is divisible by both 3 and 5, return "FizzBuzz".
        /// - Otherwise, return the input string unchanged.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if the inputs parameter is null.</exception>        
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown if any of the input int is outside the range of 1-100</exception>
        string[] ShowResult(IEnumerable<int> inputs);
    }
}
