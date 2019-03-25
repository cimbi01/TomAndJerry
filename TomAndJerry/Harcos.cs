using System;

namespace TomAndJerry
{
    internal class Harcos
    {
        #region Private Fields

        private static int MINTAMADAS = 0, MAXTAMADAS = 50;
        private readonly Random rnd = new Random();
        private readonly int TAMADMAX, VEDMAX;

        #endregion Private Fields

        #region Public Constructors

        public Harcos(int _eletero, string _nev = "Harcos")
        {
            Nev = _nev;
            Eletero = _eletero;
            this.TAMADMAX = this.rnd.Next(MINTAMADAS, MAXTAMADAS + 1);
            this.VEDMAX = this.rnd.Next(MINTAMADAS, MAXTAMADAS + 1);
        }

        #endregion Public Constructors

        #region Public Properties

        public int Eletero { get; private set; }
        public string Nev { get; private set; } = "Harcos";

        #endregion Public Properties

        #region Public Methods

        public int Tamad()
        {
            return this.rnd.Next(MINTAMADAS, MAXTAMADAS + 1);
        }
        public void Vedekezes(int tamadas)
        {
            int vedekezes = this.rnd.Next(MINTAMADAS, MAXTAMADAS);
            vedekezes -= tamadas;
            if (vedekezes < 0)
            {
                Eletero += vedekezes;
            }
        }

        #endregion Public Methods
    }
}
