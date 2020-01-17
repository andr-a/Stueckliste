using System;

namespace Stückliste
{
    internal class Stueckliste
    {
        private int fertigId;
        private int rohId;
        private string fertigBez;
        private string rohBez;
        private double menge;
        private string einheit;

        public Stueckliste(int fertigId, string fertigBez, int rohId, string rohBez, double menge, string einheit)
        {
            FertigId = fertigId;
            FertigBez = fertigBez;
            RohId = rohId;
            RohBez = rohBez;
            Menge = menge;
            Einheit = einheit;
        }

        public int FertigId { get => fertigId; set => fertigId = value; }
        public int RohId { get => rohId; set => rohId = value; }
        public string FertigBez { get => fertigBez; set => fertigBez = value; }
        public string RohBez { get => rohBez; set => rohBez = value; }
        public double Menge { get => menge; set => menge = value; }
        public string Einheit { get => einheit; set => einheit = value; }

        public override string ToString() => String.Format("fID: {0}, fBez: {1}, rID: {2}, rBez: {3}, Menge: {4}, Einheit: {5}", fertigId.ToString(), fertigBez, rohId.ToString(), rohBez, menge.ToString(), einheit);

        public string FertigwareString() => String.Format("{0}, {1}, {2}", fertigId.ToString(), fertigBez, menge.ToString());
    }
}