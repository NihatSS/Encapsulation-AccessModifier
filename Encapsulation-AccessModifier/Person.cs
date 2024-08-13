namespace Encapsulation_AccessModifier
{
    internal class Person
    {
        public string name;
        public int age;
        private string fincode;

        public Person()
        {
            Console.WriteLine(fincode);
        }
        public string Fincode 
        { 
            get 
            {
                if (age >=20) return fincode;
                return "error";
            }
            set 
            {
                fincode = value;
            } 
        }

        public void ShowFincode()
        {
            Console.WriteLine(fincode);
        }

    }
}
