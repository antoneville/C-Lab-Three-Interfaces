using System;

namespace C_Lab_Three_Interfaces
{
    class Sphere : IHasVolume
    {
        //Field and matching read-write property for radius
        private double Radius { get; set; }

        //Appropriate Constructors
        public Sphere (double radius)
        {
            this.Radius = radius;
        }

        public Sphere()
        {
        }

        //calcVol interface implemented
        public double calcVol(Sphere obj)
        {
            double calc = Math.PI * obj.Radius * obj.Radius * obj.Radius;
            return calc;
        }

        public override string ToString()
        {
            return String.Format("The Sphere has a Radius of: {0} \n",Radius);
        }

        static void Main()
        {
            var objects = new [] { new Sphere { Radius = 4.2 }, 
                                   new Sphere { Radius = 6.3},
            };

            Console.WriteLine(objects[0]);
            Console.WriteLine(objects[0].calcVol(objects[1]));
        }

    }

}