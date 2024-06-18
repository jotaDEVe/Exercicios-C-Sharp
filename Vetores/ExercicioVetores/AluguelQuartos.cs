using System;

public class AluguelQuartos
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o número de quartos a serem alugados: ");
        int n = int.Parse(Console.ReadLine());

        while (n > 10)
        {
            Console.WriteLine("A quantidade de quartos disponíveis é de 10 unidades, suas reservas excedem o limite.");
            Console.WriteLine("Digite um número de reservas válido: ");
            n = int.Parse(Console.ReadLine());
        }

        Reserva[] vetorReservas = new Reserva[9];

        for (int i = 0; i < n; i++)
        { 
            Console.WriteLine("Digite o nome do estudante: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite o email do estudante: ");
            string email = Console.ReadLine();
            Console.WriteLine("Digite o quarto a ser alugado: ");
            int room = int.Parse(Console.ReadLine());
            vetorReservas[i] = new Reserva(room, email, name);
        }

        Console.WriteLine("Quartos reservados: \n\n");
        for (int i = 0; i < 9; i++)
        {
            if (vetorReservas[i] != null)
            {
                Console.WriteLine(vetorReservas[i].room + ": " + vetorReservas[(i)]);
            }
        }



    }
}