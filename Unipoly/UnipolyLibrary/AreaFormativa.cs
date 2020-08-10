using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    //classe che raggruppa diversi esami per tipologia
    public class AreaFormativa
    {
        //attributi
        private readonly string nome;       //nome dell'area formativa
        private List<CasellaEsame> esami;   //lista di esami appartenenti all'area

        //costruttore
        public AreaFormativa(string nome)
        {
            //inizializzazione degli attributi
            this.nome = nome;
            this.esami = new List<CasellaEsame>();
        }

        //proprietà read-only per accedere al nome
        public string Nome {  get { return this.nome; } }

        //metodo per aggiungere esami all'area formativa
        public void AggiungiEsame(CasellaEsame esame)
        {
            this.esami.Add(esame);
        }

        /*metodo che restituisce true se il giocatore in input
        possiede tutti gli esami dell'area formativa*/
        public bool AcquisitaDa(Giocatore giocatore)
        {
            bool acquisita = false;
            int esamiAcquisiti = 0;

            //ciclo per contare il numero di esami dell'area posseduti
            foreach (CasellaEsame c in esami)
            {
                if (c.Proprietario == giocatore)
                    esamiAcquisiti++;
            }

            /*se il numero di esami posseduti coincide col numero di
            esami in lista, viene restituito true */
            if (esamiAcquisiti == esami.Count)
                acquisita = true;

            return acquisita;
        } //end metodo
    } //end classe
}
