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
            //Collection
            var objects = new [] { new Sphere { Radius = 4.2 }, 
                                   new Sphere { Radius = 6.3},
                                   new Sphere { Radius = 8.7},
                                   new Sphere { Radius = 3.2},
                                   new Sphere { Radius = 9.1}
            };

            //Testing Object 1.ToString()
            Console.WriteLine(objects[0]);
            //Testing Object 1 calcVol method
            Console.WriteLine(objects[0].calcVol(objects[1]));
            Console.WriteLine(objects[2]);
            //Testing Setter Method
            objects[2].Radius = 5.2;
            //Checking to see if the setter method worked
            Console.WriteLine(objects[2]);
            //Checking to see if the getter method works
            Console.WriteLine(objects[0].Radius);
            Console.WriteLine(objects[3].calcVol(objects[4]));
        }

    }
    
}