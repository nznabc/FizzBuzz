namespace FizzBuzz.Contracts
{
    internal abstract class BaseRule
    {
        // The divisor that determines if the rule applies
        public abstract int Divisor { get; }

        // The word that replaces the number if the rule applies
        public abstract string Word { get; }

        // Order of the execution
        public abstract int Order { get; }

        public virtual string Calculate(int input)
        {
            if (input % Divisor == 0)
            {
                return Word;
            }

            return input.ToString();
        }
    }
}
