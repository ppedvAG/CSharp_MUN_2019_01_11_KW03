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
using Fahrzeugpark;
//Json ist eine Serialisierungs-Methode, welche über den NuGet-Marketspace installiert und dem Projekt hinzugefügt wurde
using Newtonsoft.Json;

namespace Serialisierung
{
    public partial class Form1 : Form
    {
        public List<Fahrzeug> FzListe { get; set; }
        public Random Generator { get; set; }

        public Form1()
        {
            InitializeComponent();

            //Initialisierung der Properties
            FzListe = new List<Fahrzeug>();
            Generator = new Random();

            //Bsp für Darstellung eines Unicode-Zeichens
            label1.Text = "\u0058";
        }

        //Click-Methoden der Buttons
        private void btnNew_Click(object sender, EventArgs e)
        {
            ErstelleNeuesFZ();
            ZeigeFZ();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            LöscheFZ();
            ZeigeFZ();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SpeichereFZ();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LadeFZ();
            ZeigeFZ();
        }

        //Methode zum Laden einer 'Fahrzeug'-Datei (vgl. auch SpeichernUndLaden.Form1.LadeText())
        private void LadeFZ()
        {
            StreamReader reader = null;

            try
            {
                reader = new StreamReader("fahrzeuge.txt");

                //Mittels der TypeNameHandling-Property des JsonSerializerSettings-Objekts kann dem Serialisierer aufgegeben werden, dass er den expliziten Objekt-Type der 
                //zu ladenden/speichernden Objekte mit abspeichert
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Objects;

                while (!reader.EndOfStream)
                {
                    //Lesen einer Textzeile aus der Datei
                    string fzString = reader.ReadLine();
                    //Umwandlung der Textzeile in ein Fahrzeug (Beachte die Übergabe des Settings-Objekts)
                    Fahrzeug fz = JsonConvert.DeserializeObject<Fahrzeug>(fzString, settings);

                    //Hinzufügen des Fahrzeugs zur Liste
                    FzListe.Add(fz);
                }

                MessageBox.Show("Laden erfolgreich");

            }
            catch (Exception)
            {
                MessageBox.Show("Laden fehlgeschlagen");
            }
            finally
            {
                reader?.Close();
            }
        }

        //Methode zum Abspeichern von Fahrzeugen (vgl. auch LadeFZ)
        private void SpeichereFZ()
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter("fahrzeuge.txt");

                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Objects;

                //Iteration über die ListBox)
                for (int i = lbxFahrzeuge.Items.Count - 1; i >= 0; i--)
                {
                    //Überprüfung, ob der aktuelle Eintrag vom Benutzer ausgewählt wurde)
                    if (lbxFahrzeuge.GetSelected(i))
                    {
                        string fzString = JsonConvert.SerializeObject(FzListe[i], settings);
                        writer.WriteLine(fzString);
                    }
                }

                MessageBox.Show("Speichern erfolgreich");
            }
            catch (Exception)
            {
                MessageBox.Show("Speichern fehlgeschlagen");
            }
            finally
            {
                writer?.Close();
            }
        }

        //Methode zum Löschen von Fahrzeugen
        private void LöscheFZ()
        {
            for (int i = lbxFahrzeuge.Items.Count - 1; i >= 0; i--)
            {
                if (lbxFahrzeuge.GetSelected(i))
                    FzListe.Remove(FzListe[i]);
            }
        }

        //Methode zur zufälligen Erstellung von Fahrzeugen
        private void ErstelleNeuesFZ()
        {
            switch (Generator.Next(1, 4))
            {
                case 1:
                    FzListe.Add(new Flugzeug($"Boing", 800, 3600000, 9999));
                    break;
                case 2:
                    FzListe.Add(new Schiff($"Titanic", 40, 3500000, Schiff.Schiffstreibstoff.Dampf));
                    break;
                case 3:
                    FzListe.Add(PKW.ErzeugeZufälligenPKW());
                    break;
            }
        }

        //Methode zur Darstellung der Fahrzeuge aus der Liste in der ListBox der GUI
        private void ZeigeFZ()
        {
            lbxFahrzeuge.Items.Clear();

            foreach (var item in FzListe)
            {
                lbxFahrzeuge.Items.Add(item.Name);
            }
        }

    }
}
