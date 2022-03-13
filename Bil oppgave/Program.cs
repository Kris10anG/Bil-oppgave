using System;

namespace Bil_oppgave
{
    static class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("LJ123");
            var car2 = new Car("LA444");

            int Distance = 10000;

            while (car.distanceDriven < Distance && car2.distanceDriven < Distance)
            {
                car.DriveCar();
                car2.DriveCar();
            }
            //Du skal lage en konsollapp med en bil som skal kjøre 1000m.Bilen har en start - hastighet på 10m / s(en iterasjon i en løkke er et sekund)
            //.Bilen skal øke farten med 10m / s frem til den har kjørt 500m, også skal den senke farten med 10m /
            //s igjen frem til den når minimumshastigheten sin på 10m / s.Når bilen har kommet seg til slutt-målet printes det ut til skjermen at bilen er fremme og har parkert.

        }
    }
}
