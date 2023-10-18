using FizzBuzz.Contracts;

namespace FizzBuzz.Rules
{
    internal sealed class DivideByFive : BaseRule
    {
        public override int Divisor => 5;

        public override string Word => "Buzz";

        public override int Order => 2;
    }
}
