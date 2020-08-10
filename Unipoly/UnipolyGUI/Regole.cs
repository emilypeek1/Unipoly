using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnipolyGUI
{
    //classe di tipo Form per visualizzare le regole
    public partial class Regole : Form
    {
        //costruttore
        public Regole()
        {
            InitializeComponent();
            try
            {
                this.immagineRegole.Image = (Image)Properties.Resources.ResourceManager.GetObject("RegolePic");
            }catch
            {
                MessageBox.Show("Immagine non caricata correttamente");
                this.Close();
            }
        }

        //proprietà per accedere all'immagine delle regole
        public PictureBox Istruzioni
        {
            get { return this.immagineRegole; }
        }
    }//end classe
}
