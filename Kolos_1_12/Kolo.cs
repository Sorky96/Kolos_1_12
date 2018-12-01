using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_1_12
{
    class Kolo : Ksztalt
    {
        private string s_nazwa;
        private float f_promien;

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

        public float Promien
        {
            get
            {
                return f_promien;
            }
            set
            {
                while (value < 1 )
                {
                    Console.WriteLine("Promien nie moze byc mniejszy od 1!");
                    value = float.Parse(Console.ReadLine());
                }
                f_promien = value;
            }
        }

        public override void WprowadzDane()
        {
            Console.WriteLine("Podaj dane: \n Podaj nazwe: ");
            Nazwa = Console.ReadLine();
            Console.WriteLine("\nPodaj promien");
            Promien = float.Parse(Console.ReadLine());
        }
        public override string WyswietlInformacje()
        {
            return $"{this} obwod = { ObliczObwod() } ";
        }

        public override float ObliczObwod()
        {
            return f_promien * 3;
        }
    }
}
