using Problem3.DependencyInversion.Contracts;

namespace Problem3.DependencyInversion.Strategies
{
    class AdditionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}