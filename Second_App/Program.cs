namespace Second_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(args[0]);
            int B = int.Parse(args[1]);

            switch (args[2])
            {
                case "+":
                    Console.WriteLine(A + B);
                    break;
                case "-":
                    Console.WriteLine(A - B);
                    break;
                case "*":
                    Console.WriteLine(A * B);
                    break;
                case "/":
                    Console.WriteLine(A / B);
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
