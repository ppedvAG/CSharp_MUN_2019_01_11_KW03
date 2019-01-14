using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //vgl auch PKW
    //Mittels des Interfaces IEnumerable kann eine Klasse dazu befähigt werden, die foreach-Schleife zu unterstützen. Dieses
    //Interface zwingt die implementierenden Klassen dazu die Methode GetEnumerator zu definieren, welche durch die Schleife
    //aufgerufen wird.
    public class Flugzeug : Fahrzeug, IBewegbar, IEnumerable
    {
        public List<string> Passagierliste { get; set; }
        public int MaxFlughöhe { get; set; }
        public int AnzahlRäder { get; set; }

        public Flugzeug(string name, int maxG, decimal preis, int maxFH) : base(name, maxG, preis)
        {
            this.MaxFlughöhe = maxFH;
            this.AnzahlRäder = 5;

            this.Passagierliste = new List<string>();
            Passagierliste.Add("Hugo");
            Passagierliste.Add("Anna");
            Passagierliste.Add("Otto");
            Passagierliste.Add("Maria");
        }

        public override string BeschreibeMich()
        {
            return "Das Flugzeug " + base.BeschreibeMich() +$" Es kann auf maximal {this.MaxFlughöhe}m aufsteigen.";
        }

        public override void Hupe()
        {
            Console.WriteLine("Beep");
        }

        public void BaueUnfall()
        {
            Console.WriteLine("Runter kommen wir immer");
        }

        //Durch IEnumerable verlangte Methode
        public IEnumerator GetEnumerator()
        {
            foreach (var item in this.Passagierliste)
            {
                //Mittels des YIELD-Stichworts gibt diese Methode in jedem Schleifendurchlauf einen Wert zurück, welcher in dem
                //End-Rückgabewert der Methode (eine Aufzählung) zusammengefasst werden
                yield return item; 
            }
        }
    }
}
