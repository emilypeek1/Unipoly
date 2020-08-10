using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//si importa la libreria del gioco
using LibreriaUnipoly;

namespace UnipolyGUI
{
    //classe di tipo Form che mostra il tavolo da gioco
    public partial class TavoloGioco: Form
    {
        //attributi
        private Gioco gioco;                            //gioco a cui ci si riferisce
        private Configurazione config;                  //configurazione del gioco
        private Casella corrente;                       //casella corrente                     
        private Pedina pedina;                          //pedina corrente
        private TimeSpan tempo;                         //tempo rimanente
        private PictureBox[] immaginiPedine;            //immagini delle pedine
        private PictureBox[] segnaposti;                //segnaposti accanto ai giocatori
        private Color[] coloriPerGiocatore;             //colori delle pedine
        private Dictionary<string, Color> colorePerArea;//colori delle aree formative
        private Bitmap[] facceDado;                     //facce del dado
        private Label[] nomi;                           //nomi dei giocatori
        private TextBox[] dati;                         //dati dei giocatori
        private Button[] pulsanti;                      //pulsanti di gioco

        //costruttore
        public TavoloGioco()
        {
            //inizializzazione dei componenti
            InitializeComponent();
        }

        //gestore dell'evento di caricamento del form
        private void load(object sender, EventArgs e)
        {
            //creazione del gioco
            gioco = Gioco.OttieniGioco();
            config = new Configurazione(gioco);
            config.CaricaTabellone();
            //inizializzazione degli attributi
            tempo = gioco.tempoPartita;
            pedina = new Pedina(this, gioco);
            coloriPerGiocatore = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow };
            colorePerArea = new Dictionary<string, Color>()
            {
                {"Formazione matematico-fisica", Color.MediumOrchid },
                { "Formazione informatica di base", Color.SeaGreen },
                { "Discipline Informatiche", Color.Olive },
                { "Programmazione", Color.Red },
                { "Esami di curriculum", Color.DarkOrange },
                { "Esami a Scelta", Color.Brown },
                { "Tesi", Color.DimGray },
                { "Lingua Inglese", Color.Navy },
                { "Tirocini formativi", Color.ForestGreen }
            };
            nomi = new Label[] { nome1, nome2, nome3, nome4 };
            dati = new TextBox[] { dati1, dati2, dati3, dati4 };
            pulsanti = new Button[] { dado, libro, appunti, turno, avviaPartita, stop };
            facceDado = new Bitmap[6];
            immaginiPedine = new PictureBox[] { pedina1, pedina2, pedina3, pedina4 };
            segnaposti = new PictureBox[] { colore1, colore2, colore3, colore4 };

            //proviamo a caricare le immagini
            string[] nomeFile = new string[] { "dado1", "dado2", "dado3", "dado4","dado5", "dado6",
                            "palla1", "palla2", "palla3", "palla4", "unipoly_template" };            
            try
            {
                for (int i = 0; i < 6; i++)
                    this.facceDado[i] = (Bitmap)Properties.Resources.ResourceManager.GetObject(nomeFile[i]);
                for (int i = 0; i < 4; i++)
                {
                    this.immaginiPedine[i].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(nomeFile[i + 6]);
                    this.segnaposti[i].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(nomeFile[i + 6]);
                }
                this.tabellone.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(nomeFile[10]);
            }
            //se non ci riusciamo, il metodo GetObject lancia un'eccezione e quindi chiudiamo il form
            catch (Exception)
            {
                MessageBox.Show("Problema caricamento immagine");
                this.Close();
            }           
        }//end metodo load()

        //proprietà per accedere ai controlli sul tavolo da gioco
        public Button AvviaPartita { get { return this.avviaPartita; } }
        public Button Dado { get { return this.dado; } }
        public Button Stop { get { return this.stop; } }
        public Button Turno { get { return this.turno; } }
        public Button Libro { get { return this.libro; } }
        public Button Appunti { get { return this.appunti; } }
        public Button Regole { get { return this.regole; } }
        public Label TimerGioco { get { return this.timerGioco; } }
        public Label[] Nomi { get { return this.nomi; } }
        public PictureBox[] Segnaposti { get { return this.segnaposti; } }
        public PictureBox[] ImmaginiPedine { get { return this.immaginiPedine; } }
        public PictureBox CartaPescata { get { return this.cartaPescata; } }
        public TextBox[] Dati { get { return this.dati; } }       
        public TextBox NomeCarta { get { return this.nomeCarta; } }
        public TextBox DescrizioneCarta { get { return this.descrizioneCarta; } }

        //metodo per avviare il timer
        public void AvviaTimer() { this.veroTimer.Enabled = true; }

        //gestore dell'evento di click sul pulsante di lancio del dado
        private void dado_Click(object sender, EventArgs e)
        {
            //LanciaDadoSpostaGiocatore() lancia un'eccezione se il dado è
            //già stato lanciato           
            try
            {
                //salviamo la posizione attuale
                Casella precedente = gioco.GiocatoreCorrente.Posizione;
                int esito = gioco.LanciaDadoSpostaGiocatore();
            
                //disabilitiamo il pulsante
                dado.Enabled = false;
                //mostriamo l'esito del dado
                this.esitoDado.Visible = true;
                this.esitoDado.Image = facceDado[esito - 1];

                //calcoliamo la nuova casella
                int indiceAttuale = (gioco.OttieniIndice(precedente) + esito) % 40;
                this.corrente = gioco.OttieniCasella(indiceAttuale);

                //aggiorniamo le informazioni di gioco, scegliamo la pedina e la muoviamo 
                StampaInfoGioco();
                PictureBox immaginePedina = immaginiPedine[gioco.Turno];
                pedina.ImmaginePedina = immaginePedina;
                Muoviti(precedente, this.corrente);

                //se la casella corrente è imprevisto o probabilità, mostriamo la carta
                if (corrente is CasellaCarta)
                    MostraCarta(true);
                //se la casella corrente è una casella esame, diamo le possibilità di acquisto
                 if (this.corrente is CasellaEsame)
                {
                    libro.Enabled = true;
                    appunti.Enabled = true;
                }
                /*se dalla casella siamo arrivati ad un'altra casella, facciamo partire 
                 un timer che ci consenta di leggere la carta pescata prima che la 
                 pedina si muova verso la nuova casella*/
                if (this.corrente.Carta != null && this.corrente.Carta is CartaMovimento)
                {
                    timerMovimento.Enabled = true;
                    timerMovimento.Start();
                }
                //abilitiamo di nuovo il pulsante di terminazione del turno
                else
                    turno.Enabled = true;
            }//end try
            catch
            {
                MessageBox.Show("Hai già tirato il dado.");
            }
        }//end metodo dado_Click()

        //gestore dell'evento di click sul pulsante di terminazione del turno
        private void turno_Click(object sender, EventArgs e)
        {
            //CambiaTurno() lancia un'eccezione se non è ancora stato lanciato il dado
            try
            {
                //resettiamo il bordo del segnaposto 
                segnaposti[gioco.Turno].BorderStyle = BorderStyle.None;
                /*disabilitiamo i pulsanti di avvio partita, di acquisto di libri e appunti e di 
                 terminazione del turno, resettiamo l'immagine del dado e nascondiamo la carta*/
                for (int i = 0; i < 4; i++)
                    pulsanti[i].Enabled = false;
                esitoDado.Visible = false;
                MostraCarta(false);
                //aggiorniamo le informazioni sui giocatori
                for (int i = 0; i < gioco.Giocatori.Count; i++)
                    Dati[i].Text = DatiGiocatore(i);

                //passiamo il turno al prossimo giocatore
                bool partitaInCorso = gioco.CambiaTurno();

                //se il passaggio ha avuto successo
                if (partitaInCorso == true)
                {
                    //mettiamo in evidenza il segnaposto del giocatore corrente, 
                    //aggiorniamo le info e abilitiamo il pulsante di lancio del dado
                    segnaposti[gioco.Turno].BorderStyle = BorderStyle.FixedSingle;
                    StampaInfoGioco();
                    Dado.Enabled = true;
                }
                //altrimenti la partita è terminata, quindi informiamo 
                //l'utente e aggiorniamo il tavolo
                else
                {
                    MessageBox.Show("Partita terminata!");
                    TerminaPartita();
                }
            }//end try
            catch (Exception)
            {
                MessageBox.Show("Tira il dado prima.");
            }
        }//end metodo turno_Click()

        //gestore dell'evento di click sul pulsante di acquisto libri
        private void libro_Click(object sender, EventArgs e)
        {
            //Compra() lancia un'eccezione se la casella non è comprabile
            try
            {
                //proviamo a comprare il libro, se ci riusciamo contrassegniamo
                //la casella col colore del giocatore
                bool esito = gioco.GiocatoreCorrente.Posizione.Compra();
                if (esito == true)
                    MostraProprietario();
                //disabilitiamo il pulsante e stampiamo le info di gioco
                libro.Enabled = false;
                StampaInfoGioco();
            }
            catch
            {
                MessageBox.Show("Casella non comprabile.");
            }        
        }//end libro_Click()

        //gestore dell'evento di click sul pulsante di acquisto libri
        private void appunti_Click(object sender, EventArgs e)
        {
            //Compra() lancia un'eccezione se la casella non è potenziabile
            try
            {
                //proviamo a comprare gli appunti, e stampiamo le info di gioco
                bool esito = gioco.GiocatoreCorrente.Posizione.Potenzia();
                //se è stato possibile, mettiamo un bordo per far notare la differenza
                if (esito == true)
                    TrovaImmagineProprietario().BorderStyle = BorderStyle.Fixed3D;
                StampaInfoGioco();
            }
            catch
            {
                MessageBox.Show("Casella non potenziabile.");
            }
        }//end appunti_Click()

        //gestore dell'evento di click sul pulsante di avvio della partita
        private void avviaPartita_Click(object sender, EventArgs e)
        {
            //mostriamo il form per aggiungere i giocatori alla partita
            AvviaPartita ap = new AvviaPartita(gioco, this);
            ap.Show();
        }

        //gestore dell'evento di click sul pulsante di visualizzazione delle regole
        private void regole_Click(object sender, EventArgs e)
        {
            //mostriamo il form con le regole di gioco
            Regole regole = new Regole();
            regole.Show();
        }

        //gestore dell'evento di click sul pulsante di terminazione della partita
        private void stop_Click(object sender, EventArgs e) { TerminaPartita(); }

        //gestore dell'evento di tick del timer di gioco
        private void veroTimer_Tick(object sender, EventArgs e)
        {
            //aggiorniamo il timer sottraendo un secondo al tempo rimanente
            tempo = tempo - (new TimeSpan(0, 0, 1));
            this.TimerGioco.Text = tempo.Hours + ":" + tempo.Minutes + ":" +
                                    tempo.Seconds;
        }

        /*gestore dell'evento di tick del timer necessario per posticipare il secondo 
         movimento della pedina nel caso in cui venga pescata una carta movimento*/
        private void timerMovimento_Tick(object sender, EventArgs e)
        {
            //la pedina si muove verso la casella finale e si resetta tutto
            Casella conseguente = gioco.GiocatoreCorrente.Posizione;
            Muoviti(this.corrente, conseguente);            
            this.timerMovimento.Stop();
            this.timerMovimento.Enabled = false;
            MostraCarta(false);
            turno.Enabled = true;
        }
       
        //metodo per spostare il giocatore
        public void Muoviti(Casella prima, Casella seconda)
        {
            //viene mossa la pedina
            pedina.MovimentoPedina(prima, seconda);

            //vengono mostrate le informazioni sulla casella e aggiornato il colore
            nomeCasella.Text = seconda.Nome;
            descrizioneCasella.Text = "\r\n" + seconda;
            if (seconda is CasellaEsame)
                nomeCasella.BackColor = colorePerArea[corrente.AreaFormativa.Nome];
            else
                nomeCasella.BackColor = Color.Gold;           
        }//end metodo Muoviti()

        //metodo per mostrare un segno sulle caselle che ne indichi il proprietario
        public void MostraProprietario()
        {            
            PictureBox proprietario = TrovaImmagineProprietario();
            //viene impostato il colore corrispondente al giocatore
            proprietario.BackColor = coloriPerGiocatore[gioco.Turno];
            proprietario.Visible = true;            
        }//end MostraProprietario()

        //metodo che restituisce la PictureBox che indica il proprietario della casella
        public PictureBox TrovaImmagineProprietario()
        {
            /*si cerca la PictureBox nel tabellone che abbia come tag l'indice della 
            casella corrente.*/
            PictureBox proprietario = null;
            bool trovato = false;
            while (trovato == false)
            {
                foreach (PictureBox p in this.tabellone.Controls)
                {
                    if (p.Tag != null)
                    {
                        //si converte il tag a string e si estrae il numero
                        int tag = int.Parse((string)p.Tag);
                        if (tag == gioco.OttieniIndice(corrente))
                        {
                            proprietario = p;
                            trovato = true;
                        }
                    }//end if
                }//end foreach
            }//end while
            return proprietario;
        }//end TrovaImmagineProprietario()

        //metodo per mostrare (o nascondere, a seconda dell'input) la carta pescata
        public void MostraCarta(bool mostra)
        {
            nomeCarta.Visible = mostra;
            descrizioneCarta.Visible = mostra;
            cartaPescata.Visible = mostra;
            if (mostra == true)
            {
                //vengono aggiornate le info della carta
                nomeCarta.Text = corrente.TipoCarta;
                descrizioneCarta.Text = "\r\n" + corrente.Carta.Descrizione;
                //la carta viene colorata a seconda del tipo
                if (corrente.Nome.Equals("Probabilità"))
                    ColoraCarta(Color.SandyBrown);
                else
                    ColoraCarta(Color.PaleGreen);
            }
        }//end metodo MostraCarta()

        //metodo per colorare la carta a seconda del colore in input
        public void ColoraCarta(Color colore)
        {
            nomeCarta.BackColor = colore;
            cartaPescata.BackColor = colore;
            descrizioneCarta.BackColor = colore;
        }

        //metodo che restituisce i dati del giocatore corrispondente all'indice in input
        public string DatiGiocatore(int indice)
        {
            return "Soldi: " + (int)gioco.Giocatori.ElementAt(indice).Soldi + "\r\n" +
                   "CFU: " + gioco.Giocatori.ElementAt(indice).Cfu + "\r\n" +
                   "Ruolo: " + gioco.Giocatori.ElementAt(indice).Ruolo;
        }
        
        //metodo per stampare le informazioni di gioco nella TextBox               
        public void StampaInfoGioco()
        {
            if (gioco.InfoGioco != null)
            {
                infoGioco.Text = gioco.InfoGioco;
                //la TextBox viene scrollata automaticamente
                infoGioco.SelectionStart = infoGioco.Text.Length;
                infoGioco.ScrollToCaret();
            }
        }

        //metodo per terminare la partita
        public void TerminaPartita()
        {
            //vengono disabilitati i pulsanti e fermato il timer
            foreach (Control c in pulsanti)
                c.Enabled = false;
            veroTimer.Stop();
            //viene stampata la classifica
            gioco.DecretaClassifica();
            StampaInfoGioco();
        }        
    }//end classe
}
