using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    //classe astratta da cui erediteranno tutte le caselle
    public abstract class Casella
    {
        //attributi 

        protected string nome;          //nome della casella
        protected string istruzioni;    //dettagli della casella
        protected Gioco gioco;          //gioco a cui si riferisce

        /*alcune caselle hanno una carta associata che descrive le
         conseguenze del transito*/
        protected Carta carta;
        /*nel caso in cui la casella sia una CasellaCarta,
         va specificato se la carta è imprevisto o probabilità*/
        protected string tipoCarta;
        /*nel caso in cui la casella rappresenti un esame,
         va specificata l'area formativa dell'esame*/      
        protected AreaFormativa areaFormativa;

        //proprietà read-only per accedere agli attributi
        public string Nome { get { return this.nome; } }
        public string Istruzioni { get { return this.istruzioni; } }
        public Carta Carta { get { return this.carta; } }
        public string TipoCarta { get { return this.tipoCarta; } }
        public AreaFormativa AreaFormativa { get { return this.areaFormativa; } }

        //metodo astratto che attua le conseguenze del transito
        public abstract void Transita();

        /*metodo virtuale per comprare la casella.
         Solo le caselle che faranno l'overriding potranno implementare 
         l'acquisto, le altre lanceranno un'eccezione*/
        public virtual bool Compra()
        {
            gioco.InfoGioco += "Azione non consentita.\r\n";
            throw new Exception();
        }

        /*metodo virtuale per aggiungere dei potenziamenti alla casella. 
         Solo le caselle che faranno l'overriding potranno implementare 
         il potenziamento, le altre lanceranno un'eccezione*/
        public virtual bool Potenzia()
        {
            gioco.InfoGioco += "Azione non consentita.\r\n";
            throw new Exception();
        }
    }//end classe
}
