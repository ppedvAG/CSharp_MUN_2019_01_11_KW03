using System;

namespace UnitTestFahrzeuge
{
    //Durch den Unit-Test (vgl. UnitTest2.cs) mittels BisualStudio automatisch generierte Klasse
    internal class LKW
    {
        private string v1;
        private int v2;
        private int v3;
        private int v4;

        public object MaxGeschwindigkeit { get; internal set; }
        public object AktGeschwindigkeit { get; internal set; }

        public LKW(string v1, int v2, int v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        internal void StarteMotor()
        {
            throw new NotImplementedException();
        }

        internal void Beschleunige(int v)
        {
            throw new NotImplementedException();
        }
    }
}