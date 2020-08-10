using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using LibreriaUnipoly;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.testaPartita();
            Console.ReadKey();
        }

        class Test
        {
            Gioco g;
            Configurazione config;
            Casella intermedia;
            Casella finale;

            public Test()
            {
                g = Gioco.OttieniGioco();
                config = new Configurazione(g);
                config.CaricaTabellone();
                g.AggiungiGiocatore("Paola", "pendolare");
                g.AggiungiGiocatore("Giorgia", "pendolare");
                g.IniziaPartita();
            }
            public void testaPartita()
            {
                Console.Write("TESTING\r\n\r\n" + "Via: ");

                for(int i = 0; i < 40; i++)
                {
                    g.GiocatoreCorrente.Posizione = g.OttieniCasella(0);
                    intermedia = g.OttieniCasella(i);
                    g.GiocatoreCorrente.Spostati(i);             
                    finale = g.GiocatoreCorrente.Posizione;                   

                    if (intermedia is CasellaEsame ||
                        intermedia is CasellaFuoriCorso ||
                        intermedia is CasellaTerzaRata)
                        Console.WriteLine(i + ": " + intermedia.Nome + "\r\n" + intermedia + "\r\n");
                    else if (intermedia is CasellaSpeciale)
                    {
                        Console.WriteLine(i + ": Casella Speciale. " + intermedia + "\r\n");
                        if(intermedia.Carta is CartaMovimento)
                            Console.WriteLine("Passiamo da questa casella a " + 
                                                finale + "\r\n");
                    }
                    else if (intermedia is CasellaCarta)
                    {
                        Console.WriteLine(i + ": Casella Carta. " + intermedia + 
                             "\r\nDescrizione carta: " + intermedia.Carta.Descrizione + "\r\n");
                        if (intermedia.Carta is CartaMovimento)
                            Console.WriteLine("Passiamo da questa casella a " +
                                                finale + "\r\n");
                    }
                    Console.WriteLine("Dati giocatore corrente: \r\nRuolo: " + g.GiocatoreCorrente.Ruolo +
                                "\r\nCfu: " + g.GiocatoreCorrente.Cfu + "\r\nSoldi: " + g.GiocatoreCorrente.Soldi 
                                + "\r\nTurni da saltare: " + g.GiocatoreCorrente.TurniDaSaltare + "\r\n");
                    Console.WriteLine("******************ALTRO TEST*********************");
                }
            }
        }
    }
}
