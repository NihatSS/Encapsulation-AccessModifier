using Encapsulation_AccessModifier.Service;

namespace Encapsulation_AccessModifier.Controller
{
    internal class CalculatorContoroller
    {
        CalculatorService service;
        public string[] operations; 
        public CalculatorContoroller()
        {
            service = new CalculatorService();
            operations = new string[] {"+","-","/","*"};
        }

        public void Calculation()
        {
            Console.WriteLine("Enter the first num: ");
            double num1 =Convert.ToDouble( Console.ReadLine());

            Console.WriteLine($"Choose operation {String.Join(",",operations)} : ");
            Operation: string operation = Console.ReadLine();

            if (!operations.Contains(operation))
            {
                Console.WriteLine($"Please select corret operation {String.Join(",",operations)} : ");
                goto Operation;
            }

            Console.WriteLine("Enter the second num: ");
            Num2: var num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 == 0 && operation == "/")
            {
                Console.WriteLine("Can't divide to zero! Please choose correct operation: ");
                goto Num2;
            }

            var response = service.Calculation(num1,num2,operation);
            Console.WriteLine($"result: {num1} {operation} {num2} = {response}");
        }
    }
}
