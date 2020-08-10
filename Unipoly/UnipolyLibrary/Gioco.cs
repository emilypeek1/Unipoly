using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    //classe che rappresenta il gioco corrente
    public class Gioco
    {
        /*poiché viene usato il pattern Singleton, serve 
         un attributo statico che rappresenta l'unica istanza*/
        private static Gioco istanza = null;

        public const int MIN_GIOCATORI = 2;     //numero minimo di giocatori
        public const int MAX_GIOCATORI = 4;     //numero massimo di giocatori
        public readonly TimeSpan tempoPartita;  //durata massima della partita
        private List<Casella> tabellone;        //lista di tutte le caselle        
        private List<Carta> carteI;             //mazzo di carte Imprevisto
        private List<Carta> carteP;             //mazzo di carte Probabilità
        private List<Giocatore> giocatori;      //lista di giocatori
        private Dado dado;                      //dado
        private int turno;                      //turno corrente
        private Giocatore giocatoreCorrente;    //giocatore corrente
        private string infoGioco;               //informazioni di gioco
        private DateTime inizioPartita;         //data di inizio partita

        //costruttore protetto per implementare Singleton
        protected Gioco()
        {
            //inizializzazione degli attributi
            this.tempoPartita = new TimeSpan(2, 0, 0);  //2 ore
            this.giocatori = new List<Giocatore>();
            this.dado = new LibreriaUnipoly.Dado(1,6);  //dado a 6 facce     
            this.infoGioco = null;
            this.tabellone = new List<Casella>();
            this.carteI = new List<Carta>();
            this.carteP = new List<Carta>();
        }

        //metodo statico da invocare per creare il gioco
        public static Gioco OttieniGioco()
        {
            if (istanza == null)
                istanza = new Gioco();
            return istanza;
        }

        //proprietà per accedere a tutte le proprietà e impostare le info di gioco
        public string InfoGioco { get { return this.infoGioco; } set { this.infoGioco = value; } }
        public Giocatore GiocatoreCorrente { get { return this.giocatoreCorrente; } }
        public int NumCarteP { get { return this.carteP.Count; } }
        public int NumCarteI { get { return this.carteP.Count; } }
        public List<Giocatore> Giocatori { get { return this.giocatori; } }
        public int Turno { get { return this.turno; } }

        //metodo per iniziare una nuova partita. 
        //Restituisce true se l'avvio è andato a buon fine
        public bool IniziaPartita()
        {
            bool esito = false;
            //controlla se il numero di giocatori rientra nel range
            if (this.giocatori.Count >= MIN_GIOCATORI && this.giocatori.Count <= MAX_GIOCATORI)
            {
                //inizializza parametri di gioco
                this.inizioPartita = new DateTime();
                this.inizioPartita = DateTime.Now;
                this.turno = 0;
                this.giocatoreCorrente = giocatori.ElementAt(0);
                
                //posiziona i giocatori sul Via
                foreach(Giocatore g in giocatori)
                    g.Posizione = OttieniCasella(0);

                esito = true;
            }
            return esito;
        }//end IniziaPartita()

        //metodo per passare il turno al prossimo giocatore
        //Restituisce true se la partita è ancora in corso
        public bool CambiaTurno()
        {
            bool esito = true;

            //se la partita è terminata, non si può passare il turno
            if (ControllaPartita() == false)
                esito = false;
            //altrimenti, se il giocatore ha lanciato il dado
            else if (giocatoreCorrente.DadoLanciato == true)
            {
                //si attua il passaggio
                this.giocatoreCorrente.DadoLanciato = false;
                //si incrementa il turno
                int i = ++turno;

                /*si aggiorna giocatore corrente cercando il primo non in stallo
                  e aggiornando il numero di turni da saltare di quelli in stallo*/
                bool trovato = false;
                while (trovato == false)
                {
                    //se tutti hanno giocato, si ritorna al primo
                    if (i % this.giocatori.Count == 0)
                        i = 0;

                    if (this.giocatori.ElementAt(i).TurniDaSaltare == 0)
                    {
                        trovato = true;
                        this.giocatoreCorrente = this.giocatori.ElementAt(i);
                        turno = i;
                    }
                    else
                    {
                        infoGioco += this.giocatori.ElementAt(i).Nome +
                                        " salta il turno.\r\n";
                        this.giocatori.ElementAt(i).TurniDaSaltare--;
                        i++;
                    }
                }//end while             
            }//end else if
            //rimane il caso in cui il giocatore non abbia lanciato il dado
            else
            {
                //lanciamo un'eccezione
                infoGioco += "Lancia il dado prima\r\n";
                throw new Exception();
            }

            return esito;
        }//end metodo CambiaTurno()

        //metodo che restituisce true se la partita è ancora in corso 
        private bool ControllaPartita()
        {
            bool esito = true;             
            //controlla lo stato della partita 
            foreach (Giocatore g in giocatori)
            {
                if (esito == true)
                {
                    //se c'è almeno un laureato, allora la partita è finita
                    if (g.Cfu >= 180)
                    {
                        infoGioco += "Il giocatore " + g.Nome + " si è laureato!\r\n";
                        DecretaClassifica();
                        esito = false;
                    }
                    //se sono trascorse almeno 2 ore, allora la partita è finita
                    else if ((DateTime.Now - this.inizioPartita) >= tempoPartita)
                    {
                        infoGioco += "Tempo scaduto!\r\n";
                        DecretaClassifica();
                        esito = false;
                    }
                }
            }
            return esito;
        }//end metodo ControllaPartita()

        /*metodo per aggiungere giocatori alla partita
         restituisce il giocatore creato o null se la creazione
         non è andata a buon fine*/
        public Giocatore AggiungiGiocatore(string nome, string ruolo)
        {
            Giocatore nuovoGiocatore = null;
            //controlla se giocatore può essere aggiunto 
            if(this.giocatori.Count < MAX_GIOCATORI)
            {
                nuovoGiocatore = new Giocatore(nome, ruolo, this);
                this.giocatori.Add(nuovoGiocatore);
            }
            return nuovoGiocatore;
        }//end metodo AggiungiGiocatore()

        //metodo che restituisce la casella all'indice in input
        public Casella OttieniCasella(int indice)
        {
            return this.tabellone.ElementAt(indice % this.tabellone.Count);         
        }

        //metodo che restituisce l'indice della casella in input
        public int OttieniIndice(Casella casella)
        {
            return this.tabellone.IndexOf(casella);
        }

        //metodo per lanciare il dado e spostare il giocatore.
        //Restituisce l'esito del dado se ha avuto successo, zero altrimenti
        public int LanciaDadoSpostaGiocatore()
        {
            int diffIndice = 0;     //esito del lancio
            /*se il dado non è già stato lanciato, il giocatore
             viene spostato di *diffIndice* caselle*/
            if (this.giocatoreCorrente.DadoLanciato == false)
            {
                diffIndice = this.dado.LanciaDado();
                this.giocatoreCorrente.Spostati(diffIndice);
                this.giocatoreCorrente.DadoLanciato = true;
            }
            else
            {
                infoGioco += "Non puoi rilanciare il dado.\r\n";
                throw new Exception();
            }
            return diffIndice;
        }//end metodo LanciaDadoSpostaGiocatore()

        // metodi per aggiungere carte, caselle, e leggere carte
        public void AggiungiCartaP(Carta carta) { this.carteP.Add(carta); }
        public void AggiungiCartaI(Carta carta) { this.carteI.Add(carta); }
        public void AggiungiCasella(Casella casella) { this.tabellone.Add(casella); }
        public Carta LeggiCartaP(int indice) { return this.carteP.ElementAt(indice); }
        public Carta LeggiCartaI(int indice) { return this.carteI.ElementAt(indice); }

        // metodo per stilare la classifica finale
        public List<Giocatore> DecretaClassifica()
        {
            List<Giocatore> classifica = new List<Giocatore>();
            //tutti i giocatori vengono aggiunti in classifica
            foreach (Giocatore g in giocatori)
                classifica.Add(g);
            //la classifica viene ordinata prima secondo i cfu, poi secondo i soldi
            classifica = classifica.OrderByDescending(Giocatore => 
                    Giocatore.Cfu).ThenByDescending(Giocatore => Giocatore.Soldi).ToList();
            infoGioco += "Classifica:" + "\r\n";
            int i = 1;
            foreach (Giocatore giocatore in classifica)
            {
                infoGioco += i + ") " + giocatore.Nome + "\r\n";
                i++;
            }
            return classifica;
        }//end metodo DecretaClassifica()
    }//end classe
}
