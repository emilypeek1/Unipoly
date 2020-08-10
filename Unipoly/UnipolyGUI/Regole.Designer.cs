namespace UnipolyGUI
{
    partial class Regole
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
            this.immagineRegole = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.immagineRegole)).BeginInit();
            this.SuspendLayout();
            // 
            // immagineRegole
            // 
            this.immagineRegole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.immagineRegole.Image = global::UnipolyGUI.Properties.Resources.RegolePic;
            this.immagineRegole.InitialImage = global::UnipolyGUI.Properties.Resources.RegolePic;
            this.immagineRegole.Location = new System.Drawing.Point(2, 0);
            this.immagineRegole.Name = "immagineRegole";
            this.immagineRegole.Size = new System.Drawing.Size(1144, 625);
            this.immagineRegole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.immagineRegole.TabIndex = 0;
            this.immagineRegole.TabStop = false;
            // 
            // Regole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 627);
            this.Controls.Add(this.immagineRegole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Regole";
            this.Text = "Regole";
            ((System.ComponentModel.ISupportInitialize)(this.immagineRegole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox immagineRegole;
    }
}