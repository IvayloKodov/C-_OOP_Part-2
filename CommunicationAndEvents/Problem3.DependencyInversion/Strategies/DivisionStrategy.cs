using Problem3.DependencyInversion.Contracts;

namespace Problem3.DependencyInversion.Strategies
{
    public class DivisionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}