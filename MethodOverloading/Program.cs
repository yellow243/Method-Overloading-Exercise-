namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
          var answer = Methods.Add(672, 154);
            Console.WriteLine(answer);
           var answer2 = Methods.Add(6.261, 9.811);
            Console.WriteLine(answer2);
            var answer3 = Methods.Add(153, 1047, true);
            Console.WriteLine(answer3);
        }
    }
}
