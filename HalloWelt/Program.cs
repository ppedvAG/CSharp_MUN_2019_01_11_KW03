//Mittels der USING-Anweisungen kann ein vereinfachter Zugriff auf Programm-Externe Klassen ermöglicht werden. Es muss nun nicht mehr der
///vollständige Pfad angegeben werden, sondern es reicht der Klassenbezeichner
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NAMESPACE: Die Umgebung unseres aktuellen Programms: Alles innerhalb des Namespaces gehört zu dem Programm
namespace HalloWelt
{
    //Die PROGRAM-Klasse beinhaltet den Einstiegspunkt des Programms und muss in jedem C#-Programm vorhanden sein
    class Program
    {
        //Die MAIN()-Methode ist der Einstiegspunkt jedes C#-Programms: Hier beginnt das Programm IMMER
        static void Main(string[] args)
        {
            //Deklaration einer Integer-Variable 
            int alter;
            //Initialisierung der Integer-Variablen
            alter = 29;
            //Gleichzeitige Deklaration und Initialisierung einer String-Variablen
            string wohnort = "Berlin";

            ///Einfügen dynamischer Inhalte in Strings
            //'traditionell'
            Console.WriteLine("Mein Name ist Klaas. Ich bin " + alter + " Jahre alt und ich wohne in " + wohnort + ".");
            //Index
            Console.WriteLine("Mein Name ist Klaas. Ich bin {0} Jahre alt und ich wohne in {1}.", alter, wohnort);
            //$-Operator
            Console.WriteLine($"Mein Name ist Klaas. Ich bin {alter} Jahre alt und ich wohne in {wohnort}.");

            //String-Formatierung mittels Escape-Sequenzen
            Console.WriteLine("Dies ist ein Zeilenumbruch \nund dies ein vertikaler \tTabulator. Dies ist ein Backslash: \\");

            //String-Formatierung mittels VerbaTim-String (einleitung mittels @/Escape-Sequenzen sind nicht möglich, 
            ///dynamische Inhalte mittels $ schon)
            Console.WriteLine(@"Dies ist ein Zeilenumbruch 
und dies ein vertikaler     Tabulator.");

            //Eingabe eines Strings durch den Benutzer und Abspeichern in einer String-Variablen
            Console.WriteLine("Bitte gib einen String ein: ");
            string eingabe = Console.ReadLine();
            Console.WriteLine(eingabe);

            //Eingabe eines Strings, Umwandlung in einen Integer (Parse()-Funktion) und Abspeichern in einer Integer-Variablen
            Console.WriteLine("Bitte gib eine Zahl ein: ");
            int eingabeInt = int.Parse(Console.ReadLine());
            Console.WriteLine(eingabeInt * 2);

            //Programmpause
            Console.ReadKey();

        }
    }
}
