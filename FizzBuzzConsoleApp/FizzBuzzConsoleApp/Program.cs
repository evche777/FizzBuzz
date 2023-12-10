using MathsTask;

class FizzBuzzMainClass
{
    static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        var output = new FizzBuzz().execute(x);
        output.ForEach(entry => Console.WriteLine(entry));
        Console.ReadLine();
    }
}