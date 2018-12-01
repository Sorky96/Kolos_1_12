using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_1_12
{
    class Program
    {
        static Ksztalt[,] ksztalty;

        static void Main(string[] args)
        {
            GetXAndY();
        }

        static public void GetXAndY()
        {
            int x = 0;
            int y = 0;

            
          
            x = GetX();
            
            y = GetY();

            
            CreateElements(x, y);
            Console.Read();
        }

        static public void CreateElements(int x, int y)
        {
            ksztalty = new Ksztalt[x,y];
           
            float newMaxVolume = 0;
            for (int yy=0;yy<y;++yy)
            {
                for (int xx=0;xx<x;xx++)
                {
                    if (yy % 2 == 0)
                    {
                        ksztalty[xx,yy] = new Kolo();
                    }
                    else
                    {
                        ksztalty[xx,yy] = new Prostokat();
                    }

                    ksztalty[xx,yy].WprowadzDane();
                    Console.WriteLine(ksztalty[xx,yy].WyswietlInformacje());

                    if (newMaxVolume < ksztalty[xx,yy].ObliczObwod())
                    {
                        newMaxVolume = ksztalty[xx, yy].ObliczObwod();
                    }
                        
                }
                
            }
            Console.WriteLine($"Maksymalny obwod to: {newMaxVolume}");
        }

        static public int GetY()
        {
            int y =0;

            Console.WriteLine("Podaj y");
            try
            {
                while (y < 1)
                {
                    y = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Podano zla wartosc");
                GetY();
            }
            finally
            { 
                
            }
            return y;
        }
        static public int GetX()
        {
            int x = 0;

            Console.WriteLine("Podaj x");
            
            try
            {
                
                while (x < 1)
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Podano zla wartosc");
                GetX();
            }
            
            return x;
        }
    }
}

        

