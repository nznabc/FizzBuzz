using FizzBuzz.Contracts;

namespace FizzBuzz
{
    internal class DivideByThree : BaseRule
    {
        public override int Divisor => 3;

        public override string Word => "Fizz";

        public override int Order => 1;
    }
}
