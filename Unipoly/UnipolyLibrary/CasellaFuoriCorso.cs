using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    /*classe che rappresenta una sottoclasse di Casella*/
    public class CasellaFuoriCorso : Casella
    {
        //costruttore
        public CasellaFuoriCorso(string nome, string istruzioni, Gioco gioco)
        {
            //inizializzazione degli attributi
            this.nome = nome;
            this.istruzioni = istruzioni;
            this.gioco = gioco;
        }

        //metodo che implementa il transito sulla casella
        public override void Transita()
        {
            //se si va fuori corso, il proprio capitale viene ridotto del 10%
            gioco.GiocatoreCorrente.Soldi -= 
                ((10 * gioco.GiocatoreCorrente.Soldi) / 100);
        }

        //metodo che ridefinisce la descrizione della classe
        public override string ToString()
        {
            return this.istruzioni;
        }
    }
}
