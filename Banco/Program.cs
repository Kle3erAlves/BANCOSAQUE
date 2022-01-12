using System;
using System.Globalization;
using Banco.Entities;
using Banco.Entities.Exception;
using System.Collections.Generic;



namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());//armazena o numero digitado pelo usuario na variavel "number"
                Console.Write("Holder: ");
                string holder = Console.ReadLine();//armazena o holder digitado pelo usuario na variavel "holder"
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //armazena o saldo digitado pelo usuario na variavel "balance"
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //armazena o limite digitado pelo usuario na variavel "limit"
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //armazena a quantia digitada pelo usuario na variavel "amount"
                Account account = new Account(number, holder, balance, limit);//passa tudo digitado pelo usuario para a classe Account
                                                      
                account.Withdraw(amount);//passa a quantia digitada pelo usuario como parametro para o Metodo "Withdraw"
                Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
                //Exibi na tela o novo Saldo de acordo com o cálculo feito no Metodo "Withdraw"
            }

            catch (DomainException e)
            {
                Console.WriteLine("ERRO NA OPERÇÃO!  " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("ERRO NO FORMATO!  " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO INESPERADO!  " + e.Message);
            }
        }
    }
}
