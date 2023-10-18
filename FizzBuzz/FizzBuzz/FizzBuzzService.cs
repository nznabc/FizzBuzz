using FizzBuzz.Contracts;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly List<BaseRule> _rules;

        public FizzBuzzService()
        {
            _rules = Utility.GetImplementations<BaseRule>();
        }

        public string[] ShowResult(IEnumerable<int> inputs)
        {
            ValidateParameters(inputs);

            var result = new List<string>();

            foreach (var input in inputs)
            {
                var stringBuildr = new StringBuilder();

                foreach (var rule in _rules.OrderBy(x => x.Order))
                {
                    var outPut = rule.Calculate(input);

                    if (!int.TryParse(outPut, out int _))
                    {
                        stringBuildr.Append(outPut);
                    }
                }

                if (stringBuildr.Length > 0)
                {
                    result.Add(stringBuildr.ToString());
                }
                else
                {
                    result.Add(input.ToString());
                }
            }

            return result.ToArray();

            void ValidateParameters(IEnumerable<int> inputs)
            {
                if (!inputs.Any())
                {
                    throw new ArgumentNullException();
                }

                if (!inputs.All(x => x >= 1 && x <= 100))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
