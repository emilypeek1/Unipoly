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
    //classe di tipo Form per aggiungere i giocatori
    public partial class AvviaPartita: Form
    {
        private readonly Gioco gioco;       //gioco a cui ci si riferisce
        private readonly TavoloGioco tg;    //tavolo da gioco da inizializzare

        //costruttore
        public AvviaPartita(Gioco gioco, TavoloGioco tg)
        {
            //inizializzazione di componenti e attributi
            InitializeComponent();
            this.gioco = gioco;
            this.tg = tg;
        }

        //gestore dell'evento di click sul tasto Conferma
        private void Conferma_Click(object sender, EventArgs e)
        {
            //vengono contati i giocatori validi inseriti
            int numGiocatori = 0;
            if (ValidaGiocatore(nome1.Text, (string)ruolo1.SelectedItem))
                numGiocatori++;
            if (ValidaGiocatore(nome2.Text, (string)ruolo2.SelectedItem))
                numGiocatori++;
            if (ValidaGiocatore(nome3.Text, (string)ruolo3.SelectedItem))
                numGiocatori++;
            if (ValidaGiocatore(nome4.Text, (string)ruolo4.SelectedItem))
                numGiocatori++;

            //se i giocatori sono nel range [2,4]
            if (numGiocatori >= 2 && numGiocatori <= 4)
            {
                //vengono aggiunti i primi 2 giocatori
                Giocatore gioc1 = gioco.AggiungiGiocatore(nome1.Text,
                                        (string)ruolo1.SelectedItem);
                Giocatore gioc2 = gioco.AggiungiGiocatore(nome2.Text, 
                                        (string)ruolo2.SelectedItem);
                //vengono inizializzati e resi visibili: pedine, nomi, dati
                AggiornaDati(0, (Bitmap)tg.ImmaginiPedine[0].Image, gioc1.Nome, tg.DatiGiocatore(0));
                AggiornaDati(1, (Bitmap)tg.ImmaginiPedine[1].Image, gioc2.Nome, tg.DatiGiocatore(1));
                //viene messo in evidenza il segnaposto del primo giocatore
                tg.Segnaposti[0].BorderStyle = BorderStyle.FixedSingle;
                //se c'è anche un terzo giocatore
                if (numGiocatori == 3 || numGiocatori == 4)
                {
                    //viene aggiunto il terzo giocatore
                    Giocatore gioc3 = gioco.AggiungiGiocatore(nome3.Text, 
                                            (string)ruolo3.SelectedItem);
                    //vengono inizializzati e resi visibili: pedine, nomi, dati
                    AggiornaDati(2, (Bitmap)tg.ImmaginiPedine[2].Image, gioc3.Nome, tg.DatiGiocatore(2));
                }
                //se c'è anche un quarto giocatore
                if (numGiocatori == 4)
                {
                    //viene aggiunto il quarto giocatore
                    Giocatore gioc4 = gioco.AggiungiGiocatore(nome4.Text, (string)ruolo4.SelectedItem);
                    ///vengono inizializzati e resi visibili: pedine, nomi, dati
                    AggiornaDati(3, (Bitmap)tg.ImmaginiPedine[3].Image, gioc4.Nome, tg.DatiGiocatore(3));
                }
                //si disabilita il pulsante di avvio partita
                tg.AvviaPartita.Enabled = false;
                //si abilitano il pulsante di lancio del dado e quello di stop
                tg.Dado.Enabled = true;
                tg.Stop.Enabled = true;
                //si chiude la finestra
                this.Close();
                //si inizia la partita
                gioco.IniziaPartita();
                //si avvia il timer di gioco
                tg.AvviaTimer();
            }
            //altrimenti viene mostrata una finestra di warning
            else
            {
                MessageBox.Show("Errore, numero di giocatori inseribili non valido.", 
                                "Errore di formato", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }//end Conferma_Click()

        //metodo di validazione di nome e ruolo dei giocatori inseriti
        public bool ValidaGiocatore(string nome, string ruolo)
        {
            bool esito = false; //true se giocatore è valido

            if ((nome.Equals("")) == false && ruolo != null &&
                (ruolo.Equals("in sede") ||
                ruolo.Equals("fuori sede") ||
                ruolo.Equals("pendolare") ||
                ruolo.Equals("straniero")))
                esito = true;

            return esito;
        }//end ValidaGiocatore() 

        //metodo per inizializzare le informazioni sui giocatori sul tavolo da gioco
        public void AggiornaDati(int indice, Bitmap immagine, string nome, string dati)
        {
            tg.ImmaginiPedine[indice].Image = immagine;
            tg.ImmaginiPedine[indice].Visible = true;
            tg.Nomi[indice].Text = nome;
            tg.Nomi[indice].Visible = true;
            tg.Dati[indice].Text = dati;
            tg.Dati[indice].Visible = true;
            tg.Segnaposti[indice].Visible = true;
        }
    }//end classe
}
