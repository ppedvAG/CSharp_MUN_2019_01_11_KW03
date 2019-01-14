using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Fahrzeugpark;

namespace TesteFahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Modul04_OOP-Klassen

            //Fahrzeug fahrzeug1 = new Fahrzeug("BMW", 260);

            //Console.WriteLine(fahrzeug1.BeschreibeMich());

            //Fahrzeug fahrzeug2 = new Fahrzeug("VW", 240);

            //Console.WriteLine(fahrzeug2.BeschreibeMich());

            //fahrzeug2.MaxGeschwindigkeit = 310;
            //Console.WriteLine(fahrzeug2.BeschreibeMich());
            //Console.WriteLine(fahrzeug1.BeschreibeMich());

            #endregion

            #region Lab04_Fahrzeug-Klasse

            ////Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            ////Ausführen der BeschreibeMich()-Methode des Fahrzeugs und Ausgabe in der Konsole
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Diverse Methodenausführungen
            //fz1.StarteMotor();
            //fz1.Beschleunige(120);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.Beschleunige(300);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Neubelegung der Fahrzeug-Variablen
            //fz1 = new Fahrzeug("BMW", 250, 26000);
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Manueller Aufruf der Garbage-Collection
            //GC.Collect();

            #endregion

            #region Modul/Lab05_Vererbung
            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Console.WriteLine(pkw1);

            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.Schiffstreibstoff.Dampf);
            //Console.WriteLine(schiff1);

            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Console.WriteLine(flugzeug1);

            //Console.WriteLine(Fahrzeug.ZähleFahrzeuge());
            #endregion

            #region Modul06_Interfaces und Polymorphismus
            //PKW pkw1 = new PKW("BMW", 260, 36000, 5);

            //pkw1.AnzahlTüren = 3;

            //Fahrzeug fahrzeug1 = pkw1;

            //fahrzeug1.Hupe();

            //IBewegbar bewegbaresObjekt = pkw1;

            //bewegbaresObjekt.BaueUnfall();

            //RadAb(pkw1); 
            #endregion

            #region Lab06_IBeladbar

            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.Schiffstreibstoff.Dampf);

            //BeladeFahrzeuge(pkw1, flugzeug1);
            //BeladeFahrzeuge(flugzeug1, schiff1);
            //BeladeFahrzeuge(schiff1, pkw1);

            //Console.WriteLine("\n" + schiff1.BeschreibeMich());

            #endregion

            #region Modul07_Generische Listen

            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.Schiffstreibstoff.Dampf);

            //List<Fahrzeug> fzListe = new List<Fahrzeug>() { pkw1, schiff1 };

            //fzListe.Add(pkw1);
            //fzListe.Add(flugzeug1);
            //fzListe.Add(schiff1);

            //Console.WriteLine(fzListe.Count);

            //for (int i = 0; i < fzListe.Count; i++)
            //{
            //    Console.WriteLine(fzListe[i].Name);
            //} 

            #endregion

            #region Lab07_Zufällige Fahrzeuglisten
            ////Deklaration der benötigten Variablen und und Initialisierung mit Instanzen der benötigten Objekte
            //Random generator = new Random();
            //Queue<Fahrzeug> fzQueue = new Queue<Fahrzeug>();
            //Stack<Fahrzeug> fzStack = new Stack<Fahrzeug>();
            //Dictionary<Fahrzeug, Fahrzeug> fzDict = new Dictionary<Fahrzeug, Fahrzeug>();

            ////Deklaration und Initialisierung einer Variablen zur Bestimmung der Anzahl der Durchläufe 
            //int AnzahlFZs = 30;

            ////Schleife zur zufälligen Befüllung von Queue und Stack
            //for (int i = 0; i < AnzahlFZs; i++)
            //{
            //    //Würfeln einer zufälligen Zahl im Switch
            //    switch (generator.Next(1, 4))
            //    {
            //        //Erzeugung von Objekten je nach zufälliger Zahl
            //        case 1:
            //            fzQueue.Enqueue(new Flugzeug($"Boing_Q{i}", 800, 3600000, 9999));
            //            fzStack.Push(new Flugzeug($"Boing_S{i}", 800, 3600000, 9999));
            //            break;
            //        case 2:
            //            fzQueue.Enqueue(new Schiff($"Titanic_Q{i}", 40, 3500000, Schiff.Schiffstreibstoff.Dampf));
            //            fzStack.Push(new Schiff($"Titanic_S{i}", 40, 3500000, Schiff.Schiffstreibstoff.Dampf));
            //            break;
            //        case 3:
            //            fzQueue.Enqueue(PKW.ErzeugeZufälligenPKW($"_Q{i}"));
            //            fzStack.Push(PKW.ErzeugeZufälligenPKW($"_S{i}"));
            //            break;
            //    }
            //}

            ////Schleife zur Prüfung auf das Interface und Befüllung des Dictionaries
            //for (int i = 0; i < AnzahlFZs; i++)
            //{
            //    //Prüfung, ob das Interface vorhanden ist (mittels Peek(), da die Objekte noch benötigt werden)...
            //    if (fzQueue.Peek() is IBeladbar)
            //    {
            //        //...wenn ja, dann Cast in das Interface und Ausführung der Belade()-Methode (mittels Peek())...
            //        ((IBeladbar)fzQueue.Peek()).Belade(fzStack.Peek());
            //        //...sowie Hinzufügen zum Dictionary (mittels Pop()/Dequeue(), um beim nächsten Durchlauf andere Objekte an den Spitzen zu haben)
            //        fzDict.Add(fzQueue.Dequeue(), fzStack.Pop());
            //    }
            //    else
            //    {
            //        //... wenn nein, dann Löschung der obersten Objekte (mittels Pop()/Dequeue())
            //        fzQueue.Dequeue();
            //        fzStack.Pop();
            //    }
            //}

            ////Programmpause
            //Console.ReadKey();
            //Console.WriteLine("\n----------LADELISTE----------");

            ////Schleife zur Ausgabe des Dictionaries
            //foreach (var item in fzDict)
            //{
            //    Console.WriteLine($"'{item.Key.Name}' hat '{item.Value.Name}' geladen.");
            //}
            #endregion


            //Ausgabe eines durch eine Formatangabe und Kulturänderung manipulierten Strings
            Console.WriteLine(565656.05.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            //Änderung der Anzeige-Kultur der Applikation
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            //Bsp für eine Anwendung des IEnumerable-Interfaces (vgl. Flugzeug)
            Flugzeug zeug = new Flugzeug("Boing", 990, 36000000, 9990);
            foreach (var item in zeug)
            {
                Console.WriteLine(item);
            }

            //Bsp für eine Anwendung einer Erweiterungsmethode (s.u.)
            Random gene = new Random();
            gene.NextInclusive(12, 45);

            //Programmpause
            Console.ReadKey();
        }

        //Methode Lab06
        /// <summary>
        /// Hier kann ein Beschreibungstext eingegeben werden, welcher die unten stehende Methode bescheibt und in den
        /// IntelliSense-Boxen angezeigt wird
        /// </summary>
        /// <param name="fz1">Hier können Parameter-BEschreibungen eingegeben werden</param>
        /// <param name="fz2"></param>
        /// <exception cref="IndexOutOfRangeException">Auch mögliche Exceptions können hierdurch beschrieben werden</exception>
        public static void BeladeFahrzeuge(Fahrzeug fz1, Fahrzeug fz2)
        {
            if (fz1 is IBeladbar)
            {
                ((IBeladbar)fz1).Belade(fz2);
            }
            else if (fz2 is IBeladbar)
            {
                ((IBeladbar)fz2).Belade(fz1);
            }
            else
                Console.WriteLine("Keines der Fahrzeuge kann ein anderes Fahrzeug transportieren.");
        }

        //BSP-Methode Modul06
        static void RadAb(IBewegbar bewegbaresObjekt)
        {
            bewegbaresObjekt.AnzahlRäder--;

            if (bewegbaresObjekt is Flugzeug)
            {
                Flugzeug flugzeug1 = (Flugzeug)bewegbaresObjekt;
                flugzeug1 = bewegbaresObjekt as Flugzeug;

                Console.WriteLine(flugzeug1.Name + " hat auf " + flugzeug1.MaxFlughöhe + "m ein Rad verloren.");

                Console.WriteLine((bewegbaresObjekt as Flugzeug).Name);
            }
        }
    }

    public static class Hilfsklasse
    {
        //Mittels des THIS-Stichworts in der Parameterübergabe kann eine Methode als Erweiterungsmethode einer Klasse definiert
        //werden. Diese muss in einer statischen Klasse beschrieben werden und wird dann als Teil der zugeordneten Klasse betrachtet.
        public static int NextInclusive(this Random generator, int a, int b)
        {
            return generator.Next(a, b + 1);
        }
    }

}
