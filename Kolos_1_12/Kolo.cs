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
                /* to nie tutaj - setter nie powinien wchodzic w petle - przynajmniej nie w takim przypadku (kiedy jest on tylko dostepem do zmiennej)
                while (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Nazwa nie moze być pusta!");
                    value = Console.ReadLine();
                }
                */
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Błędna wartość! wartość nie może być pusta");

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
                /* to nie tutaj - setter nie powinien wchodzic w petle - przynajmniej nie w takim przypadku (kiedy jest on tylko dostepem do zmiennej)
                while (value < 1 )
                {
                    Console.WriteLine("Promien nie moze byc mniejszy od 1!");
                    value = float.Parse(Console.ReadLine()); // <--- tu program się wysypie w momencie gdy wartość nie będzie liczbą
                }
                */
                if (value < 1)
                    throw new Exception("Błędna wartość! promien nie moze byc < 1");
                f_promien = value;
            }
        }


        public override void WprowadzDane()
        {

            Console.WriteLine("Podaj dane:");

            while (true)
            {
                Console.Write("	podaj nazwe: ");
                try
                {
                    Nazwa = Console.ReadLine();
                    break; // <-- jesli wszystko ok - przerywamy petle
                }
                catch (Exception e) // <-- przechwytujemy wyjatek z settera - wyswietlamy informacje - zerujemy
                {
                    Console.WriteLine("Błąd! {0}", e.Message);
                }

            }

            while (true)
            {
                Console.Write("	podaj promien: ");
                try
                {
                    Promien = float.Parse(Console.ReadLine());
                    break; // <-- jesli wszystko ok - przerywamy petle
                }
                catch (Exception e) // <-- przechwytujemy wyjatek z settera - wyswietlamy informacje - zerujemy
                                    // <-- przy okazji wyjatek "zlapie nam" blednie wprowadzona wartosc liczbowa (np. tekst)
                {
                    Console.WriteLine("Błąd! {0}", e.Message);
                }

            }

            Console.WriteLine("\nPodaj promien");

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
