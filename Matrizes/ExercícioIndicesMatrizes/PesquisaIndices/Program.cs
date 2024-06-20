
Console.WriteLine("Entre com o número de linhas da matriz: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o número de colunas da matriz: ");
int n = int.Parse(Console.ReadLine());

int[,] matriz = new int[m, n];


Console.WriteLine("Entre com os valores separados por espaços: ");


//Itera sobre as linhas
for (int i = 0; i < m; i++)
{
   String[] values = Console.ReadLine().Split(" ");

    //Itera sobre as colunas
    for(int j = 0; j < n; j++)
    {
        matriz[i, j] = int.Parse(values[j]);
    }

}

Console.WriteLine("\nDigite um número da matriz para ler suas coordenadas: ");
int numAlvo = int.Parse(Console.ReadLine());

int linhaNumAlvo = 0;
int colunaNumAlvo = 0;

//Itera sobre as linhas
for (int i = 0; i < m; i++)
{

    //Itera sobre as colunas
    for (int j = 0; j < n; j++)
    {
        if (matriz[i,j] == numAlvo)
        {
            linhaNumAlvo = i;
            colunaNumAlvo = j;
            break;
        }
    }

}

Console.WriteLine("\n#########################################");
Console.WriteLine("Posição do número: [" + linhaNumAlvo + ", " + colunaNumAlvo + "]");

if (colunaNumAlvo > 0) 
{
    Console.WriteLine("Esquerda do número: " + matriz[linhaNumAlvo, colunaNumAlvo - 1]);
}

if(colunaNumAlvo < n - 1)
{
    Console.WriteLine("Direita do número: " + matriz[linhaNumAlvo, colunaNumAlvo + 1]);
}

if(linhaNumAlvo < m - 1)
{
    Console.WriteLine("Abaixo do número: " + matriz[linhaNumAlvo + 1, colunaNumAlvo]);
}

if (linhaNumAlvo > 0)
{
    Console.WriteLine("Acima do número: " + matriz[linhaNumAlvo - 1, colunaNumAlvo]);
}
Console.WriteLine("##########################################");