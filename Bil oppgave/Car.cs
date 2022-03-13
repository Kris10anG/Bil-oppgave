using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_oppgave
{
    public class Car
    {
        public int Distance = 10000;
        public int HalfDistance = 5000;
        public int TopSpeed = 10;
        public Random RandomSpeed = new Random();
        public int distanceDriven = 0;
        public string RegNr { get; set; }

        public Car(string regnr)
        {
            RegNr = regnr;
        }

     

        public void DriveCar()
        {
            //var distanceDriven = 0;
            //for (int TopSpeed = 10; TopSpeed < Distance; TopSpeed += 10)
            //    while (distanceDriven <= Distance)
            //    {
                    TopSpeed += RandomSpeed.Next(60, 201);
                distanceDriven += TopSpeed;
                //CarSlowDown(distanceDriven);
                Console.WriteLine(RegNr + " Hastigheten er " + TopSpeed);
                Console.WriteLine(RegNr + " distansen kjørt er " + distanceDriven);
                PrintFinish(distanceDriven);
            //}
        }

        //public void CarSlowDown(int distanceDriven)
        //{
        //    if (distanceDriven >= HalfDistance)
        //    {
        //        if (TopSpeed >= 30)
        //        {
        //            TopSpeed -= 20;
        //        }
        //    }
        //}

        public void PrintFinish(int distanceDriven)
        {
            if (distanceDriven == Distance)
            {
                Console.WriteLine("Løpet er ferdig");
            }
        }
    }
}
