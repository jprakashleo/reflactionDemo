namespace PrintAll
{
    
    public class CustomPrint
    {
        private string name;
        public void Print()
        {
            Console.WriteLine("print from lib");
        }
        public string Getname()
        {
            return name;
        }
        public void Printname()
        {
            Console.WriteLine($"here name is {name}");
        }
        public void  Print(string val)
        {
            Console.WriteLine($"here name is {val}");
        }
        private void PrintPrivate()
        {
            Console.WriteLine("here name private name");
        }
        public string Name => name;
        public static string staticname => "static name";
    }
}