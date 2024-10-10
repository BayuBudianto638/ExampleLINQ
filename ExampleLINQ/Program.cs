public class Program
{
    static void Main()
    {
        var A = new ModelA();
        A.PropA = "Hello";

        var B = new ModelA();
        B.PropA = "World";

        var listModelA = new List<ModelA>();
        listModelA.Add(A);
        listModelA.Add(B);

        var data = from a in listModelA
                   select new
                   {
                       a.PropA,
                       PropB = Get()
                   };
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }

    private static List<string> Get()
    {
        var list = new List<string>();
        list.Add("A");
        list.Add("B");

        return list;
    }
}

public class ModelA
{
    public string PropA { get; set; }
    public List<string>? PropB { get; set; }
}