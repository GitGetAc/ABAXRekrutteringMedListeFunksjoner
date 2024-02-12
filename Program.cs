using System.Collections.Generic;

namespace ABAXRekruttering
{
    internal class Program
    {
        static void Main()
        {

            Alapprogram();

            List<Kjøretøy> list = new List<Kjøretøy>();

            list.Add(new Bil("NF654321", "150kw", "195km/t", "blå", "lett"));
            list.Add(new Båt("ABC123", "100kw", "30knop", "500kg"));
            list.Add(new Fly("LN1234", "1000kw", "30m", "2T", "10T", "Jetfly"));
            list.Add(new Bil("NF123456", "174kw", "200km/t", "grønn", "lett"));
            

            ListMethodsHeader();

            ListeAlleElementene(list);

            ListMethodsHeader();

            SorterEtterRegnummer(list);


            Console.WriteLine("Hvilket kjøretøy vil du slette fra listen?");
            int i = Convert.ToInt16(Console.ReadLine());
            RemoveElementFraListe(list, i);

            ListMethodsHeader();
            SorterEtterEffekt(list);

            ListMethodsHeader();
            ReverseRegnummer(list);



        }

        static void ReverseRegnummer(List<Kjøretøy> list)
        {
            Console.WriteLine("ExperimentalFunction - Reverse text in Regnummer");

            foreach (var item in list)
            {
                char[] charArray = item.RegNummer.ToCharArray();
                Array.Reverse(charArray);
                item.RegNummer = new string(charArray);
                
            }
            ListeAlleElementene(list);
        }

        static void SorterEtterRegnummer(List<Kjøretøy> list)
        {
            Console.WriteLine("Sortert liste etter Regnummer-----------");
            list.Sort((x,y) => x.RegNummer.CompareTo(y.RegNummer));
            ListeAlleElementene(list);
        }

        static void SorterEtterEffekt(List<Kjøretøy> list)
        {
            Console.WriteLine("Sortert liste etter Effekt-----------");
            list.Sort((x, y) => x.Effekt.CompareTo(y.Effekt));
            ListeAlleElementene(list);
        }

        static void RemoveElementFraListe(List <Kjøretøy> list, int i)
        {
            list.Remove(list[i-1]);
            ListeAlleElementene(list);
        }

        static void ListMethodsHeader()
        {
            Console.WriteLine("\n------------------------------------------\n");
        }

        static void ListeAlleElementene(List <Kjøretøy> list)
        {
            foreach (var item in list)
            {
                item.PrintInfo();
            }
        }

        static void Alapprogram()
        {
            Bil bil1 = new("NF123456", "174kw", "200km/t", "grønn", "lett");
            Bil bil2 = new("NF654321", "150kw", "195km/t", "blå", "lett");

            Fly fly = new("LN1234", "1000kw", "30m", "2T", "10T", "Jetfly");

            Båt båt = new("ABC123", "100kw", "30knop", "500kg");

            Console.Write("Bil1: "); bil1.PrintInfo();
            Console.Write("Bil2: "); bil2.PrintInfo();

            Console.Write("Fly: "); fly.PrintInfo();

            Console.Write("Båt: "); båt.PrintInfo();


            Console.WriteLine("Vi har bedt flyet å fly, og bil1 til å starte å kjøre");
            fly.Kjør();

            bil1.Kjør();

            Console.WriteLine("Sammenligning av de to bilene (bi1 == bli2?)\n");

            if (bil1.RegNummer == bil2.RegNummer && bil1.Effekt == bil2.Effekt && bil1.MaksFart == bil2.MaksFart && bil1.Farge == bil2.Farge && bil1.Type == bil2.Type)
            {
                Console.WriteLine("Bilene er like!");
            }
            else { Console.WriteLine("Bilene er ikke like."); }
        }
    }

    
    
    
    
    
    
    
    
    
    /*Skriv et konsoll-program i C# som kan:

        1. Printe informasjon om en en bil 1 med            //reg. nr NF123456, 147kw effekt, maksfart 200km/t, grønn farge av typen lett kjøretøy. 
        2. Printe informasjon om en annen bil (bil 2) med   //reg. nr NF654321, 150kw effekt, maksfart 195km/t, blå farge og av typen lett kjøretøy

        3. Sammenlikne de to bilene over for å sjekke om de er det samme kjøretøyet

        4. Printe informasjon om et fly med kjennetegn LN1234, 1000kw effekt, 30m vingespenn, 2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly

        5. Konsollprogrammet skal be flyet om å fly og printe dette i konsollet.

        6. Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet
    
        7. Printe informasjon om en                         // båt med kjennetegn ABC123, 100kw effekt, maksfart på 30knop, 500kg bruttotonnasje.

    Løsninger:
    Hoved-løsningsforslag: github.com/GetAcademy/AbaxSimple
    Alternativt mer komplekst løsningsforslag: github.com/GetAcademy/AbaxTest*/
}
