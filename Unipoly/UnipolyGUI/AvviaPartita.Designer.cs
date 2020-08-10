 namespace UnipolyGUI
{
    partial class AvviaPartita 
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
            this.Conferma = new System.Windows.Forms.Button();
            this.nome1 = new System.Windows.Forms.TextBox();
            this.nome2 = new System.Windows.Forms.TextBox();
            this.nome3 = new System.Windows.Forms.TextBox();
            this.nome4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ruolo1 = new System.Windows.Forms.ComboBox();
            this.ruolo4 = new System.Windows.Forms.ComboBox();
            this.ruolo3 = new System.Windows.Forms.ComboBox();
            this.ruolo2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Conferma
            // 
            this.Conferma.BackColor = System.Drawing.Color.White;
            this.Conferma.Location = new System.Drawing.Point(365, 163);
            this.Conferma.Name = "Conferma";
            this.Conferma.Size = new System.Drawing.Size(145, 39);
            this.Conferma.TabIndex = 0;
            this.Conferma.Text = "Conferma";
            this.Conferma.UseVisualStyleBackColor = false;
            this.Conferma.Click += new System.EventHandler(this.Conferma_Click);
            // 
            // nome1
            // 
            this.nome1.Location = new System.Drawing.Point(135, 68);
            this.nome1.Name = "nome1";
            this.nome1.Size = new System.Drawing.Size(121, 26);
            this.nome1.TabIndex = 1;
            // 
            // nome2
            // 
            this.nome2.Location = new System.Drawing.Point(302, 68);
            this.nome2.Name = "nome2";
            this.nome2.Size = new System.Drawing.Size(121, 26);
            this.nome2.TabIndex = 2;
            // 
            // nome3
            // 
            this.nome3.Location = new System.Drawing.Point(468, 68);
            this.nome3.Name = "nome3";
            this.nome3.Size = new System.Drawing.Size(121, 26);
            this.nome3.TabIndex = 3;
            // 
            // nome4
            // 
            this.nome4.Location = new System.Drawing.Point(636, 68);
            this.nome4.Name = "nome4";
            this.nome4.Size = new System.Drawing.Size(121, 26);
            this.nome4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giocatore 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giocatore 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giocatore 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giocatore 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ruolo";
            // 
            // ruolo1
            // 
            this.ruolo1.FormattingEnabled = true;
            this.ruolo1.Items.AddRange(new object[] {
            "fuori sede",
            "in sede",
            "pendolare",
            "straniero"});
            this.ruolo1.Location = new System.Drawing.Point(135, 100);
            this.ruolo1.Name = "ruolo1";
            this.ruolo1.Size = new System.Drawing.Size(121, 28);
            this.ruolo1.TabIndex = 11;
            // 
            // ruolo4
            // 
            this.ruolo4.FormattingEnabled = true;
            this.ruolo4.Items.AddRange(new object[] {
            "fuori sede",
            "in sede",
            "pendolare",
            "straniero"});
            this.ruolo4.Location = new System.Drawing.Point(636, 100);
            this.ruolo4.Name = "ruolo4";
            this.ruolo4.Size = new System.Drawing.Size(121, 28);
            this.ruolo4.TabIndex = 12;
            // 
            // ruolo3
            // 
            this.ruolo3.FormattingEnabled = true;
            this.ruolo3.Items.AddRange(new object[] {
            "fuori sede",
            "in sede",
            "pendolare",
            "straniero"});
            this.ruolo3.Location = new System.Drawing.Point(468, 100);
            this.ruolo3.Name = "ruolo3";
            this.ruolo3.Size = new System.Drawing.Size(121, 28);
            this.ruolo3.TabIndex = 13;
            // 
            // ruolo2
            // 
            this.ruolo2.FormattingEnabled = true;
            this.ruolo2.Items.AddRange(new object[] {
            "fuori sede",
            "in sede",
            "pendolare",
            "straniero"});
            this.ruolo2.Location = new System.Drawing.Point(302, 100);
            this.ruolo2.Name = "ruolo2";
            this.ruolo2.Size = new System.Drawing.Size(121, 28);
            this.ruolo2.TabIndex = 14;
            // 
            // AvviaPartita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(829, 249);
            this.Controls.Add(this.ruolo2);
            this.Controls.Add(this.ruolo3);
            this.Controls.Add(this.ruolo4);
            this.Controls.Add(this.ruolo1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nome4);
            this.Controls.Add(this.nome3);
            this.Controls.Add(this.nome2);
            this.Controls.Add(this.nome1);
            this.Controls.Add(this.Conferma);
            this.Name = "AvviaPartita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvviaPartita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Conferma;
        private System.Windows.Forms.TextBox nome1;
        private System.Windows.Forms.TextBox nome2;
        private System.Windows.Forms.TextBox nome3;
        private System.Windows.Forms.TextBox nome4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ruolo1;
        private System.Windows.Forms.ComboBox ruolo4;
        private System.Windows.Forms.ComboBox ruolo3;
        private System.Windows.Forms.ComboBox ruolo2;
    }
}