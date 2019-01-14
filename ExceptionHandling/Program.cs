using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    //Eine EXCEPTION wird von dem Programm geworfen, wenn dieses auf einen unerwarteten Zustand trifft. Jede Exception muss durch einen
    ///CATCH-Block abgefangen und bearbeitet werden. Ansonsten stürzt das Programm ab.

    //Eigene Exceptions müssen von der Klasse EXCEPTION erben, damit sie die Eigenschaften einer Exception übernehmen. 
    class MyException : Exception
    {
        public MyException() : base("Dies ist mein Fehler"){}
    }

    class Program
    {
        static void Main(string[] args)
        {
            //In einen TRY-Block werden die Code-Teile geschrieben, welche möglicherweise eine Exception werfen könnten. Wenn eine Exception
            ///geworfen wird, bricht dass Programm die Ausführung des TRY-Blocks ab und springt in den CATCH-Block.
            try
            {
                int a = int.Parse(Console.ReadLine());

                //Mit dem THROW-Befehl können manuell Exceptions geworfen werden
                throw new MyException();
            }
            //Jeder TRY-Block benötigt mindestens einen CATCH-Block um die geworfenen Exceptions abfangen zu können. Jeden CATCH-Block kann eine
            ///Exception-Art zugewiesen werden, welche in diesem Block bearbeitet werden soll. 
            catch (FormatException ex)
            {
                Console.WriteLine("Du musst eine Zahl eingeben. " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Deine Zahl darf nicht zu groß/klein sein. " + ex.Message);
            }
            //Werden mehrere CATCH-Blöcke angegeben, müssen diese in der Reihenfolge von speziell nach allgemein angeordnet sein.
            catch (Exception ex)
            {
                Console.WriteLine("Ein unbekannter Fehler ist aufgetreten. " + ex);
                //throw ex;
            }
            //Der FINALLY-Block wird ungeachtet der Prozesse, welche in den anderen Blöcke durchgeführt werden, immer ausgeführt
            finally
            {
                Console.WriteLine("Finally-Block");
            }

            //Nach der Ausführung des TRY-, bzw eines CATCH-Blocks macht das Programm im 'normalen' Code weiter
            Console.WriteLine("Try/Catch-Block vorbei");

            Console.ReadKey();

        }
    }
}
