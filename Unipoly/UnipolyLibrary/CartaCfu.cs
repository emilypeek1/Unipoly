using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    /*classe che rappresenta le carte che variano il numero di cfu
    dei giocatori che le pescano. È una sottoclasse di Carta */
    public class CartaCfu : Carta
    {
        //costruttore
        public CartaCfu(string ruolo, double valore, Gioco gioco, string descrizione)
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
             coincide con quello richiesto dalla carta, allora si incrementa
             (o si decrementa, nel caso in cui il valore sia negativo) il
             numero di cfu del giocatore*/
            if (ruolo == null || gioco.GiocatoreCorrente.Ruolo.Equals(ruolo))
                gioco.GiocatoreCorrente.Cfu += (int)this.valore;
        }
    }
}
