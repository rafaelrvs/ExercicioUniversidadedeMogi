using System;

namespace AtividadeParaNotaRafaelVieira
{
    class Programa
    {
        
        static void Main(string[]args)
        {
            double Cont1, Cont2, Cont3, Idade, altura,Peso, Soma, Media;

            Cont1 = 0;
            Cont2 = 0;
            Cont3 = 0;
            Soma = 0;
            // Estrutura para faça Com 25 repetições 
            for (int i = 1; i <=25; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite a idade ");
                Idade =double.Parse(Console.ReadLine());

                // Processo de validação

                while(Idade<=0)
                {
                    Console.WriteLine("Digite a idade ");
                    Idade = double.Parse(Console.ReadLine());

                }
                Console.WriteLine("Digite a Altura ");
                altura = double.Parse(Console.ReadLine())
                    ;
                // Processo de validação

                while (altura <=0)
                {
                    Console.WriteLine("Digite a Altura ");
                    altura = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Digite o Peso ");
                Peso = double.Parse(Console.ReadLine());

                // Processo de validação

                while (Peso<=0)
                {
                    Console.WriteLine("Digite o Peso ");
                    Peso = double.Parse(Console.ReadLine());
                }
                if (Idade > 50)
                {
                    Cont1 = Cont1 + 1;
                }
                else
                {
                    if(Idade > 10 && Idade <20)
                    {
                        Cont2 = Cont2 + 1;
                        Soma = Soma + altura;

                    }
                }
                if (Peso< 40)
                {
                    Cont3 = Cont3 + 1;
                }
            }
            if(Cont2 <= 0)
            {
                Console.WriteLine("Não há pessoas com idades entre 10 e 20 anos");
            }
            else
            {
                 Media = Soma / Cont2;
                Console.WriteLine($"Media das alturas das pessoas Com idade entre 10 e 20 anos é: {Media}");
            }
            double per = Cont3 / 25;
            Console.WriteLine($"Quantidade de pessoas com idade superior a 50 anos: {Cont1} e o percentual  de pesssoas com peso inferior a 40 quilos: {per}%");
            Console.ReadKey();
        }
    }
}