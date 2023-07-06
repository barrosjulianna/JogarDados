using JogarDados.entities;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com o nome do primeiro jogador: ");
                string jogador1 = Console.ReadLine();
                Console.WriteLine("Entre com o nome do primeiro jogador: ");
                string jogador2 = Console.ReadLine();
                
                Console.WriteLine("Entre com o número de rodadas: ");
                int rodadas = int.Parse(Console.ReadLine());

                Jogo jogo = new Jogo(jogador1, jogador2, rodadas);

                jogo.rodarJogo();
 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}