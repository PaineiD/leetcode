namespace ConsoleApp1;

static class Program
{
    static void Main(string[] args)
    {
        int x = NumberOfSteps(int.Parse(Console.ReadLine()));
        Console.WriteLine(x);
    }
    
    public static int NumberOfSteps(int num)
    {
        int countOfSteps = 0;
        while (num!=0)
        {
            if ((num & 1) == 0)
                num >>= 1;
            else
                num--;
            countOfSteps++;
        }

        return countOfSteps;
    }
}
