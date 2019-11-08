using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoIntefaceCSharp
{
    interface IAuto
    {
        void Gyorsulas();
        double GetSebesseg();
    }

    class Porsche : IAuto
    {
        private double sebesseg;

        public Porsche(double sebesseg)
        {
            this.sebesseg = sebesseg;
        }

        public double GetSebesseg()
        {
            return this.sebesseg;
        }

        public void Gyorsulas()
        {
            this.sebesseg += 10;
        }
    }
    class Tesla : IAuto
    {
        private double sebesseg;

        public Tesla(double sebesseg)
        {
            this.sebesseg = new Random().Next(0, 60);
        }

        public double GetSebesseg()
        {
            return this.sebesseg;
        }

        public void Gyorsulas()
        {
            this.sebesseg += new Random().Next(5, 15);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<IAuto> list = new List<IAuto>();
            //asdas

            list.Add(new Porsche(123));
            list.Add(new Tesla(214));
            list.Add(new Porsche(124));
            list.Add(new Tesla(135));
            list.Add(new Porsche(125));
            list.Add(new Tesla(104));
            list.Add(new Porsche(126));
            list.Add(new Tesla(213));
            list.Add(new Porsche(127));
            list.Add(new Tesla(234));

            foreach (var item in list)
            {
                item.Gyorsulas();
                Console.WriteLine(item.GetSebesseg());
            }

            Console.WriteLine("\nleggyorsabb: " + list.Max(m => m.GetSebesseg()));

            Console.ReadKey();
        }
    }
}
