using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Funkcje_Poddane_całkowaniu
    {
    L_prz_Klasyczne[] wyniki_Klasyczne;    L_prz_Skierowane[] wyniki_Skierowane;
    L_prz_Klasyczne sumKlasyczne;        L_prz_Skierowane sum_Skierowane;
    int N;        double czesc_pierwsza_rownania;        double czesc_druga_rownania;
    L_prz_Klasyczne[,] l_Prz_Klasyczne;        L_prz_Skierowane[,] l_Prz_Skierowane;
        
    public Funkcje_Poddane_całkowaniu(double a,double b,int liczbadzien,double promienprzedzialu)
    {czesc_druga_rownania = (b + a)/2;         czesc_pierwsza_rownania = (b - a)/2;
    l_Prz_Skierowane= kwadratura_generic.kwadratura_in_Skierowane(liczbadzien, promienprzedzialu);
    l_Prz_Klasyczne = kwadratura_generic.kwadratura_in_Klasyczne(liczbadzien, promienprzedzialu);
    N = liczbadzien;}
        public L_prz_Skierowane Funkcja_Skierowane(){wyniki_Skierowane = new L_prz_Skierowane[N];
        L_prz_Skierowane czescpier=new L_prz_Skierowane(czesc_pierwsza_rownania,czesc_pierwsza_rownania);
        L_prz_Skierowane czescdruga=new L_prz_Skierowane(czesc_druga_rownania,czesc_druga_rownania);
        sum_Skierowane = new L_prz_Skierowane(0, 0);
        funkcja_wzor funkcjaSkierowane= new funkcja_wzor();
        for (int i = 0; i < N; i++){
        wyniki_Skierowane[i]=funkcjaSkierowane.funkcjaskierowana(czescpier*l_Prz_Skierowane[i,0]
        +czescdruga);        wyniki_Skierowane[i]=wyniki_Skierowane[i] * l_Prz_Skierowane[i, 1];
        sum_Skierowane += wyniki_Skierowane[i];}       sum_Skierowane *= czescpier;
        return sum_Skierowane;}
        public L_prz_Klasyczne Funkcja_Klasyczne(){wyniki_Klasyczne = new L_prz_Klasyczne[N];
        L_prz_Klasyczne czescpier = new L_prz_Klasyczne(czesc_pierwsza_rownania, czesc_pierwsza_rownania);
        L_prz_Klasyczne czescdruga = new L_prz_Klasyczne(czesc_druga_rownania, czesc_druga_rownania);
        funkcja_wzor funkcjaKlasyczne=new funkcja_wzor();
        sumKlasyczne = new L_prz_Klasyczne(0, 0);
        for (int i = 0; i < N; i++){  
            wyniki_Klasyczne[i]=funkcjaKlasyczne.funkcjaKlasyczne(czescpier*l_Prz_Klasyczne[i,0]+czescdruga);
            wyniki_Klasyczne[i]=wyniki_Klasyczne[i] * l_Prz_Klasyczne[i, 1];
            sumKlasyczne+=wyniki_Klasyczne[i];}
        sumKlasyczne*=czescpier;
        return sumKlasyczne;}
        
    }
}
