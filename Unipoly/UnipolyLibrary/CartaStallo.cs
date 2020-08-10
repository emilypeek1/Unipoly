using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    /*classe che rappresenta le carte che fanno saltare dei turni al
      giocatore. È una sottoclasse di Carta */
    public class CartaStallo : Carta
    {
        //costruttore
        public CartaStallo(string ruolo, double valore, Gioco gioco, string descrizione)
        {
            //inizializzazione degli attributi ereditati
            this.ruolo = ruolo;
            this.valore = valore;
            this.gioco = gioco;
            this.descrizione = descrizione;
        }

        //metodo che implementa il comportamento della carta
        public override void Usa()
        {
            /*se la carta agisce su tutti i ruoli o se il ruolo del giocatore
             coincide con quello richiesto dalla carta, allora si imposta
             il numero di turni da saltare*/
            if (ruolo == null || gioco.GiocatoreCorrente.Ruolo.Equals(ruolo))
            {
                gioco.GiocatoreCorrente.TurniDaSaltare = (int)this.valore;
            }
        }
    }
}
