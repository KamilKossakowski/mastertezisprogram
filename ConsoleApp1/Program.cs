using System;

namespace ConsoleApp1
{
    public class funkcja_wzor
    {
        public L_prz_Skierowane funkcjaskierowana(L_prz_Skierowane x)
        { L_prz_Skierowane y = new L_prz_Skierowane(0, 0);
            //y = 0.7 * x + 1.1
            y = -1 * (x - 2) * (x - 2) + 3 * x + 5
            //y = (5) / (5 * x * x * x * x * x - 6 * x + 13)
            //y = (78 * x * x) / (5 * x * x - 6 * x + 13)
            //y = (-2 * (x - 1.9) * (x - 1.9) * (x - 1.9) * (x - 1.9) * (x - 1.9)) / (5 * x * x * x * x + 13)
                ; return y; }
        public L_prz_Klasyczne funkcjaKlasyczne(L_prz_Klasyczne x)
        { L_prz_Klasyczne y = new L_prz_Klasyczne(0, 0);
            //y = 0.7 * x + 1.1
            y = -1 * (x - 2) * (x - 2) + 3 * x + 5
            //y = (5) / (5 * x * x * x * x * x - 6 * x + 13)
            //y = (78 * x * x) / (5 * x * x - 6 * x + 13)
            //y = (-2 * (x - 1.9) * (x - 1.9) * (x - 1.9) * (x - 1.9) * (x - 1.9)) / (5 * x * x * x * x + 13)
            ; return y; }
    }

class Program
    {
        static void Main(string[] args)
            {
            int i=0;
            //double a = 1; double b = 6; int N = 1880;
            double a = 1; double b = 6; int N = 1880;
            //double a = -1.26; double b = 2; int N = 1880;
            //double a = -2.5; double b = 10; int N = 1880;
            //double a = -13; double b = 20; int N = 1880;
            //double promienprzedzialu = 0;

            double promienprzedzialu = 0.0000005;
            //double promienprzedzialu = 0.000005;
            //double promienprzedzialu = 0.0005;
            Funkcje_Poddane_całkowaniu licz = new Funkcje_Poddane_całkowaniu(a, b, 2, promienprzedzialu);
            L_prz_Skierowane _Skierowane = new L_prz_Skierowane(0, 0);
            L_prz_Klasyczne _Klasyczne = new L_prz_Klasyczne(0, 0);

            _Skierowane= licz.Funkcja_Skierowane();            _Klasyczne= licz.Funkcja_Klasyczne();
            Console.Out.WriteLine(";klasyczne;;skierowane");
            Console.Out.WriteLine("N;dolny kraniec;górny kraniec;dolny kraniec;górny kraniec");
            for (i=2 ; i < N+1; i++) {
                licz = new Funkcje_Poddane_całkowaniu(a, b, i, promienprzedzialu);
                _Skierowane = licz.Funkcja_Skierowane(); 
                _Klasyczne = licz.Funkcja_Klasyczne();
                Console.Out.WriteLine(""+ i+";"+ _Klasyczne.Poczatek+ ";"+ _Klasyczne.Koniec+ ";"+ _Skierowane.Poczatek+";"+ _Skierowane.Koniec);
            }

            
            Console.ReadLine();
        }
    }
}
