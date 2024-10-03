using System;

namespace FormesGeometriques2
{
    // Forme soyut sınıfı
    abstract class Forme
    {
        public abstract double Perimetre();
        public abstract double Aire();
    }

    // Cercle sınıfı, Forme'den türetilmiş
    class Cercle : Forme
    {
        public double Rayon { get; set; }

        public Cercle(double rayon)
        {
            Rayon = rayon;
        }

        public override double Perimetre()
        {
            return 2 * Math.PI * Rayon;
        }

        public override double Aire()
        {
            return Math.PI * Math.Pow(Rayon, 2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Daire nesnesi oluştur ve Perimetre ile Aire hesaplamalarını yap
            Cercle cercle = new Cercle(5);
            Console.WriteLine("Cercle Perimetre: " + cercle.Perimetre());
            Console.WriteLine("Cercle Aire: " + cercle.Aire());

            // Konsolun kapanmaması için
            Console.ReadLine();
        }
    }
}
