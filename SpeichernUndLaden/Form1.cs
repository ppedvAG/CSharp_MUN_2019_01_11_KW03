using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeichernUndLaden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Click-Methoden der Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            SpeichereText(tbxMain.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            tbxMain.Text = LadeText();
        }

        //Methode zum Laden einer Textdatei
        private string LadeText()
        {
            //Zwischenspeichern des vorhandenen Inhalts der Testbox
            string text = tbxMain.Text;

            //Instanzierung eines Open-Dialogfensters 
            OpenFileDialog openDialog = new OpenFileDialog();

            //Einstellung diverser Parameter des Dialogfensters
            ///Standart-Dateiname
            openDialog.FileName = "gespeicherterText.txt";
            ///Standart-Ordner (kann z.B. ein Pfad als String sein oder (wie hier) ein Windows-'SpecialFolder')
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            ///Übergabe des Windows-Arbeitsplatzes als GUID
            openDialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
            ///Mögliche Dateiformate
            openDialog.Filter = "Textdatei|*.txt|Strings|*.string|Alle Dateien|*.*";

            //Öffnen des Dialogfensters und Überprüfung der Benutzerwahl
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //Deklarierung und Null-Initialisierung einer Streamreader-Variablen
                StreamReader reader = null;

                try
                {
                    //Instanzierung des Streamreaders mit Übergabe des vopm Benutzer gewählten Dateipfades
                    reader = new StreamReader(openDialog.FileName);

                    //Setzen des text-Strings auf einen leeren String (Alternative: text = String.Empty)
                    text = "";

                    //Schleife, welche über die geöffnete Datei läuft
                    while (!reader.EndOfStream)
                    {
                        //Hinzufügen der aktuell betrachteten Zeile in der Datei zu dem String
                        text += reader.ReadLine() + "\r\n";
                    }

                    //Erfolgsmeldung für User
                    MessageBox.Show("Laden erfolgreich");
                }
                catch
                {
                    //Misserfolgsmeldung für User bei Aufkommen einer Exception
                    MessageBox.Show("Laden fehlgeschlagen");
                }
                finally
                {
                    //Schließen der Datei innerhalb des Finally-Blocks, damit andere Programme auf die Datei zugreifen können (? = Nullprüfung des vorhergehenden Bezeichners)
                    reader?.Close();
                }
            }

            //Rückgabe des Strings
            return text;
        }

        //Methode zum Speichern einer Textdatei (vgl. auch LadeText())
        private void SpeichereText(string text)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "gespeicherterText.txt";
            saveDialog.InitialDirectory = "C:\\";
            saveDialog.Filter = "Textdatei|*.txt|Strings|*.string|Alle Dateien|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = null;

                try
                {
                    writer = new StreamWriter(saveDialog.FileName);

                    //StreamWriter schreibt einen String in die Datei
                    writer.WriteLine(text);

                    MessageBox.Show("Speichern erfolgreich");
                }
                catch
                {
                    MessageBox.Show("Speichern fehlgeschlagen");
                }
                finally
                {
                    //if (writer != null)
                    //    writer.Close();

                    writer?.Close();
                }
            }
        }

    }
}
