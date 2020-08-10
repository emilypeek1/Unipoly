using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    //sottoclasse di Casella che rappresenta le caselle Imprevisti e Probabilità
    public class CasellaCarta : Casella
    {
        //costruttore
        public CasellaCarta(string nome, string istruzioni, Gioco gioco)
        {
            //inizializzazione degli attributi ereditati
            this.nome = nome;
            this.istruzioni = istruzioni;
            this.gioco = gioco;
        }

        //metodo che implementa il transito sulla casella
        public override void Transita()
        {
            //si pesca una carta 
            Carta c;
            
            //si pesca dal mazzo degli imprevisti
            if (this.nome.Equals("Imprevisto"))
            {
                Dado mioDado = new Dado(0, this.gioco.NumCarteI - 1);
                int esito = mioDado.LanciaDado();
                c = this.gioco.LeggiCartaI(esito);
                base.carta = c;
                base.tipoCarta = "Imprevisto";
            }
            //si pesca dal mazzo delle probabilità
            else
            {
                Dado mioDado = new Dado(0, this.gioco.NumCarteP - 1);
                int esito = mioDado.LanciaDado();
                c = this.gioco.LeggiCartaP(esito);
                base.carta = c;
                base.tipoCarta = "Probabilità";
            }
            //si eseguono le istruzioni riportate
            c.Usa();
        }//end classe Transita()

        //metodo che ridefinisce la descrizione della classe
        public override string ToString()
        {
            return this.istruzioni;
        }
    }//end classe
}
