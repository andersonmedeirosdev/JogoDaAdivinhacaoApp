namespace JogoDaAdivinhacaoApp
{
    internal class Program
    {

        static int dificuldade;
        static int chances;
        static int numeroChutado;
        static int numAleatorio;
        static double pontuacaoTotal = 1000, calculoPontuacao;

        static void Main(string[] args)
        {

            GerarMenu();

            GerarNumeroAleatorio();

            GerarDificuldade();


            for (int i = 1; i <= chances; i++)
            {
                ReceberPalpite();
                //Console.WriteLine("Qual é o seu chute?");
                //numeroChutado = Convert.ToInt32(Console.ReadLine());

                if (numeroChutado != numAleatorio)
                {
                    if (numeroChutado < numAleatorio)
                    { 
                        Console.WriteLine("O número secreto é maior.");
                    }
                    else
                    {
                        Console.WriteLine("O número secreto é menor");
                    }
                } else
                {
                    Console.WriteLine("Parabéns, você acertou.");
                    break;
                }

                GerarCalculoPontuacao();
                Console.WriteLine("Tentativa número " + i);
                Console.WriteLine();
            }

            static void GerarMenu()
            {
                Console.WriteLine("Bem vindo ao Jogo da Adivinhação!!!");
                Console.WriteLine();

                Console.WriteLine("Escolha o nível de dificuldade:");
                Console.WriteLine();

                Console.WriteLine("[1] Fácil [2] Médio [3] Difícil");
                dificuldade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            static void GerarDificuldade()
            {
                switch (dificuldade)
                {
                    case 1:
                        chances = 15;
                        break;

                    case 2:
                        chances = 10;
                        break;
                    case 3:
                        chances = 5;
                        break;
                    default:
                        Console.WriteLine("Digite um número entre 1 e 3.");
                        return;
                }
            }

            static void GerarNumeroAleatorio()
            {
                Random aleatorio = new Random();

                numAleatorio = aleatorio.Next(1, 21);
            }

            static void GerarCalculoPontuacao()
            {
                calculoPontuacao = Math.Abs((numeroChutado - numAleatorio) / 2);
                double pontuacaoAtual = pontuacaoTotal - calculoPontuacao;
                Console.WriteLine(pontuacaoAtual);
            }

            static void ReceberPalpite()
            {
                Console.WriteLine("Qual é o seu chute?");
                numeroChutado = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}