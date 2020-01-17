using System;
using System.Collections.Generic;

namespace Stückliste
{
    internal class Fertigware
    {
        private int artNr;
        private string bezeichnung;
        private string bild;
        private double preis;
        private Dictionary<Rohware, double> rohwaren;

        public Fertigware(int artNr, string bezeichnung, string bild, double preis)
        {
            ArtNr = artNr;
            Bezeichnung = bezeichnung;
            Bild = bild;
            Preis = preis;
        }

        public Fertigware(int artNr, string bezeichnung, string bild, double preis, Dictionary<Rohware, double> rohwaren)
        {
            this.ArtNr = artNr;
            this.Bezeichnung = bezeichnung;
            this.Bild = bild;
            this.Preis = preis;
            this.Rohwaren = rohwaren;
        }

        public int ArtNr { get => artNr; set => artNr = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public string Bild { get => bild; set => bild = value; }
        public double Preis { get => preis; set => preis = value; }
        internal Dictionary<Rohware, double> Rohwaren { get => rohwaren; set => rohwaren = value; }

        public override string ToString() => String.Format("ArtNr: {0}, Bez: {1}, Preis: {2}", artNr.ToString(), bezeichnung, preis.ToString());
    }
}