using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    /*classe che rappresenta le carte che determinano uno spostamento
     del giocatore. È una sottoclasse di Carta */
    public class CartaMovimento : Carta
    {
        //costruttore
        public CartaMovimento(string ruolo, Casella casella, Gioco gioco, string descrizione)
        {
            //inizializzazione degli attributi ereditati
            this.ruolo = ruolo;
            this.casella = casella;
            this.gioco = gioco;
            this.descrizione = descrizione;
        }

        //metodo che implementa il comportamento della carta
        public override void Usa()
        {
            /*se la carta agisce su tutti i ruoli o se il ruolo del giocatore
             coincide con quello richiesto dalla carta, allora il giocatore
             viene spostato sulla casella indicata e viene aggiornata la
             sua posizione*/
            if (ruolo == null || gioco.GiocatoreCorrente.Ruolo.Equals(ruolo))
            {
                this.casella.Transita();
                gioco.GiocatoreCorrente.Posizione = this.casella;                
            }
        }
    }
}
