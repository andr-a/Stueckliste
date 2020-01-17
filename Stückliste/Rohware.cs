using System;

namespace Stückliste
{
    internal class Rohware
    {
        private int artNr;
        private string bezeichnung;
        private string einheit;

        public Rohware(int artNr, string bezeichnung, string einheit)
        {
            this.ArtNr = artNr;
            this.Bezeichnung = bezeichnung;
            this.Einheit = einheit;
        }

        public int ArtNr { get => artNr; set => artNr = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public string Einheit { get => einheit; set => einheit = value; }

        public override string ToString() => String.Format("ArtNr: {0}, Bez: {1}, Einh: {2}", artNr.ToString(), bezeichnung, einheit);
    }
}