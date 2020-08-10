using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    //classe astratta da cui erediteranno tutte le carte
    public abstract class Carta
    {
        //attributi

        /*alcune carte hanno effetto solo su giocatori con un 
        determinato ruolo*/
        protected string ruolo;
        /*alcune carte comportano una variazione o di cfu o di soldi 
         o di turni da saltare*/      
        protected double valore;
        /*alcune carte comportano uno spostamento del giocatore fino
         ad una determinata casella*/
        protected Casella casella;
        
        protected string descrizione;   //descrizione della carta
        protected Gioco gioco;          //gioco a cui si riferisce

        //proprietà read-only per accedere a tutti gli attributi
        public string Ruolo { get { return this.ruolo; } }
        public double Valore { get { return this.valore; } }
        public Casella Casella { get { return this.casella; } }
        public string Descrizione{ get { return this.descrizione; } }

        //metodo astratto che attua le istruzioni della carta
        abstract public void Usa();
    }
}
