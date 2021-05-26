using Numeru.Numerologic;
using System.Linq;

namespace Numeru.Services
{
    public class PersonAlgorithm : AbstractEvaluationAlgorithm<Person>
    {
        private readonly IAlphabet _alphabet;

        public PersonAlgorithm(AbstractEvaluator evaluator, IEvaluationTracer tracer, IAlphabet alphabet): base(evaluator, tracer)
        {
            this._alphabet = alphabet;
        }

        public override string Abstraction()
        {
            return "Полное имя + Дата рождения";
        }

        protected override string ToNumber(Person value)
        {
            var numbers = value.Fullname
                .Select(c => c.ToString())
                .Where(c => this._alphabet.Contains(c))
                .Select(c => this._alphabet.NumberOf(c))
                .ToArray()
                ;

            return string.Join("", numbers) + value.BirthDate.ToString("ddMMyyyy");
        }
    }
}
