namespace ABAXRekruttering
{
    internal abstract class Kjøretøy
    {

        public string RegNummer { get; set; }
        public string Effekt { get; set; }

        public Kjøretøy(string regnummer, string effekt)
        {
            RegNummer = regnummer;
            Effekt = effekt;
        }

        public abstract void PrintInfo();

        public virtual void Kjør()
        {
            Console.WriteLine("Kjøretøyet begynte å kjøre!");
        }
    }
}
