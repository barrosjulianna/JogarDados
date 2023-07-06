using System;

namespace JogarDados.entities
{
    class Jogo
    {
        public string Jogador1 { get; set; }
        public string Jogador2 { get; set; }
        public int NumeroRodadas { get; set; }

        public Jogo(string jogador1, string jogador2, int numeroRodadas)
        {
            if (jogador1 == jogador2)
            {
                throw new ArgumentException("Atenção, O Nome dos jogadores não podem ser iguais");
            }

            if (numeroRodadas < 1 || numeroRodadas > 5)
            {
                throw new ArgumentException("Atenção, o número minimo de rodadas é 1 e o máximo é 5");
            }

            Jogador1 = jogador1;
            Jogador2 = jogador2;
            NumeroRodadas = numeroRodadas;
        }
  
        public void rodarJogo()
        {

            int placarJogador1 = 0;
            int placarJogador2 = 0;

            Random rnd = new Random();

            for (int i = 1; i <= NumeroRodadas; i++)
            {
                int numeroSorteado1 = rnd.Next(1, 6);
                int numeroSorteado2 = rnd.Next(1, 6);

                Console.WriteLine();
                Console.WriteLine($"Rodada {i} : ");

                Console.Write($"{Jogador1} tirou o numero {numeroSorteado1} e {Jogador2} tirou o numero {numeroSorteado2}");
                
                if (numeroSorteado1 > numeroSorteado2)
                {
                    Console.Write($". {Jogador1} venceu a rodada {i}.");
                    placarJogador1 += 1;
                }
                else if (numeroSorteado1 < numeroSorteado2)
                {
                    Console.Write($". {Jogador2} venceu a rodada {i}.");
                    placarJogador2 += 1;
                }
                else
                {
                    Console.Write($" .Empate.");
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Placar atualizado: ");
                Placar(Jogador1, placarJogador1);
                Placar(Jogador2, placarJogador2);
       
                Console.WriteLine();
                if (NumeroRodadas == i)
                {
                    if (placarJogador1 > placarJogador2)
                    {
                        Console.WriteLine($"Jogador(a) {Jogador1} venceu o jogo!!!!");
                    }
                    else if (placarJogador1 < placarJogador2)
                    {
                        Console.WriteLine($"Jogador(a) {Jogador2} venceu o jogo!!!!");
                    }
                    else
                    {
                        NumeroRodadas += 1;
                        Console.WriteLine("Rodada desempate: ");
                    }
                }
            }
        }
        public void Placar(string jogador, int placar)
        {
            Console.WriteLine($"{jogador}: {placar} pontos.");
        }

    }
}
