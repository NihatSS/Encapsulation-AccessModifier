namespace Encapsulation_AccessModifier.Service
{
    internal class CalculatorService
    {
        public double Calculation(double x, double y,string operation)
        {
            switch (operation)
            {
                case "+":
                    return x + y;
                case "-":
                    return x - y;
                case "/":
                    return x / y;
                case "*":
                    return x * y;
            }
            return default;
        }
    }
}
