namespace FizzBuzz.Contracts
{
    public interface IFizzBuzzService
    {
        string[] ShowResult(IEnumerable<int> inputs);
    }
}
