using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    //classe che rappresenta il dado da lanciare
    public class Dado
    {
        //attributi 
        private readonly int max;   //numero massimo che può uscire
        private readonly int min;   //numero minimo che può uscire
        private Random rnd;         //numero random

        public Dado(int min, int max)
        {
            //inizializzazione degli attributi
            this.max = max;
            this.min = min;
            this.rnd = new Random();
        }

        //metodo che implementa il lancio del dado e restituisce l'esito
        public int LanciaDado()
        {
            return this.rnd.Next(min, max + 1);
        }

        //proprietà read-only per accedere ai valori del dado
        public int Max { get { return this.max; } }
        public int Min { get { return this.min; } }
    }
}
