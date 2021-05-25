namespace Numeru.Numerologic
{
    public class BaseEvaluator : AbstractEvaluator
    {
        protected override bool Done(Number number)
        {
            return number.IsBase();
        }
    }
}
