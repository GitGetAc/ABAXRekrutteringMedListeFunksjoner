namespace ABAXRekruttering
{
    internal class Fly : Kjøretøy
    {
        public string VingSpenn { get; set; }
        public string LasteEvne { get; set; }
        public string EgenVekt { get; set; }
        public string Flyklasse { get; set; }

        public Fly(string regnummer, string effekt, string vingSpenn, string lasteEvne, string egenVekt, string flyklasse) : base(regnummer, effekt)
        {
            VingSpenn = vingSpenn;
            LasteEvne = lasteEvne;
            EgenVekt = egenVekt;
            Flyklasse = flyklasse;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{RegNummer} {Effekt} {VingSpenn} {LasteEvne} {EgenVekt} {Flyklasse}");
        }

        public override void Kjør()
        {
            Console.WriteLine("Flyet begynte å fly!");
        }
    }
}
