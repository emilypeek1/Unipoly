using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace UnipolyGUI
{
    partial class TavoloGioco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TavoloGioco));
            this.infoGioco = new System.Windows.Forms.TextBox();
            this.dado = new System.Windows.Forms.Button();
            this.turno = new System.Windows.Forms.Button();
            this.libro = new System.Windows.Forms.Button();
            this.appunti = new System.Windows.Forms.Button();
            this.avviaPartita = new System.Windows.Forms.Button();
            this.regole = new System.Windows.Forms.Button();
            this.timerGioco = new System.Windows.Forms.Label();
            this.veroTimer = new System.Windows.Forms.Timer(this.components);
            this.nomeCasella = new System.Windows.Forms.TextBox();
            this.descrizioneCasella = new System.Windows.Forms.TextBox();
            this.nome1 = new System.Windows.Forms.Label();
            this.nome2 = new System.Windows.Forms.Label();
            this.nome3 = new System.Windows.Forms.Label();
            this.nome4 = new System.Windows.Forms.Label();
            this.dati1 = new System.Windows.Forms.TextBox();
            this.dati2 = new System.Windows.Forms.TextBox();
            this.dati3 = new System.Windows.Forms.TextBox();
            this.dati4 = new System.Windows.Forms.TextBox();
            this.descrizioneCarta = new System.Windows.Forms.TextBox();
            this.nomeCarta = new System.Windows.Forms.TextBox();
            this.timerMovimento = new System.Windows.Forms.Timer(this.components);
            this.stop = new System.Windows.Forms.Button();
            this.esitoDado = new System.Windows.Forms.PictureBox();
            this.colore3 = new System.Windows.Forms.PictureBox();
            this.colore4 = new System.Windows.Forms.PictureBox();
            this.colore2 = new System.Windows.Forms.PictureBox();
            this.colore1 = new System.Windows.Forms.PictureBox();
            this.tabellone = new System.Windows.Forms.Panel();
            this.proprietario16 = new System.Windows.Forms.PictureBox();
            this.proprietario32 = new System.Windows.Forms.PictureBox();
            this.proprietario37 = new System.Windows.Forms.PictureBox();
            this.proprietario39 = new System.Windows.Forms.PictureBox();
            this.proprietario13 = new System.Windows.Forms.PictureBox();
            this.proprietario14 = new System.Windows.Forms.PictureBox();
            this.proprietario34 = new System.Windows.Forms.PictureBox();
            this.proprietario19 = new System.Windows.Forms.PictureBox();
            this.proprietario18 = new System.Windows.Forms.PictureBox();
            this.proprietario6 = new System.Windows.Forms.PictureBox();
            this.proprietario8 = new System.Windows.Forms.PictureBox();
            this.proprietario9 = new System.Windows.Forms.PictureBox();
            this.proprietario11 = new System.Windows.Forms.PictureBox();
            this.proprietario21 = new System.Windows.Forms.PictureBox();
            this.proprietario27 = new System.Windows.Forms.PictureBox();
            this.proprietario26 = new System.Windows.Forms.PictureBox();
            this.proprietario24 = new System.Windows.Forms.PictureBox();
            this.proprietario23 = new System.Windows.Forms.PictureBox();
            this.proprietario29 = new System.Windows.Forms.PictureBox();
            this.proprietario3 = new System.Windows.Forms.PictureBox();
            this.proprietario1 = new System.Windows.Forms.PictureBox();
            this.pedina3 = new System.Windows.Forms.PictureBox();
            this.pedina4 = new System.Windows.Forms.PictureBox();
            this.pedina2 = new System.Windows.Forms.PictureBox();
            this.pedina1 = new System.Windows.Forms.PictureBox();
            this.casella = new System.Windows.Forms.PictureBox();
            this.cartaPescata = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.esitoDado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colore3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colore4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colore1)).BeginInit();
            this.tabellone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedina3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedina4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedina2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedina1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaPescata)).BeginInit();
            this.SuspendLayout();
            // 
            // infoGioco
            // 
            this.infoGioco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.infoGioco.Location = new System.Drawing.Point(1498, 196);
            this.infoGioco.Multiline = true;
            this.infoGioco.Name = "infoGioco";
            this.infoGioco.ReadOnly = true;
            this.infoGioco.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoGioco.Size = new System.Drawing.Size(342, 101);
            this.infoGioco.TabIndex = 0;
            // 
            // dado
            // 
            this.dado.BackColor = System.Drawing.Color.White;
            this.dado.Enabled = false;
            this.dado.Location = new System.Drawing.Point(1130, 359);
            this.dado.Name = "dado";
            this.dado.Size = new System.Drawing.Size(144, 100);
            this.dado.TabIndex = 1;
            this.dado.Text = "Lancia dado";
            this.dado.UseVisualStyleBackColor = false;
            this.dado.Click += new System.EventHandler(this.dado_Click);
            // 
            // turno
            // 
            this.turno.BackColor = System.Drawing.Color.White;
            this.turno.Enabled = false;
            this.turno.Location = new System.Drawing.Point(1317, 359);
            this.turno.Name = "turno";
            this.turno.Size = new System.Drawing.Size(144, 100);
            this.turno.TabIndex = 2;
            this.turno.Text = "Termina turno";
            this.turno.UseVisualStyleBackColor = false;
            this.turno.Click += new System.EventHandler(this.turno_Click);
            // 
            // libro
            // 
            this.libro.BackColor = System.Drawing.Color.White;
            this.libro.Enabled = false;
            this.libro.Location = new System.Drawing.Point(1503, 359);
            this.libro.Name = "libro";
            this.libro.Size = new System.Drawing.Size(144, 100);
            this.libro.TabIndex = 3;
            this.libro.Text = "Compra libro";
            this.libro.UseVisualStyleBackColor = false;
            this.libro.Click += new System.EventHandler(this.libro_Click);
            // 
            // appunti
            // 
            this.appunti.BackColor = System.Drawing.Color.White;
            this.appunti.Enabled = false;
            this.appunti.Location = new System.Drawing.Point(1696, 359);
            this.appunti.Name = "appunti";
            this.appunti.Size = new System.Drawing.Size(144, 100);
            this.appunti.TabIndex = 4;
            this.appunti.Text = "Compra appunti";
            this.appunti.UseVisualStyleBackColor = false;
            this.appunti.Click += new System.EventHandler(this.appunti_Click);
            // 
            // avviaPartita
            // 
            this.avviaPartita.BackColor = System.Drawing.Color.White;
            this.avviaPartita.Location = new System.Drawing.Point(1130, 196);
            this.avviaPartita.Name = "avviaPartita";
            this.avviaPartita.Size = new System.Drawing.Size(144, 100);
            this.avviaPartita.TabIndex = 7;
            this.avviaPartita.Text = "Avvia partita";
            this.avviaPartita.UseVisualStyleBackColor = false;
            this.avviaPartita.Click += new System.EventHandler(this.avviaPartita_Click);
            // 
            // regole
            // 
            this.regole.BackColor = System.Drawing.Color.White;
            this.regole.Location = new System.Drawing.Point(1319, 196);
            this.regole.Name = "regole";
            this.regole.Size = new System.Drawing.Size(144, 100);
            this.regole.TabIndex = 8;
            this.regole.Text = "Regole";
            this.regole.UseVisualStyleBackColor = false;
            this.regole.Click += new System.EventHandler(this.regole_Click);
            // 
            // timerGioco
            // 
            this.timerGioco.AutoSize = true;
            this.timerGioco.Location = new System.Drawing.Point(1038, 35);
            this.timerGioco.Name = "timerGioco";
            this.timerGioco.Size = new System.Drawing.Size(62, 20);
            this.timerGioco.TabIndex = 9;
            this.timerGioco.Text = "2:00:00";
            // 
            // veroTimer
            // 
            this.veroTimer.Interval = 1000;
            this.veroTimer.Tick += new System.EventHandler(this.veroTimer_Tick);
            // 
            // nomeCasella
            // 
            this.nomeCasella.BackColor = System.Drawing.Color.Gold;
            this.nomeCasella.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.nomeCasella.ForeColor = System.Drawing.Color.Black;
            this.nomeCasella.Location = new System.Drawing.Point(1142, 530);
            this.nomeCasella.Multiline = true;
            this.nomeCasella.Name = "nomeCasella";
            this.nomeCasella.ReadOnly = true;
            this.nomeCasella.Size = new System.Drawing.Size(316, 110);
            this.nomeCasella.TabIndex = 13;
            this.nomeCasella.Text = "VIA!";
            this.nomeCasella.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descrizioneCasella
            // 
            this.descrizioneCasella.AcceptsReturn = true;
            this.descrizioneCasella.BackColor = System.Drawing.Color.White;
            this.descrizioneCasella.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descrizioneCasella.Location = new System.Drawing.Point(1142, 646);
            this.descrizioneCasella.Multiline = true;
            this.descrizioneCasella.Name = "descrizioneCasella";
            this.descrizioneCasella.ReadOnly = true;
            this.descrizioneCasella.Size = new System.Drawing.Size(316, 233);
            this.descrizioneCasella.TabIndex = 14;
            this.descrizioneCasella.Text = "\r\nBenvenuti all\'Università. Lasciate ogni speranza o voi che entrate!";
            this.descrizioneCasella.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nome1
            // 
            this.nome1.AutoSize = true;
            this.nome1.Location = new System.Drawing.Point(1133, 34);
            this.nome1.Name = "nome1";
            this.nome1.Size = new System.Drawing.Size(92, 20);
            this.nome1.TabIndex = 15;
            this.nome1.Text = "Giocatore 1";
            this.nome1.Visible = false;
            // 
            // nome2
            // 
            this.nome2.AutoSize = true;
            this.nome2.Location = new System.Drawing.Point(1324, 34);
            this.nome2.Name = "nome2";
            this.nome2.Size = new System.Drawing.Size(92, 20);
            this.nome2.TabIndex = 16;
            this.nome2.Text = "Giocatore 2";
            this.nome2.Visible = false;
            // 
            // nome3
            // 
            this.nome3.AutoSize = true;
            this.nome3.Location = new System.Drawing.Point(1517, 34);
            this.nome3.Name = "nome3";
            this.nome3.Size = new System.Drawing.Size(92, 20);
            this.nome3.TabIndex = 17;
            this.nome3.Text = "Giocatore 3";
            this.nome3.Visible = false;
            // 
            // nome4
            // 
            this.nome4.AutoSize = true;
            this.nome4.Location = new System.Drawing.Point(1699, 35);
            this.nome4.Name = "nome4";
            this.nome4.Size = new System.Drawing.Size(92, 20);
            this.nome4.TabIndex = 18;
            this.nome4.Text = "Giocatore 4";
            this.nome4.Visible = false;
            // 
            // dati1
            // 
            this.dati1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dati1.Location = new System.Drawing.Point(1130, 68);
            this.dati1.Multiline = true;
            this.dati1.Name = "dati1";
            this.dati1.ReadOnly = true;
            this.dati1.Size = new System.Drawing.Size(144, 90);
            this.dati1.TabIndex = 19;
            this.dati1.Visible = false;
            // 
            // dati2
            // 
            this.dati2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dati2.Location = new System.Drawing.Point(1319, 68);
            this.dati2.Multiline = true;
            this.dati2.Name = "dati2";
            this.dati2.ReadOnly = true;
            this.dati2.Size = new System.Drawing.Size(144, 90);
            this.dati2.TabIndex = 20;
            this.dati2.Visible = false;
            // 
            // dati3
            // 
            this.dati3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dati3.Location = new System.Drawing.Point(1510, 68);
            this.dati3.Multiline = true;
            this.dati3.Name = "dati3";
            this.dati3.ReadOnly = true;
            this.dati3.Size = new System.Drawing.Size(144, 90);
            this.dati3.TabIndex = 21;
            this.dati3.Visible = false;
            // 
            // dati4
            // 
            this.dati4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dati4.Location = new System.Drawing.Point(1696, 68);
            this.dati4.Multiline = true;
            this.dati4.Name = "dati4";
            this.dati4.ReadOnly = true;
            this.dati4.Size = new System.Drawing.Size(144, 90);
            this.dati4.TabIndex = 22;
            this.dati4.Visible = false;
            // 
            // descrizioneCarta
            // 
            this.descrizioneCarta.AcceptsReturn = true;
            this.descrizioneCarta.BackColor = System.Drawing.Color.SandyBrown;
            this.descrizioneCarta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descrizioneCarta.Location = new System.Drawing.Point(1532, 664);
            this.descrizioneCarta.Multiline = true;
            this.descrizioneCarta.Name = "descrizioneCarta";
            this.descrizioneCarta.Size = new System.Drawing.Size(279, 122);
            this.descrizioneCarta.TabIndex = 23;
            this.descrizioneCarta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descrizioneCarta.Visible = false;
            // 
            // nomeCarta
            // 
            this.nomeCarta.BackColor = System.Drawing.Color.SandyBrown;
            this.nomeCarta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeCarta.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCarta.Location = new System.Drawing.Point(1532, 637);
            this.nomeCarta.Name = "nomeCarta";
            this.nomeCarta.ReadOnly = true;
            this.nomeCarta.Size = new System.Drawing.Size(279, 35);
            this.nomeCarta.TabIndex = 24;
            this.nomeCarta.Text = "Carta";
            this.nomeCarta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nomeCarta.Visible = false;
            // 
            // timerMovimento
            // 
            this.timerMovimento.Interval = 5000;
            this.timerMovimento.Tick += new System.EventHandler(this.timerMovimento_Tick);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.White;
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(1037, 68);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(78, 90);
            this.stop.TabIndex = 37;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // esitoDado
            // 
            this.esitoDado.Location = new System.Drawing.Point(1037, 376);
            this.esitoDado.Name = "esitoDado";
            this.esitoDado.Size = new System.Drawing.Size(70, 70);
            this.esitoDado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.esitoDado.TabIndex = 38;
            this.esitoDado.TabStop = false;
            this.esitoDado.Visible = false;
            // 
            // colore3
            // 
            this.colore3.BackColor = System.Drawing.Color.Transparent;
            this.colore3.Location = new System.Drawing.Point(1615, 25);
            this.colore3.Name = "colore3";
            this.colore3.Size = new System.Drawing.Size(30, 30);
            this.colore3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colore3.TabIndex = 33;
            this.colore3.TabStop = false;
            this.colore3.Visible = false;
            // 
            // colore4
            // 
            this.colore4.BackColor = System.Drawing.Color.Transparent;
            this.colore4.Location = new System.Drawing.Point(1797, 25);
            this.colore4.Name = "colore4";
            this.colore4.Size = new System.Drawing.Size(30, 30);
            this.colore4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colore4.TabIndex = 32;
            this.colore4.TabStop = false;
            this.colore4.Visible = false;
            // 
            // colore2
            // 
            this.colore2.BackColor = System.Drawing.Color.Transparent;
            this.colore2.Location = new System.Drawing.Point(1431, 25);
            this.colore2.Name = "colore2";
            this.colore2.Size = new System.Drawing.Size(30, 30);
            this.colore2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colore2.TabIndex = 31;
            this.colore2.TabStop = false;
            this.colore2.Visible = false;
            // 
            // colore1
            // 
            this.colore1.BackColor = System.Drawing.Color.Transparent;
            this.colore1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.colore1.Location = new System.Drawing.Point(1238, 25);
            this.colore1.Name = "colore1";
            this.colore1.Size = new System.Drawing.Size(30, 30);
            this.colore1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colore1.TabIndex = 30;
            this.colore1.TabStop = false;
            this.colore1.Visible = false;
            // 
            // tabellone
            // 
            this.tabellone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabellone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabellone.Controls.Add(this.proprietario16);
            this.tabellone.Controls.Add(this.proprietario32);
            this.tabellone.Controls.Add(this.proprietario37);
            this.tabellone.Controls.Add(this.proprietario39);
            this.tabellone.Controls.Add(this.proprietario13);
            this.tabellone.Controls.Add(this.proprietario14);
            this.tabellone.Controls.Add(this.proprietario34);
            this.tabellone.Controls.Add(this.proprietario19);
            this.tabellone.Controls.Add(this.proprietario18);
            this.tabellone.Controls.Add(this.proprietario6);
            this.tabellone.Controls.Add(this.proprietario8);
            this.tabellone.Controls.Add(this.proprietario9);
            this.tabellone.Controls.Add(this.proprietario11);
            this.tabellone.Controls.Add(this.proprietario21);
            this.tabellone.Controls.Add(this.proprietario27);
            this.tabellone.Controls.Add(this.proprietario26);
            this.tabellone.Controls.Add(this.proprietario24);
            this.tabellone.Controls.Add(this.proprietario23);
            this.tabellone.Controls.Add(this.proprietario29);
            this.tabellone.Controls.Add(this.proprietario3);
            this.tabellone.Controls.Add(this.proprietario1);
            this.tabellone.Controls.Add(this.pedina3);
            this.tabellone.Controls.Add(this.pedina4);
            this.tabellone.Controls.Add(this.pedina2);
            this.tabellone.Controls.Add(this.pedina1);
            this.tabellone.Location = new System.Drawing.Point(11, 9);
            this.tabellone.Name = "tabellone";
            this.tabellone.Size = new System.Drawing.Size(1000, 1000);
            this.tabellone.TabIndex = 25;
            // 
            // proprietario16
            // 
            this.proprietario16.Location = new System.Drawing.Point(2, 377);
            this.proprietario16.Name = "proprietario16";
            this.proprietario16.Size = new System.Drawing.Size(10, 80);
            this.proprietario16.TabIndex = 64;
            this.proprietario16.TabStop = false;
            this.proprietario16.Tag = "16";
            this.proprietario16.Visible = false;
            // 
            // proprietario32
            // 
            this.proprietario32.Location = new System.Drawing.Point(988, 212);
            this.proprietario32.Name = "proprietario32";
            this.proprietario32.Size = new System.Drawing.Size(10, 80);
            this.proprietario32.TabIndex = 63;
            this.proprietario32.TabStop = false;
            this.proprietario32.Tag = "32";
            this.proprietario32.Visible = false;
            // 
            // proprietario37
            // 
            this.proprietario37.Location = new System.Drawing.Point(986, 621);
            this.proprietario37.Name = "proprietario37";
            this.proprietario37.Size = new System.Drawing.Size(10, 80);
            this.proprietario37.TabIndex = 62;
            this.proprietario37.TabStop = false;
            this.proprietario37.Tag = "37";
            this.proprietario37.Visible = false;
            // 
            // proprietario39
            // 
            this.proprietario39.Location = new System.Drawing.Point(985, 785);
            this.proprietario39.Name = "proprietario39";
            this.proprietario39.Size = new System.Drawing.Size(10, 80);
            this.proprietario39.TabIndex = 61;
            this.proprietario39.TabStop = false;
            this.proprietario39.Tag = "39";
            this.proprietario39.Visible = false;
            // 
            // proprietario13
            // 
            this.proprietario13.Location = new System.Drawing.Point(1, 621);
            this.proprietario13.Name = "proprietario13";
            this.proprietario13.Size = new System.Drawing.Size(10, 80);
            this.proprietario13.TabIndex = 60;
            this.proprietario13.TabStop = false;
            this.proprietario13.Tag = "13";
            this.proprietario13.Visible = false;
            // 
            // proprietario14
            // 
            this.proprietario14.Location = new System.Drawing.Point(2, 540);
            this.proprietario14.Name = "proprietario14";
            this.proprietario14.Size = new System.Drawing.Size(10, 80);
            this.proprietario14.TabIndex = 59;
            this.proprietario14.TabStop = false;
            this.proprietario14.Tag = "14";
            this.proprietario14.Visible = false;
            // 
            // proprietario34
            // 
            this.proprietario34.BackColor = System.Drawing.Color.MintCream;
            this.proprietario34.Location = new System.Drawing.Point(986, 377);
            this.proprietario34.Name = "proprietario34";
            this.proprietario34.Size = new System.Drawing.Size(10, 80);
            this.proprietario34.TabIndex = 58;
            this.proprietario34.TabStop = false;
            this.proprietario34.Tag = "34";
            this.proprietario34.Visible = false;
            // 
            // proprietario19
            // 
            this.proprietario19.Location = new System.Drawing.Point(2, 127);
            this.proprietario19.Name = "proprietario19";
            this.proprietario19.Size = new System.Drawing.Size(10, 80);
            this.proprietario19.TabIndex = 57;
            this.proprietario19.TabStop = false;
            this.proprietario19.Tag = "19";
            this.proprietario19.Visible = false;
            // 
            // proprietario18
            // 
            this.proprietario18.Location = new System.Drawing.Point(2, 211);
            this.proprietario18.Name = "proprietario18";
            this.proprietario18.Size = new System.Drawing.Size(10, 80);
            this.proprietario18.TabIndex = 55;
            this.proprietario18.TabStop = false;
            this.proprietario18.Tag = "18";
            this.proprietario18.Visible = false;
            // 
            // proprietario6
            // 
            this.proprietario6.Location = new System.Drawing.Point(379, 984);
            this.proprietario6.Name = "proprietario6";
            this.proprietario6.Size = new System.Drawing.Size(80, 10);
            this.proprietario6.TabIndex = 54;
            this.proprietario6.TabStop = false;
            this.proprietario6.Tag = "6";
            this.proprietario6.Visible = false;
            // 
            // proprietario8
            // 
            this.proprietario8.Location = new System.Drawing.Point(210, 984);
            this.proprietario8.Name = "proprietario8";
            this.proprietario8.Size = new System.Drawing.Size(86, 10);
            this.proprietario8.TabIndex = 53;
            this.proprietario8.TabStop = false;
            this.proprietario8.Tag = "8";
            this.proprietario8.Visible = false;
            // 
            // proprietario9
            // 
            this.proprietario9.Location = new System.Drawing.Point(129, 984);
            this.proprietario9.Name = "proprietario9";
            this.proprietario9.Size = new System.Drawing.Size(80, 10);
            this.proprietario9.TabIndex = 52;
            this.proprietario9.TabStop = false;
            this.proprietario9.Tag = "9";
            this.proprietario9.Visible = false;
            // 
            // proprietario11
            // 
            this.proprietario11.Location = new System.Drawing.Point(1, 785);
            this.proprietario11.Name = "proprietario11";
            this.proprietario11.Size = new System.Drawing.Size(10, 80);
            this.proprietario11.TabIndex = 51;
            this.proprietario11.TabStop = false;
            this.proprietario11.Tag = "11";
            this.proprietario11.Visible = false;
            // 
            // proprietario21
            // 
            this.proprietario21.Location = new System.Drawing.Point(129, -2);
            this.proprietario21.Name = "proprietario21";
            this.proprietario21.Size = new System.Drawing.Size(80, 10);
            this.proprietario21.TabIndex = 39;
            this.proprietario21.TabStop = false;
            this.proprietario21.Tag = "21";
            this.proprietario21.Visible = false;
            // 
            // proprietario27
            // 
            this.proprietario27.Location = new System.Drawing.Point(625, 0);
            this.proprietario27.Name = "proprietario27";
            this.proprietario27.Size = new System.Drawing.Size(80, 10);
            this.proprietario27.TabIndex = 36;
            this.proprietario27.TabStop = false;
            this.proprietario27.Tag = "27";
            this.proprietario27.Visible = false;
            // 
            // proprietario26
            // 
            this.proprietario26.Location = new System.Drawing.Point(538, 0);
            this.proprietario26.Name = "proprietario26";
            this.proprietario26.Size = new System.Drawing.Size(88, 10);
            this.proprietario26.TabIndex = 35;
            this.proprietario26.TabStop = false;
            this.proprietario26.Tag = "26";
            this.proprietario26.Visible = false;
            // 
            // proprietario24
            // 
            this.proprietario24.Location = new System.Drawing.Point(379, -1);
            this.proprietario24.Name = "proprietario24";
            this.proprietario24.Size = new System.Drawing.Size(80, 10);
            this.proprietario24.TabIndex = 34;
            this.proprietario24.TabStop = false;
            this.proprietario24.Tag = "24";
            this.proprietario24.Visible = false;
            // 
            // proprietario23
            // 
            this.proprietario23.Location = new System.Drawing.Point(297, 0);
            this.proprietario23.Name = "proprietario23";
            this.proprietario23.Size = new System.Drawing.Size(80, 10);
            this.proprietario23.TabIndex = 33;
            this.proprietario23.TabStop = false;
            this.proprietario23.Tag = "23";
            this.proprietario23.Visible = false;
            // 
            // proprietario29
            // 
            this.proprietario29.Location = new System.Drawing.Point(787, -1);
            this.proprietario29.Name = "proprietario29";
            this.proprietario29.Size = new System.Drawing.Size(80, 10);
            this.proprietario29.TabIndex = 32;
            this.proprietario29.TabStop = false;
            this.proprietario29.Tag = "29";
            this.proprietario29.Visible = false;
            // 
            // proprietario3
            // 
            this.proprietario3.Location = new System.Drawing.Point(625, 984);
            this.proprietario3.Name = "proprietario3";
            this.proprietario3.Size = new System.Drawing.Size(80, 10);
            this.proprietario3.TabIndex = 31;
            this.proprietario3.TabStop = false;
            this.proprietario3.Tag = "3";
            this.proprietario3.Visible = false;
            // 
            // proprietario1
            // 
            this.proprietario1.Location = new System.Drawing.Point(787, 984);
            this.proprietario1.Name = "proprietario1";
            this.proprietario1.Size = new System.Drawing.Size(80, 10);
            this.proprietario1.TabIndex = 30;
            this.proprietario1.TabStop = false;
            this.proprietario1.Tag = "1";
            this.proprietario1.Visible = false;
            // 
            // pedina3
            // 
            this.pedina3.BackColor = System.Drawing.Color.Transparent;
            this.pedina3.Location = new System.Drawing.Point(878, 937);
            this.pedina3.Name = "pedina3";
            this.pedina3.Size = new System.Drawing.Size(30, 30);
            this.pedina3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pedina3.TabIndex = 29;
            this.pedina3.TabStop = false;
            this.pedina3.Visible = false;
            // 
            // pedina4
            // 
            this.pedina4.BackColor = System.Drawing.Color.Transparent;
            this.pedina4.Location = new System.Drawing.Point(909, 937);
            this.pedina4.Name = "pedina4";
            this.pedina4.Size = new System.Drawing.Size(30, 30);
            this.pedina4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pedina4.TabIndex = 28;
            this.pedina4.TabStop = false;
            this.pedina4.Visible = false;
            // 
            // pedina2
            // 
            this.pedina2.BackColor = System.Drawing.Color.Transparent;
            this.pedina2.Location = new System.Drawing.Point(909, 907);
            this.pedina2.Name = "pedina2";
            this.pedina2.Size = new System.Drawing.Size(30, 30);
            this.pedina2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pedina2.TabIndex = 27;
            this.pedina2.TabStop = false;
            this.pedina2.Visible = false;
            // 
            // pedina1
            // 
            this.pedina1.BackColor = System.Drawing.Color.Transparent;
            this.pedina1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pedina1.Location = new System.Drawing.Point(878, 907);
            this.pedina1.Name = "pedina1";
            this.pedina1.Size = new System.Drawing.Size(30, 30);
            this.pedina1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pedina1.TabIndex = 26;
            this.pedina1.TabStop = false;
            this.pedina1.Visible = false;
            // 
            // casella
            // 
            this.casella.BackColor = System.Drawing.Color.White;
            this.casella.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.casella.Location = new System.Drawing.Point(1128, 522);
            this.casella.Name = "casella";
            this.casella.Size = new System.Drawing.Size(343, 369);
            this.casella.TabIndex = 26;
            this.casella.TabStop = false;
            // 
            // cartaPescata
            // 
            this.cartaPescata.BackColor = System.Drawing.Color.SandyBrown;
            this.cartaPescata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartaPescata.Location = new System.Drawing.Point(1518, 632);
            this.cartaPescata.Name = "cartaPescata";
            this.cartaPescata.Size = new System.Drawing.Size(306, 154);
            this.cartaPescata.TabIndex = 10;
            this.cartaPescata.TabStop = false;
            this.cartaPescata.Visible = false;
            // 
            // TavoloGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1910, 1019);
            this.Controls.Add(this.descrizioneCarta);
            this.Controls.Add(this.nomeCarta);
            this.Controls.Add(this.esitoDado);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.colore3);
            this.Controls.Add(this.colore4);
            this.Controls.Add(this.colore2);
            this.Controls.Add(this.colore1);
            this.Controls.Add(this.dati4);
            this.Controls.Add(this.dati3);
            this.Controls.Add(this.dati2);
            this.Controls.Add(this.dati1);
            this.Controls.Add(this.nome4);
            this.Controls.Add(this.nome3);
            this.Controls.Add(this.nome2);
            this.Controls.Add(this.nome1);
            this.Controls.Add(this.timerGioco);
            this.Controls.Add(this.regole);
            this.Controls.Add(this.avviaPartita);
            this.Controls.Add(this.appunti);
            this.Controls.Add(this.libro);
            this.Controls.Add(this.turno);
            this.Controls.Add(this.dado);
            this.Controls.Add(this.infoGioco);
            this.Controls.Add(this.tabellone);
            this.Controls.Add(this.descrizioneCasella);
            this.Controls.Add(this.nomeCasella);
            this.Controls.Add(this.casella);
            this.Controls.Add(this.cartaPescata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TavoloGioco";
            this.Text = "UNIPOLY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.load);
            ((System.ComponentModel.ISupportInitialize)(this.esitoDado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colore3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colore4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colore1)).EndInit();
            this.tabellone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proprietario16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedina3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedina4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedina2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedina1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaPescata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infoGioco;
        private System.Windows.Forms.Button dado;
        private System.Windows.Forms.Button turno;
        private System.Windows.Forms.Button libro;
        private System.Windows.Forms.Button appunti;
        private System.Windows.Forms.Button avviaPartita;
        private System.Windows.Forms.Button regole;
        private System.Windows.Forms.Label timerGioco;
        private System.Windows.Forms.Timer veroTimer;
        private System.Windows.Forms.PictureBox cartaPescata;
        private System.Windows.Forms.TextBox nomeCasella;
        private System.Windows.Forms.TextBox descrizioneCasella;
        private System.Windows.Forms.Label nome1;
        private System.Windows.Forms.Label nome2;
        private System.Windows.Forms.Label nome3;
        private System.Windows.Forms.Label nome4;
        private System.Windows.Forms.TextBox dati1;
        private System.Windows.Forms.TextBox dati2;
        private System.Windows.Forms.TextBox dati3;
        private System.Windows.Forms.TextBox dati4;
        private System.Windows.Forms.TextBox descrizioneCarta;
        private System.Windows.Forms.TextBox nomeCarta;
        private System.Windows.Forms.PictureBox pedina1;
        private System.Windows.Forms.PictureBox pedina2;
        private System.Windows.Forms.Panel tabellone;
        private System.Windows.Forms.PictureBox pedina3;
        private System.Windows.Forms.PictureBox pedina4;
        private System.Windows.Forms.PictureBox casella;
        private System.Windows.Forms.PictureBox colore3;
        private System.Windows.Forms.PictureBox colore4;
        private System.Windows.Forms.PictureBox colore2;
        private System.Windows.Forms.PictureBox colore1;
        private System.Windows.Forms.Timer timerMovimento;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.PictureBox esitoDado;
        private System.Windows.Forms.PictureBox proprietario1;
        private System.Windows.Forms.PictureBox proprietario3;
        private System.Windows.Forms.PictureBox proprietario16;
        private System.Windows.Forms.PictureBox proprietario32;
        private System.Windows.Forms.PictureBox proprietario37;
        private System.Windows.Forms.PictureBox proprietario39;
        private System.Windows.Forms.PictureBox proprietario13;
        private System.Windows.Forms.PictureBox proprietario14;
        private System.Windows.Forms.PictureBox proprietario34;
        private System.Windows.Forms.PictureBox proprietario19;
        private System.Windows.Forms.PictureBox proprietario18;
        private System.Windows.Forms.PictureBox proprietario6;
        private System.Windows.Forms.PictureBox proprietario8;
        private System.Windows.Forms.PictureBox proprietario9;
        private System.Windows.Forms.PictureBox proprietario11;
        private System.Windows.Forms.PictureBox proprietario21;
        private System.Windows.Forms.PictureBox proprietario27;
        private System.Windows.Forms.PictureBox proprietario26;
        private System.Windows.Forms.PictureBox proprietario24;
        private System.Windows.Forms.PictureBox proprietario23;
        private System.Windows.Forms.PictureBox proprietario29;
    }
}