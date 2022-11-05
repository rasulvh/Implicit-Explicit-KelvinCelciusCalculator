using System;

namespace CelciusKelvinCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Celcius celcius = new Celcius(36);

            Kelvin kelvin = celcius;

            Console.WriteLine(kelvin.KelvinDegree);
        }
    }

    public class Kelvin
    {
        public double KelvinDegree { get; set; }

        public Kelvin(double kelvinDegree)
        {
            KelvinDegree = kelvinDegree;
        }
    }

    public class Celcius
    {
        public double CelciusDegree { get; set; }

        public Celcius(double celciusDegree)
        {
            CelciusDegree = celciusDegree;
        }

        public static implicit operator Kelvin(Celcius celcius)
        {
            Kelvin kelvin = new Kelvin(celcius.CelciusDegree + 273);
            return kelvin;
        }
    }
}