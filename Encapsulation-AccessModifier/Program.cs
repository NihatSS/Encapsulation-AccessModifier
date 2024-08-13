using Encapsulation_AccessModifier;
using Encapsulation_AccessModifier.Controller;

//CalculatorContoroller calculator =  new CalculatorContoroller();

//calculator.Calculation();

//Manga manga = new Manga();

//AccountService accountService = new AccountService();

//var response = accountService.Login("nihatss","niko123");

//Console.WriteLine(response.LoginMessage);
//Console.WriteLine(response.EmialMessage);



Person person = new Person();
person.Fincode = "7gahppp";
person.age = 25;

Console.WriteLine(person.Fincode);
Console.WriteLine("----------------------");
person.ShowFincode();
    

//CustomMath math = new CustomMath();

//int num = 10;

//math.GetOddNumberSum(1,2,4,5,6,7,9);
//math.CheckNumber(num);
//math.GetEvenNumbersSumSquare(1, 2, 4, 5, 6, 7, 9);
//math.Factorial(num);