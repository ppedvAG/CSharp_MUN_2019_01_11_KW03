using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    //PARTIAL besagt, dass die Klasse hier nicht vollständig dargestellt wird. Der Rest befindet sich in einem
    ///anderen Dokument. Jedes Form erbt von der Klasse FORM, welche sämtliche Funktionen eines Fensters zur Verfügung stellt
    public partial class Form1 : Form
    {
        //Konstruktor des Forms (wird bei Aufruf des Fensters aufgerufen)
        public Form1()
        {
            //Mit dieser Methode werden die Designerseitig gebauten Elemente gezeichnet
            InitializeComponent();

            //EVENTs sind spezielle Delegates, welche nicht per Zuweisung überschrieben werden können. Methode müssen das Event per += abbonieren und
            ///per -= deabbonieren. Tritt ein Event auf (z.B. wenn ein Button geklickt wird) werden alle Methoden ausgeführt, welche dieses Event
            ///abboniert haben
            this.btnKlickMich.Click += btnKlickMich_Click2;

            lbxOutput.Items.Add("Hundert");

            label1.Text = "Hallo\nCiao\nMoin";
            textBox1.Text= "Hallo\r\nCiao\r\nMoin";

        }

        //Click-Methoden, der einzelnen Buttons
        private void btnKlickMich_Click(object sender, EventArgs e)
        {
            //Farbwechsel
            btnKlickMich.BackColor = Color.DarkOrange;
        }

        private void btnKlickMich_Click2(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSeaGreen;
        }

        private void öffneNeuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Öffnen eines weiteren Fensters
            Form1 neuesFenster = new Form1();

            neuesFenster.ShowDialog();
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fenster schließen
            this.Close();

            //Programm beenden
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox und Abfrage der Wahl des Benutzers
            if (MessageBox.Show("Hallo. Fühlst du dich gut?", "Wohlbefinden", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show("Aber nicht mehr lange...");
            }
            else
                MessageBox.Show("Das tut mir aber Leid...");
        }

        //Methode, welche von dem Timer ausgeführt wird
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnKlickMich.Left += 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Start/Stop des Timers
            if (timer1.Enabled)
                timer1.Stop();
            else
                timer1.Start();
        }
    }
}
