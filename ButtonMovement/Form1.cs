using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonMovement
{
    public partial class Form1 : Form
    {
        public int BtnLeftStart { get; set; }
        public int BtnRightStart { get; set; }

        public Form1()
        {
            InitializeComponent();

            //Speichern der Startpositionen der Buttons
            BtnLeftStart = btnLeft.Left;
            BtnRightStart = btnRight.Left;

            //Abonieren der drei Click-Methoden durch das Click-Event des dritten Buttons
            btnStart.Click += btnLeft_Click;
            btnStart.Click += btnRight_Click;
            btnStart.Click += btnStart_Click;
        }

        //Methoden wurden im Designer von den Click-Events der Buttons btnLeft und btnRight abboniert
        private void btnLeft_Click(object sender, EventArgs e)
        {
            //Bewegend des Buttons um 10 Pixel nach rechts
            btnLeft.Left += 10;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            //Bewegend des Buttons um 10 Pixel nach links
            btnRight.Left -= 10;
        }

        //Methode wird im Konstruktor durch das Click-Event des Buttons btnStart abboniert
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Test, ob Kollision vorhanden
            if (btnLeft.Right >= btnRight.Left)
                //Aufruf einer MessageBox, mit Abfrage, ob der Button 'OK' geklickt wurde
                if (MessageBox.Show("Buttons berühren sich. Zurücksetzen?", "BERÜHRUNG!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnLeft.Left = BtnLeftStart;
                    btnRight.Left = BtnRightStart;
                }
        }
    }
}
