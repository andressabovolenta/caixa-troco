using System;

namespace caixa_troco
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAXA - TROCO

            Console.WriteLine("Digite o valor do produto:");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor pago pelo cliente:");
            double recebido = Convert.ToDouble(Console.ReadLine());
            double troco = recebido - preco;
            if (troco != 0)
            {
                Console.WriteLine("Seu troco é de R$" + troco + ". Obrigado(a) pela preferência! Volte sempre!");
            }
            else
            {
                Console.WriteLine("Obrigado(a) pela preferência! Volte sempre!");
            }

            //DÚVIDA: Como criar o loop para que o console continue a exibir a primeira instrução enquanto o usuário não apertar "enter" (vazio)?
        }
    }
}
