using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

//si importa la libreria del gioco
using LibreriaUnipoly;

namespace UnipolyGUI
{
    //classe che rappresenta la pedina che si muoverà sul tabellone
    class Pedina
    {
        //attributi
        private readonly TavoloGioco tg;                    //tavolo a cui si riferisce
        private readonly Gioco gioco;                       //gioco a cui si riferisce
        private PictureBox immaginePedina;                  //immagine della pedina
        public const int DISTANZA_PEDINE = 20;              //distanza tra le pedine
        public const int DISTANZA_CASELLE = 55;             //distanza tra le caselle
        //posizione dei 4 angoli
        private readonly Point bassoDestra;    
        private readonly Point bassoSinistra;
        private readonly Point altoSinistra;
        private readonly Point altoDestra;

        //costruttore
        public Pedina(TavoloGioco tg, Gioco gioco)
        {
            //inizializzazione degli attributi
            this.tg = tg;
            this.gioco = gioco;
            bassoDestra = new Point(588, 590);
            bassoSinistra = new Point(10, 576);
            altoSinistra = new Point(38, 4);
            altoDestra = new Point(610, 30);
        }

        //proprietà per cambiare l'immagine della pedina
        public PictureBox ImmaginePedina { set { immaginePedina = value; } }

        //metodo per spostare la pedina sul tabellone
        //prende in input la casella di partenza e quella di arrivo
        public void MovimentoPedina(Casella prec, Casella corr)
        {
            //si calcolano gli indici di partenza e di arrivo
            int indicePrec = gioco.OttieniIndice(prec);
            int indiceCorr = gioco.OttieniIndice(corr);

            //fino a quando non si arriva sull'indice giusto
            while (indiceCorr != indicePrec)
            {
                //sleep per visualizzare meglio i salti
                System.Threading.Thread.Sleep(70);

                //se siamo sulla riga inferiore, ci spostiamo a sinistra
                if (indicePrec >= 0 && indicePrec < 9)                                         
                    immaginePedina.Location = new Point(immaginePedina.Location.X - DISTANZA_CASELLE,
                                                        immaginePedina.Location.Y);
                //alla fine della riga ci posizioniamo sull'angolo
                else if (indicePrec == 9)
                    PosizionaPedinaAngolo(bassoSinistra);

                //se siamo sulla riga a sinistra, ci spostiamo in alto
                else if (indicePrec >= 10 && indicePrec < 19) 
                    immaginePedina.Location = new Point(immaginePedina.Location.X, 
                                                        immaginePedina.Location.Y - DISTANZA_CASELLE);
                //alla fine della riga ci posizioniamo sull'angolo
                else if (indicePrec == 19)
                PosizionaPedinaAngolo(altoSinistra);

                //se siamo sulla riga superiore, ci spostiamo a destra
                else if (indicePrec >= 20 && indicePrec < 29)
                    immaginePedina.Location = new Point(immaginePedina.Location.X + DISTANZA_CASELLE, 
                                                        immaginePedina.Location.Y);
                //alla fine della riga ci posizioniamo sull'angolo
                else if (indicePrec == 29)
                PosizionaPedinaAngolo(altoDestra);

                //se siamo sulla riga a destra, ci spostiamo in basso
                else if (indicePrec >= 30 && indicePrec < 39)
                    immaginePedina.Location = new Point(immaginePedina.Location.X, 
                                                        immaginePedina.Location.Y + DISTANZA_CASELLE);
                //alla fine della riga ci posizioniamo sull'angolo
                else if (indicePrec == 39)
                PosizionaPedinaAngolo(bassoDestra);

                //ci siamo spostati di una casella
                indicePrec++;
                //se abbiamo percorso tutto il tabellone, torniamo alla prima casella
                if (indicePrec == 40)
                    indicePrec = 0;
            }
        }//end MovimentoPedina()

        //metodo per posizionarsi ad uno degli angoli in input.
        //è necessario poiché gli angoli sono più grandi delle altre caselle
        public void PosizionaPedinaAngolo(Point punto)
        {
            if (gioco.Turno == 0)
                tg.ImmaginiPedine[0].Location = punto;
            else if (gioco.Turno == 1)
                tg.ImmaginiPedine[1].Location = new Point(punto.X + DISTANZA_PEDINE, punto.Y);
            else if (gioco.Turno == 2)
                tg.ImmaginiPedine[2].Location = new Point(punto.X, punto.Y + DISTANZA_PEDINE);
            else
                tg.ImmaginiPedine[3].Location = new Point(punto.X + DISTANZA_PEDINE,
                                                          punto.Y + DISTANZA_PEDINE);
        }//end PosizionaPedinaAngolo()
    }//end classe
}
