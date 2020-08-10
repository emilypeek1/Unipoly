using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    /*classe che rappresenta una casella di tipo esame. È una sottoclasse di Casella*/
    public class CasellaEsame : Casella
    {
        //attributi

        private readonly int pesoCfu;               //cfu dell'esame
        private readonly double prezzoLibro;        //prezzo del libro richiesto
        private const double PREZZO_APPUNTI = 20;   //prezzo degli appunti associati
        private int appunti;                        //numero di appunti associati
        private Giocatore proprietario;             //proprietario del libro

        //costruttore
        public CasellaEsame(string nome, string istruzioni, int pesoCfu, 
                            Gioco gioco, AreaFormativa areaFormativa)
        {
            //inizializzazione degli attributi ereditati
            this.nome = nome;
            this.istruzioni = istruzioni;
            this.gioco = gioco;
            this.areaFormativa = areaFormativa; 

            //inizializzazione degli attributi aggiunti          
            this.pesoCfu = pesoCfu;
            this.prezzoLibro = this.pesoCfu * 10;   //il prezzo del libro dipende dall'esame
            this.appunti = 0;            
            this.proprietario = null;
        }//end costruttore

        //proprietà per leggere e aggiornare il proprietario della casella
        public Giocatore Proprietario
        {
            get { return this.proprietario; }
            set { this.proprietario = value; }
        }

        //proprietà read-only per accedere agli altri attributi
        public double PrezzoLibro { get { return this.prezzoLibro; } }
        public int PesoCfu { get { return this.pesoCfu; } }
        public int Appunti { get { return this.appunti; } }

        /*metodo per comprare il libro richiesto e diventare proprietari
         della casella. Restituisce true se l'acquisto ha avuto successo*/
        public override bool Compra()
        {
            bool comprato = false;      //esito dell'acquisto

            //se il giocatore ha abbastanza soldi e la casella non è di nessuno
            if (gioco.GiocatoreCorrente.Soldi >= prezzoLibro && proprietario == null)
            {
                //pagamento e aggiornamento delle informazioni
                gioco.GiocatoreCorrente.Soldi -= prezzoLibro;
                this.proprietario = gioco.GiocatoreCorrente;
                this.proprietario.Cfu += this.pesoCfu;
                comprato = true;
                gioco.InfoGioco += "Libro comprato!\r\n";
            }
            else if (this.proprietario != null)
            {
                //se la casella ha già un altro proprietario
                if (this.proprietario != gioco.GiocatoreCorrente)
                    gioco.InfoGioco += "Non puoi comprare il libro perché"
                                    + " è posseduto già da " + proprietario.Nome + "\r\n";
                //se il proprietario della casella è il giocatore stesso
                else
                    gioco.InfoGioco += "Possiedi già quest'esame.\r\n";
            }
            //rimane il caso in cui il giocatore non abbia abbastanza soldi
            else
                gioco.InfoGioco += "Non hai abbastanza soldi, vendi un rene.\r\n";

            return comprato;
        } //end metodo Compra()

        //metodo che implementa il transito sulla casella
        public override void Transita()
        {
            //aggiornamento delle informazioni di gioco
            if (proprietario != null)
                gioco.InfoGioco += "Casella posseduta da " + proprietario.Nome + ".\r\n";
            /*se la casella è proprietà di un altro giocatore */
            if (this.proprietario != null && gioco.GiocatoreCorrente != this.proprietario )
            {
                //il giocatore paga al proprietario sia il libro sia gli appunti
                gioco.GiocatoreCorrente.Soldi -= this.prezzoLibro + this.appunti * PREZZO_APPUNTI;
                this.proprietario.Soldi += this.prezzoLibro + this.appunti * PREZZO_APPUNTI;
                gioco.InfoGioco += "Devi pagare " + (this.prezzoLibro +
                                    this.appunti * PREZZO_APPUNTI) + ".\r\n";                
            }
            //se il giocatore possiede quella casella
            else if (gioco.GiocatoreCorrente == this.proprietario)
                gioco.InfoGioco += "Possiedi quest'esame nel libretto.\r\n";
            //resta il caso in cui la casella non abbia proprietario
            else
                gioco.InfoGioco += "Puoi comprare il libro a " 
                                    + this.prezzoLibro + " euro, se vuoi.\r\n";                
        }//end metodo Transita()

        //metodo che implementa l'acquisto dei potenziamenti: in questo caso, gli appunti
        public override bool Potenzia()
        {
            bool aggiunti = false;      //esito del potenziamento

            //si controlla se il giocatore è proprietario di tutte le caselle di quell'area 
            bool esito = areaFormativa.AcquisitaDa(gioco.GiocatoreCorrente);

            //se lo è, e ha abbastanza soldi per comprare gli appunti, vengono aggiunti
            if (esito == true && gioco.GiocatoreCorrente.Soldi >= PREZZO_APPUNTI)
            {
                gioco.GiocatoreCorrente.Soldi -= PREZZO_APPUNTI;
                this.appunti++;
                aggiunti = true;
                gioco.InfoGioco += "Appunti aggiunti!\r\n";
            }
            //se non ha tutti gli esami dell'area formativa
            else if (aggiunti == false)
                gioco.InfoGioco += "Non puoi aggiungere appunti perché " +
                                    "non possiedi tutti gli esami dell'area formativa\r\n";
            //rimane il caso in cui non abbia abbastanza soldi
            else
                gioco.InfoGioco += "Non hai abbastanza soldi, vendi un rene.\r\n";

            return aggiunti;
        }//end metodo Potenzia()

        //metodo che ridefinisce la descrizione della classe
        public override string ToString()
        {
            string descrizione;
            descrizione = "Tipo: " + this.istruzioni + "\r\n" +
                          "Area formativa: " + this.areaFormativa.Nome + "\r\n" +
                          "CFU: " + this.pesoCfu + "\r\n" +
                          "Proprietario: ";
            if (proprietario == null)
                descrizione += "nessuno" + "\r\n";
            else
                descrizione += this.proprietario.Nome + "\r\n";

            descrizione += "Prezzo libro: " + this.prezzoLibro + "\r\n" +
                           "Prezzo appunti: " + PREZZO_APPUNTI + "\r\n" +
                           "Numero appunti associati: " + this.appunti + "\r\n";

            return descrizione;
        } //end metodo ToString()
    }//end classe
}
