using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    //classe che rappresenta i giocatori
    public class Giocatore
    {
        //attributi
        private readonly string nome;       //nome 
        private readonly string ruolo;      /*ruolo del giocatore: 
                                             può essere in sede, fuori sede, 
                                             straniero, pendolare*/    
        private double soldi;               //capitale 
        private int cfu;                    //cfu acquisiti
        private int turniDaSaltare;         //numero di turni da saltare
        private Casella posizione;          //posizione corrente
        private Gioco gioco;                //gioco a cui si riferisce
        private bool dadoLanciato;          /*booleano che indica se il
                                             Giocatore ha già lanciato il dado*/
        public const double CAPITALE_INIZIALE = 2000;  //capitale di partenza

        //costruttore
        public Giocatore(string nome, string ruolo, Gioco gioco)
        {
            //inizializzazione degli attributi
            this.nome = nome;
            this.ruolo = ruolo;
            this.soldi = CAPITALE_INIZIALE;
            this.cfu = 0;
            this.turniDaSaltare = 0;
            this.gioco = gioco;
            this.dadoLanciato = false;
        }//end costruttore

        //proprietà read-only per accedere agli attributi
        public string Nome { get { return this.nome; } }
        public string Ruolo { get { return this.ruolo; } }

        //proprietà per leggere e aggiornare gli altri attributi

        public bool DadoLanciato
        {
            get { return this.dadoLanciato; }
            set { this.dadoLanciato = value; }
        }
        public double Soldi
        {
            get { return this.soldi; }
            set
            {
                this.soldi = value;
                //se è in rosso, gli si dimezzano i cfu
                if (this.soldi < 0)
                    this.cfu = this.cfu / 2;
            }
        }
        public int Cfu
        {
            get { return this.cfu; }
            set
            {
                //il numero di cfu non può essere negativo
                this.cfu = value;
                if (this.cfu < 0)
                    this.cfu = 0;
            }
        }
        public int TurniDaSaltare
        {
            get { return this.turniDaSaltare; }
            set
            {
                //il numero di turni non può essere negativo
                this.turniDaSaltare = value;
                if (this.turniDaSaltare < 0)
                    this.turniDaSaltare = 0;
            }
        }
        public Casella Posizione
        {
            get { return this.posizione; }
            set { this.posizione = value; }
        }

        //metodo per spostare il giocatore di *numero* caselle
        public void Spostati(int numero)
        {
            /*si calcola l'indice della posizione corrente, si aggiunge *numero* e
              si calcola la nuova posizione*/
            this.posizione = gioco.OttieniCasella(gioco.OttieniIndice(posizione) + numero);
            //si transita sulla casella
            this.posizione.Transita();
        }

        //metodo per spostare il giocatore alla casella in input
        public void Spostati(Casella casella)
        {
            //si aggiorna la posizione
            this.posizione = casella;
            //si transita sulla casella
            this.posizione.Transita();
        }
    }//end classe
}
