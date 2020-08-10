using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUnipoly
{
    //classe di configurazione delle caselle e delle carte del gioco
    public class Configurazione
    {
        private Gioco gioco;        //gioco a cui si riferisce

        //costruttore
        public Configurazione(Gioco gioco)
        {
            //inizializzazione dell'attributo
            this.gioco = gioco;
        }

        //metodo per configurare il tabellone
        public void CaricaTabellone()
        {
            //creazione delle caselle speciali con relative carte
            Carta c1 = new CartaSoldi(null, -500, this.gioco, "Prima rata! -500 euro");
            Casella cas_1 = new CasellaSpeciale("VIA", "Paghi una tassa", this.gioco, c1);
            Carta c2 = new CartaSoldi(null, -400, this.gioco, "Seconda rata! -400 euro");
            Casella cas_2 = new CasellaSpeciale("Seconda rata", "Paghi una tassa", this.gioco, c2);
            Casella cas_3 = new CasellaTerzaRata("Terza rata", "Paghi in base al tuo capitale", this.gioco);
            Casella cas_4_1 = new CasellaFuoriCorso("Fuori corso", "Perdi il 10% del tuo capitale", this.gioco);
            Casella cas_4_2 = new CasellaFuoriCorso("Fuori corso", "Perdi il 10% del tuo capitale", this.gioco);
            Carta c5 = new CartaSoldi(null, 500, this.gioco, "Borsa di studio! +500 euro");
            Casella cas_5 = new CasellaSpeciale("Borsa di studio", "Ottieni una borsa di studio", this.gioco, c5);            
            Carta c6 = new CartaStallo(null, 2, this.gioco, "Resta fermo due turni");
            Casella cas_6 = new CasellaSpeciale("Stallo", "Sei in stallo", this.gioco, c6);
            Carta c7 = new CartaMovimento(null, cas_6, this.gioco,
                                                    "Vai in stallo: hai pagato in ritardo le tasse");
            Casella cas_7 = new CasellaSpeciale("Vai in stallo", "Salti alla casella di stallo", this.gioco, c7);
            Carta c8 = new CartaStallo(null, 1, this.gioco, "Resta fermo un turno");
            Casella cas_8_1 = new CasellaSpeciale("Vacanza pasquale", "Stallo per un turno", this.gioco, c8);
            Casella cas_8_2 = new CasellaSpeciale("Vacanza di Natale ", "Stallo per un turno", this.gioco, c8);
            Casella cas_8_3 = new CasellaSpeciale("Vacanza estiva", "Stallo per un turno", this.gioco, c8);
            Carta c9 = new CartaCfu(null, -24, this.gioco, "Perdi 24 cfu per il giovedì universitario");
            Casella cas_9 = new CasellaSpeciale("Giovedì universitario", "Perdi il libretto", this.gioco, c9);
            Carta c10 = new CartaCfu(null, 24, this.gioco, "Guadagni 24 cfu per l'Erasmus");
            Casella cas_10 = new CasellaSpeciale("Erasmus", "Bonus per l'erasmus", this.gioco, c10);


            //creazione delle carte probabilità
            this.gioco.AggiungiCartaP(new CartaCfu(null, 30, this.gioco, "Seminario IBM -> +30 cfu"));
            this.gioco.AggiungiCartaP(new CartaCfu(null, 20, this.gioco, "Seminario intelligenza artificiale -> +20 cfu"));
            this.gioco.AggiungiCartaP(new CartaCfu("in sede", 15, this.gioco, "Fai l’ECDL (se sei studente in sede) -> +15 cfu"));
            this.gioco.AggiungiCartaP(new CartaCfu("straniero", 12, this.gioco, 
                                    "Convalida esami sostenuti all'estero (se sei straniero) -> + 12 cfu"));
            this.gioco.AggiungiCartaP(new CartaCfu(null, 15, this.gioco, "Workshop -> +15 cfu"));
            this.gioco.AggiungiCartaP(new CartaSoldi(null, 200, this.gioco, "Regalo dei parenti -> +200 euro"));
            this.gioco.AggiungiCartaP(new CartaSoldi(null, 400, this.gioco, "Borsa di studio per merito -> +400 euro"));
            this.gioco.AggiungiCartaP(new CartaSoldi("pendolare", 50, this.gioco, 
                                "Trovi dei soldi a terra alla stazione (se sei pendolare) -> +50 euro"));
            this.gioco.AggiungiCartaP(new CartaSoldi("fuori sede", 150, this.gioco, 
                                "Tua nonna pensa che non stai mangiando abbastanza e " +
                                "ti fa una ricarica (se sei fuori sede) -> +150 euro"));
            this.gioco.AggiungiCartaP(new CartaSoldi("straniero", 200, this.gioco, 
                                "Fai lezioni di lingua ai tuoi colleghi (se sei studente erasmus) -> +200 euro"));
            this.gioco.AggiungiCartaP(new CartaSoldi(null, 50, this.gioco, 
                                "Fai ripetizioni agli studenti delle superiori -> +50 euro"));
            this.gioco.AggiungiCartaP(new CartaSoldi(null, 75, this.gioco, "Sviluppi un’app di successo -> +75 euro"));
            this.gioco.AggiungiCartaP(new CartaSoldi(null, 20, this.gioco, "Ripari il pc di un amico -> +20 euro"));
            this.gioco.AggiungiCartaP(new CartaSoldi(null, 300, this.gioco, "Vinci alla lotteria -> +300 euro"));
            this.gioco.AggiungiCartaP(new CartaMovimento(null, cas_5, this.gioco, "Vai sulla casella borsa di studio"));
            this.gioco.AggiungiCartaP(new CartaMovimento(null, cas_10, this.gioco, "Vai in Erasmus"));




            //creazione delle carte imprevisti
            this.gioco.AggiungiCartaI(new CartaCfu(null, -15, this.gioco, 
                                   "Uno dei professori è tuo vicino di casa e ti odia -> -15 cfu"));
            this.gioco.AggiungiCartaI(new CartaCfu(null, -16, this.gioco,
                                   "Perdi il libretto universitario -> -16 CFU"));
            this.gioco.AggiungiCartaI(new CartaCfu(null, -10, this.gioco,
                                   "Copi il progetto da internet -> -10 cfu"));
            this.gioco.AggiungiCartaI(new CartaCfu(null, -12, this.gioco,
                                   "C’è un bug nel progetto che non riesci a sistemare -> -12 cfu"));
            this.gioco.AggiungiCartaI(new CartaSoldi("pendolare", -50, this.gioco, 
                                 "Perdi dei soldi alla stazione (se sei pendolare) -> -50 euro"));
            this.gioco.AggiungiCartaI(new CartaSoldi("fuori sede", -150, this.gioco, 
                                 "Torni a casa un weekend (se sei fuori sede) -> -150 euro"));
            this.gioco.AggiungiCartaI(new CartaSoldi("straniero", -200, this.gioco, "Se sei studente erasmus -> -200 euro"));
            this.gioco.AggiungiCartaI(new CartaSoldi(null, -100, this.gioco, 
                                "La sessione ti fa impazzire e devi andare dallo psichiatra -> -100 euro"));
            this.gioco.AggiungiCartaI(new CartaSoldi(null, -10, this.gioco, "Ti ammali e devi pagare il ticket -> -10 euro"));
            this.gioco.AggiungiCartaI(new CartaSoldi(null, -70, this.gioco, 
                                "Vieni derubato durante il giovedì universitario -> -70 euro"));
            this.gioco.AggiungiCartaI(new CartaSoldi(null, -30, this.gioco, 
                                "Si laurea un tuo collega e devi fargli il regalo -> -30 euro"));
            this.gioco.AggiungiCartaI(new CartaMovimento(null, cas_4_1, this.gioco, "Vai sulla casella fuori corso"));
            this.gioco.AggiungiCartaI(new CartaMovimento(null, cas_8_1, this.gioco, "Vai sulla casella vacanza pasquale"));
            this.gioco.AggiungiCartaI(new CartaMovimento(null, cas_8_3, this.gioco, "Vai sulla casella vacanza estiva"));
            this.gioco.AggiungiCartaI(new CartaMovimento(null, cas_8_2, this.gioco, "Vai sulla casella vacanza di Natale"));
            this.gioco.AggiungiCartaI(new CartaMovimento(null, cas_6, this.gioco, "Vai in stallo"));

            //caselle imprevisti e probabilità
            Casella cas1 = new CasellaCarta("Imprevisto", "Pesca una carta imprevisto.", this.gioco);
            Casella cas2 = new CasellaCarta("Imprevisto", "Pesca una carta imprevisto.", this.gioco);
            Casella cas3 = new CasellaCarta("Imprevisto", "Pesca una carta imprevisto.", this.gioco);
            Casella cas4 = new CasellaCarta("Probabilità", "Pesca una carta probabilità.", this.gioco);
            Casella cas5 = new CasellaCarta("Probabilità", "Pesca una carta probabilità.", this.gioco);
            Casella cas6 = new CasellaCarta("Probabilità", "Pesca una carta probabilità.", this.gioco);

            //creazione delle aree formative
            AreaFormativa af1 = new AreaFormativa("Formazione matematico-fisica");
            AreaFormativa af2 = new AreaFormativa("Formazione informatica di base");
            AreaFormativa af3 = new AreaFormativa("Discipline Informatiche");
            AreaFormativa af4 = new AreaFormativa("Programmazione");
            AreaFormativa af5 = new AreaFormativa("Esami di curriculum");
            AreaFormativa af6 = new AreaFormativa("Esami a Scelta");
            AreaFormativa af7 = new AreaFormativa("Tesi");
            AreaFormativa af8 = new AreaFormativa("Lingua Inglese");
            AreaFormativa af9 = new AreaFormativa("Tirocini formativi");

            //creazione delle caselle che rappresentano gli esami
            CasellaEsame cas7 = new CasellaEsame("Analisi Matematica", "Casella esame", 12, this.gioco, af1);
            CasellaEsame cas8 = new CasellaEsame("Matematica Discreta", "Casella esame", 6, this.gioco, af1);
            CasellaEsame cas9 = new CasellaEsame("Fisica I", "Casella esame", 6, this.gioco, af1);
            CasellaEsame cas10 = new CasellaEsame("Fisica II", "Casella esame", 6, this.gioco, af1);
            CasellaEsame cas11 = new CasellaEsame("Probabilità e Statistica", "Casella esame", 6, this.gioco, af1);
            CasellaEsame cas12 = new CasellaEsame("Algoritmi e Strutture Dati", "Casella esame", 12, this.gioco, af2);
            CasellaEsame cas13 = new CasellaEsame("Architettura degli Elaboratori", "Casella esame", 12, this.gioco, af2);
            CasellaEsame cas14 = new CasellaEsame("Sistemi Operativi", "Casella esame", 12, this.gioco, af3);
            CasellaEsame cas15 = new CasellaEsame("Basi di Dati", "Casella esame", 12, this.gioco, af3);
            CasellaEsame cas16 = new CasellaEsame("Reti di Calcolatori", "Casella esame", 12, this.gioco, af3);
            CasellaEsame cas17 = new CasellaEsame("Programmazione Procedurale e Logica", "Casella esame", 12, this.gioco, af4);
            CasellaEsame cas18 = new CasellaEsame("Programmazione a Oggetti e Ingegneria del Software", "Casella esame", 12, this.gioco, af4);
            CasellaEsame cas19 = new CasellaEsame("Linguaggi di Programmazione e Verifica del Software", "Casella esame", 12, this.gioco, af4);
            CasellaEsame cas20 = new CasellaEsame("Elaborazione di Segnali e Immagini", "Casella esame", 12, this.gioco, af5);
            CasellaEsame cas21 = new CasellaEsame("Simulazione Numerica", "Casella esame", 6, this.gioco, af5);
            CasellaEsame cas22 = new CasellaEsame("Economia e Gestione delle Imprese", "Casella esame", 6, this.gioco, af6);
            CasellaEsame cas23 = new CasellaEsame("Piattaforme Digitali per la Gestione del Territorio ", "Casella esame", 6, this.gioco, af6);
            CasellaEsame cas24 = new CasellaEsame("Tesi", "Casella esame", 6, this.gioco, af7);
            CasellaEsame cas25 = new CasellaEsame("Lingua Inglese", "Casella esame", 6, this.gioco, af8);
            CasellaEsame cas26 = new CasellaEsame("Tirocinio in azienda", "Casella esame", 3, this.gioco, af9);
            CasellaEsame cas27 = new CasellaEsame("Tirocinio in università", "Casella esame", 3, this.gioco, af9);

            //inserimento degli esami nelle aree formative
            af1.AggiungiEsame(cas7);
            af1.AggiungiEsame(cas8);
            af1.AggiungiEsame(cas9);
            af1.AggiungiEsame(cas10);
            af1.AggiungiEsame(cas11);
            af2.AggiungiEsame(cas12);
            af2.AggiungiEsame(cas13);
            af3.AggiungiEsame(cas14);
            af3.AggiungiEsame(cas15);
            af3.AggiungiEsame(cas16);
            af4.AggiungiEsame(cas17);
            af4.AggiungiEsame(cas18);
            af4.AggiungiEsame(cas19);
            af5.AggiungiEsame(cas20);
            af5.AggiungiEsame(cas21);
            af6.AggiungiEsame(cas22);
            af6.AggiungiEsame(cas23);
            af7.AggiungiEsame(cas24);
            af8.AggiungiEsame(cas25);
            af9.AggiungiEsame(cas26);
            af9.AggiungiEsame(cas27);

            //inserimento delle caselle nel tabellone
            this.gioco.AggiungiCasella(cas_1);
            this.gioco.AggiungiCasella(cas8);
            this.gioco.AggiungiCasella(cas_5);
            this.gioco.AggiungiCasella(cas7);
            this.gioco.AggiungiCasella(cas4);
            this.gioco.AggiungiCasella(cas_8_2);
            this.gioco.AggiungiCasella(cas12);
            this.gioco.AggiungiCasella(cas1);
            this.gioco.AggiungiCasella(cas13);
            this.gioco.AggiungiCasella(cas22);
            this.gioco.AggiungiCasella(cas_6);
            this.gioco.AggiungiCasella(cas23);
            this.gioco.AggiungiCasella(cas_10);
            this.gioco.AggiungiCasella(cas20);
            this.gioco.AggiungiCasella(cas21);
            this.gioco.AggiungiCasella(cas_9);
            this.gioco.AggiungiCasella(cas11);
            this.gioco.AggiungiCasella(cas_2);
            this.gioco.AggiungiCasella(cas9);
            this.gioco.AggiungiCasella(cas10);
            this.gioco.AggiungiCasella(cas_8_1);
            this.gioco.AggiungiCasella(cas17);
            this.gioco.AggiungiCasella(cas2);
            this.gioco.AggiungiCasella(cas18);
            this.gioco.AggiungiCasella(cas19);
            this.gioco.AggiungiCasella(cas_4_1);
            this.gioco.AggiungiCasella(cas15);
            this.gioco.AggiungiCasella(cas14);
            this.gioco.AggiungiCasella(cas5);
            this.gioco.AggiungiCasella(cas16);
            this.gioco.AggiungiCasella(cas_7);
            this.gioco.AggiungiCasella(cas_3);
            this.gioco.AggiungiCasella(cas26);
            this.gioco.AggiungiCasella(cas_8_3);
            this.gioco.AggiungiCasella(cas27);
            this.gioco.AggiungiCasella(cas6);
            this.gioco.AggiungiCasella(cas3);
            this.gioco.AggiungiCasella(cas25);
            this.gioco.AggiungiCasella(cas_4_2);
            this.gioco.AggiungiCasella(cas24);
        }//end CaricaTabellone()
    }//end classe
}
