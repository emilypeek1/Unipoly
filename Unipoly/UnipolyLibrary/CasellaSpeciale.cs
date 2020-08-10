using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    //sottoclasse di Casella con conseguenze di transito particolari
    public class CasellaSpeciale : Casella
    {
        //costruttore
        public CasellaSpeciale(string nome, string istruzioni, Gioco gioco, Carta carta)
        {
            //inizializzazione degli attributi ereditati
            this.nome = nome;
            this.carta = carta;
            this.istruzioni = this.carta.Descrizione;
            this.gioco = gioco;            
        }

        //metodo che implementa il transito sulla casella
        public override void Transita()
        {
            //vengono eseguite le istruzioni della carta associata
            this.carta.Usa();           
        }

        //metodo che ridefinisce la descrizione della classe
        public override string ToString()
        {
            return this.istruzioni;
        }
    }
}
