using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        //Ein DELEGATE ist eine Variable, in welcher man Funktionen mit einem gleichen Methodenkopf speichern kann. Eigene Delegate-Typen müssen
        ///vorher definiert werden.
        public delegate int MyDelegate(int a, int b);

        static void Main(string[] args)
        {
            //Zuweisung der Addiere()-Methode zur einer Variablen vom Typ MyDelegate
            MyDelegate delegateVariable = new MyDelegate(Addiere);

            //Ausführung der Delegate-Variablen
            Console.WriteLine(delegateVariable(12, 45));

            //Neuzuweisung der Delegate-Variablen (Kurzschreibweise)
            delegateVariable = Subtrahiere;

            Console.WriteLine(delegateVariable(12, 45));

            //Zuweisung einer zweiten Methode zur Delegate-Variablen. Die Ausführung erfolgt in der Reihenfolge der Zuweisung. Nur der Rückgabewert
            ///der zuletzt ausgeführten Methode wird an den Aufrufer zurückgegeben.
            delegateVariable += Addiere;

            //Bei Ausführung einer Delegate-Variablen werden alle referenzierten Methoden in der Reihenfolge ihrer Zuweisung ausgeführt.
            ///Nur die letzte Methode gibt einen Rückgabewert zurück
            Console.WriteLine(delegateVariable(12, 45));

            //Erstellen einer Liste der in der Variablen gespeicherten Methode
            var MethodenListe = delegateVariable.GetInvocationList().ToList();
            foreach (var item in MethodenListe)
            {
                Console.WriteLine(item.Method);
            }

            //Löschen einer Referenz aus der Variablen
            delegateVariable -= Subtrahiere;

            //FUNC<> / ACTION<> /PREDICATE<> sind die von C# vordefinierten Delegate-Typen
            Func<int, int, int> myFunc = Addiere;

            Console.WriteLine(myFunc(12, 78));

            FühreAus(Subtrahiere);


            List<string> städte = new List<string>() { "München", "Berlin", "Hamburg", "Köln", "Bonn" };

            //ANONYME METHODEN sind Methoden, welche nicht mit Kopf und Körper geschrieben stehen, sondern nur innerhalb von Delegate-Variablen
            ///existieren

            //Übergabe einer Methode an eine andere Methode
            var ergebnis = städte.FindAll(SucheStadtMitB);

            foreach (var item in ergebnis)
            {
                Console.WriteLine(item);
            }

            //Übergabe der Methode als anonyme Methode
            ergebnis = städte.FindAll(
                delegate (string stadt)
                {
                    return stadt.StartsWith("B");
                });

            //Übergabe der anonymen Methode in LAMBDA-Schreibweise
            ergebnis = städte.FindAll(stadt => stadt.StartsWith("B"));

            //weiteres Bsp der Lambda-Schreibweise (Methode empfängt zwei int und gibt deren Summe als String zurück)
            Func<int, int, string> funky = (x, y) => (x + y).ToString();

            Console.ReadKey();
        }

        public static bool SucheStadtMitB(string stadt)
        {
            return stadt.StartsWith("B");
        }

        //Funktion mit Delegate-Übergabeparameter
        public static void FühreAus(Func<int, int, int> funktion)
        {
            funktion(12, 78);
        }

        //Funktion mit Delegate-Rückgabewert
        public static Func<int, int, int> BaueFunc()
        {
            return Addiere;
        }

        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addiere");
            return a + b;
        }

        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtrahiere");
            return a - b;
        }
    }
}
