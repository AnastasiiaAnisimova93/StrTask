namespace StringTask;

public class Program
{
    //dog dgo -> true 
    //dog dfo -> false
    //dogd ddog -> true
    //doog ddog -> false

    public static void Main(string[] args)
    {
        var result = StringOperation.CompareStrings("dogd", "ddog");

        Console.WriteLine(result);
    }
}