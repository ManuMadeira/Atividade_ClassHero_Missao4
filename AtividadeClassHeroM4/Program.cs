internal class Program
{
    private static void Main(string[] args)
    {
        int[] num = new int[10];
        int maior = int.MinValue;
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write($"Digite um numero {i + 1}: ");
            num[i] = int.Parse(Console.ReadLine());

            if (num[i] > maior)
                maior = num[i];
        }
        Console.WriteLine($"Maior Numero digitado é {maior}" );
    }
}