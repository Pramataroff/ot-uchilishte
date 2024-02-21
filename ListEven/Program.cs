namespace ListEven
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine("even "+ string.Join(" ",GetEvenElements(list)));
            Console.WriteLine("odd "+string.Join(" ", GetoddElements(list)));
        }
        static List <int> GetEvenElements (List<int> input)
        {
            List<int> listEven = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    listEven.Add(input[i]);
                }
            }
            return listEven;
        }
        static List<int> GetoddElements(List<int> input)
        {
            List<int> listodd = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 != 0)
                {
                    listodd.Add(input[i]);
                }
            }
            return listodd;
        }
    }
}
