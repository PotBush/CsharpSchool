using static Morra_Cinese.Partita;

namespace Morra_Cinese
{
    internal class Program
    {
        static void Main()
        {
            // Console.WriteLine("0 per sasso 1 per carta 2 per forbice");
            // Partita partita = new Partita();
            // do
            // {
            //     partita.Round(Convert.ToInt32(Console.ReadLine()));
            // } while (partita.Player.Vincite!=3&&partita.Bot.Vincite!=3);
            // if (partita.Player.Vincite==3)
            // {
            //     Console.WriteLine("hai vinto tu");
            // }
            // else
            // {
            //     Console.WriteLine("ha vinto il bot che scarso");
            // }

            try {
            Console.WriteLine("inserisci le partite che vuoi fare");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N <= 0) throw new ArgumentException("il numer di partite non è acetabile");
            Partita[] partita1 = new Partita[N];
                for (int i = 0; i < partita1.Length; i++)
                {


                    partita1[i] = new Partita();
                    do
                    {
                        Console.WriteLine("0 per sasso 1 per carta 2 per forbice");
                        int sceltaUtente = int.Parse(Console.ReadLine());
                        Casiround esito = partita1[i].Round(sceltaUtente);

                        Console.WriteLine($"Bot: {partita1[i].Bot.Scelta}");

                        Console.WriteLine($"{esito}!");

                        Console.WriteLine($"\n┌─RoundPoint:──────────────┐  \n" +
                                            $"│Player:{partita1[i].Player.Vincite}                  │ \n" +
                                            $"│Pc:{partita1[i].Bot.Vincite}                      │ \n" +
                                             "└──────────────────────────┘ \n");
                    } while (partita1[i].Player.Vincite < 3 && partita1[i].Bot.Vincite < 3);

                    if (partita1[i].Player.Vincite == 3)
                    {
                        Console.WriteLine("hai vinto tu");
                    }
                    else
                    {
                        Console.WriteLine("ha vinto il bot che scarso");
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}