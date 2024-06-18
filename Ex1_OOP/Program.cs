
using Ex1_OOP;
using System.Runtime.CompilerServices;


Console.WriteLine("Entre o titular da conta: ");
string cTitular = Console.ReadLine();

Console.WriteLine("Entre o número da conta: ");
int cNum = int.Parse(Console.ReadLine());

Console.WriteLine("Haverá um depósito inicial? (s/n): ");
string condicaoDeSaldo = Console.ReadLine();

double cSaldo = 0;

Conta c = new Conta(cTitular, cSaldo, cNum);

if (condicaoDeSaldo == "s")
{
    Console.WriteLine("Entre o saldo inicial da conta: ");
    cSaldo = double.Parse(Console.ReadLine());
} 


Console.WriteLine("\n" + c);

Console.WriteLine("\nInsira um valor para seu depósito: ");
double depositValue = double.Parse(Console.ReadLine());
c.Deposit(depositValue);



Console.WriteLine("\nDados da conta atualizados: ");
Console.WriteLine("\n" + c);