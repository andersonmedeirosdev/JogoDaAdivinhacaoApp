namespace JogoDaAdivinhacaoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Jogo da Adivinhação!!!");
            Console.WriteLine();

            Console.WriteLine("Escolha o nível de dificuldade:");
            Console.WriteLine();

            Console.WriteLine("[1] Fácil [2] Médio [3] Difícil");
            int dificuldade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int numeroChutado;

            Random aleatorio = new Random();

            int numAleatorio = aleatorio.Next(1, 20);

            int chances;

            int pontuacaoTotal = 1000;

            int calculoPontuacao;

            switch (dificuldade) {
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

            for (int i = 0; i <= chances; i++)
            {
                Console.WriteLine("Qual é o seu chute?");
                numeroChutado = Convert.ToInt32(Console.ReadLine());

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
                calculoPontuacao = Math.Abs(numeroChutado - numAleatorio) / 2;
                int pontuacaoAtual = pontuacaoTotal - calculoPontuacao;
                Console.WriteLine(pontuacaoAtual);
                Console.WriteLine("Tentativa número " + i);
                Console.WriteLine();
            }

        }
    }
}