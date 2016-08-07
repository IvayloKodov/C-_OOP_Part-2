using Problem3.DependencyInversion.Contracts;
using Problem3.DependencyInversion.Strategies;

namespace Problem3.DependencyInversion
{
    public class PrimitiveCalculator
    {
        private IStrategy strategy;

        public PrimitiveCalculator()
            :this(new AdditionStrategy())
        {
        }

        public PrimitiveCalculator(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void changeStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.strategy.Calculate(firstOperand, secondOperand);
        }
    }
}