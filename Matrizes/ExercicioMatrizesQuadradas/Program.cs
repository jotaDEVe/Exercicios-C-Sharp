class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Insira o tamanho da matriz quadrada (linhas = colunas): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];


        Console.WriteLine("Entre com os valores separados por espaço: ");
        //Itera sobre as linhas
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            string[] values = Console.ReadLine().Split(' ');

            //Itera sobre as colunas
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(values[j]);
            }
        }

        //Imprime a Diagonal Principal
        Console.WriteLine();
        Console.WriteLine("Diagonal Principal:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(matriz[i, i] + " ");
        }
        Console.WriteLine();

        //Conta todos os números negativos
        int count = 0;
        for (int i = 0; i < n; i++)
        { 
            for(int j = 0;j < n; j++)
            {
                if (matriz[i,j] < 0)
                {
                    count++;
                }
            }
        }
        Console.WriteLine("Existem " + count + " números negativos na matriz percorrida");
    }
}