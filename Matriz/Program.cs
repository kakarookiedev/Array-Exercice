namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INPUT ARRAY DIMENSIONS: ");
            int n = int.Parse(Console.ReadLine());
            int negativeNum = 0;
            int[,] matriz = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] value = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(value[j]);
                    if (matriz[i, j] < 0)
                    {
                        negativeNum++;
                    }
                }
            }
            Console.WriteLine("\nMAIN DIAGONAL: ");
            for (int i = 0; i < n; i++)
            {
                int j = i;
                Console.Write(matriz[i, j] + " ");

            }
            Console.WriteLine($"\nNEGATIVE NUMS COUNT = {negativeNum}");
        }
    }
}