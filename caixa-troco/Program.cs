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

            string valorRecebido = "";

            do
            {
                Console.WriteLine("Digite o valor recebido:");
                double recebido = Convert.ToDouble(Console.ReadLine());
                double troco = recebido - preco;

                if (troco < 0)
                {
                    Console.WriteLine("Ops! Você efetuou um pagamento inferior ao valor do produto. Efetue o complemento.");
                }
                if (troco == 0)
                {
                    Console.WriteLine("Obrigado(a) pela preferência! Volte sempre!");
                }
                if (troco > 0)
                {
                    Console.WriteLine("Seu troco é de " + troco + ". Obrigado(a) pela preferência! Volte sempre!");
                }
            } while (valorRecebido != "");
             
        }
    }
}
