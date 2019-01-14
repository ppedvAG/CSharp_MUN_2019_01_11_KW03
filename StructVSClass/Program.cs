using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVSClass
{
    //vgl. Modul 4 -> Fahrzeug
    public class KlassenPerson
    {
        public string name;
        public int alter;

        public KlassenPerson(string name)
        {
            this.name = name;
            this.alter = 25;
        }
    }

    //STRUCTS sind Klassenähnliche Konstrukte, welche nicht, wie Klassen, als Referenztypen behandelt werden, sondern ein Wertetyp sind. D.h
    //bei Übergabe eines Structs an eine Methode oder Variable wird eine Kopie dieses Objekts erstellt
    public struct StructPerson
    {
        public string name;
        public int alter;

        public StructPerson(string name)
        {
            this.name = name;
            this.alter = 25;
        }
    }


    class Program
    {
        static void Altern(KlassenPerson person)
        {
            person.alter++;
        }

        static void Altern(StructPerson person)
        {
            person.alter++;
        }

        //Mittels des REF-Stichworts können Wertetypen als Referenz an Methoden übergeben werden. D.h. die übergebene Speicherstelle selbst 
        ///wird manipuliert und nicht, wie normalerweise bei Wertetypen, eine Kopie des Werts.
        static void Altern(ref StructPerson person)
        {
            person.alter++;
        }

        static void Main(string[] args)
        {
            //Erstellung von Objekten
            StructPerson otto = new StructPerson("Otto");
            KlassenPerson anna = new KlassenPerson("Anna");

            //Ausgabe
            Console.WriteLine("Otto: " + otto.alter);
            Console.WriteLine("Anna: " + anna.alter);

            //Funktionsaufruf
            Altern(otto);
            Altern(anna);

            //Erneute Ausgabe: Nur das Klassenobjekt (Referenztyp) hat sich verändert
            Console.WriteLine("Otto: " + otto.alter);
            Console.WriteLine("Anna: " + anna.alter);

            //Übergabe des Wertetyps als Refernz mittels Ref-Stichwort
            Altern(ref otto);
            Console.WriteLine("Otto: " + otto.alter);

            Console.ReadKey();
        }
    }
}
