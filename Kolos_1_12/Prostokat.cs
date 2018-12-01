using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_1_12
{
    class Prostokat : Ksztalt
    {
        private string s_nazwa;
        private float f_boka;
        private float f_bokb;

        public string Nazwa
        {
            get
            {
                return s_nazwa;
            }
            set
            {
                while (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Nazwa nie moze być pusta!");
                    value = Console.ReadLine();
                }

                s_nazwa = value;
            }
        }
        public float BokA
        {
            get
            {
                return f_boka;
            }
            set
            {
                while (value < 1)
                {
                    Console.WriteLine("Bok nie moze byc mniejszy od 0!");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                f_boka = value;
            }
        }

        public float BokB
        {
            get
            {
                return f_bokb;
            }
            set
            {
                while (value < 1)
                {
                    Console.WriteLine("Bok nie moze byc mniejszy od 0!");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                f_bokb = value;
            }
        }

        public override void WprowadzDane()
        {
            Console.WriteLine("Podaj dane: \n Podaj nazwe: ");
            Nazwa = Console.ReadLine();
            Console.WriteLine("\nPodaj Bok a \n");
            BokA = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Bok b \n");
            BokB = float.Parse(Console.ReadLine());
        }

        public override string WyswietlInformacje()
        {
            return $"{this} obwod = { ObliczObwod() }  ";
        }

        public override float ObliczObwod()
        {
            return f_boka * f_bokb;
        }
    }
}
