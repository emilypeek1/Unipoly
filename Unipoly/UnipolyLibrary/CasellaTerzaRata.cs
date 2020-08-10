using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    /*classe che rappresenta una sottoclasse di Casella*/
    public class CasellaTerzaRata : Casella
    {
        //costruttore
        public CasellaTerzaRata(string nome, string istruzioni, Gioco gioco)
        {
            //inizializzazione degli attributi ereditati
            this.nome = nome;
            this.istruzioni = istruzioni;
            this.gioco = gioco;
        }

        //metodo che implementa il transito sulla casella
        public override void Transita()
        {
            //la terza rata si paga in base al proprio capitale
            gioco.GiocatoreCorrente.Soldi -=
                (100 + this.gioco.GiocatoreCorrente.Soldi / 3);
        }

        //metodo che ridefinisce la descrizione della classe
        public override string ToString()
        {
            return this.istruzioni;
        }
    }
}
