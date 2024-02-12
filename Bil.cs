namespace ABAXRekruttering
{
    internal class Bil : Kjøretøy
    {
        public Bil(string regnummer, string effekt, string maksfart, string farge, string type) : base(regnummer, effekt)
        {
            MaksFart = maksfart;
            Farge = farge;
            Type = type;
        }

        public string MaksFart { get; set; }
        public string Farge { get; set; }
        public string Type { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"{RegNummer} {Effekt} {MaksFart} {Farge} {Type}");
        }

        public override void Kjør()
        {
            base.Kjør();
        }

    }
}
