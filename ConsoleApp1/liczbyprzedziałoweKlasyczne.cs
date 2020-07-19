namespace ConsoleApp1
{
    public class L_prz_Klasyczne : Liczby_przedzialowe
    {
        public L_prz_Klasyczne(double o, double t)
        {if (o < t) { Poczatek = o; Koniec = t; }
            else{Poczatek = t;  Koniec =o ;} }
        public L_prz_Klasyczne(Liczby_przedzialowe o)
        {Poczatek = o.Poczatek;    Koniec = o.Koniec;}
        public static L_prz_Klasyczne operator +(L_prz_Klasyczne o,L_prz_Klasyczne t)
        {return new L_prz_Klasyczne(o.Poczatek + t.Poczatek, o.Koniec + t.Koniec);}
        public static L_prz_Klasyczne operator +(L_prz_Klasyczne o, double tu)
        {L_prz_Klasyczne t = new L_prz_Klasyczne(tu, tu);
        return new L_prz_Klasyczne(o.Poczatek + t.Poczatek, o.Koniec + t.Koniec);}
        public static L_prz_Klasyczne operator +(double ou, L_prz_Klasyczne t)
        {L_prz_Klasyczne o = new L_prz_Klasyczne(ou, ou);
        return new L_prz_Klasyczne(o.Poczatek + t.Poczatek, o.Koniec + t.Koniec);}
        public static L_prz_Klasyczne operator -(L_prz_Klasyczne o, L_prz_Klasyczne t)
        {return new L_prz_Klasyczne(o.Poczatek - t.Koniec, o.Koniec - t.Poczatek);}
        public static L_prz_Klasyczne operator -(L_prz_Klasyczne o, double tu)
        {
            L_prz_Klasyczne t = new L_prz_Klasyczne(tu, tu);
            return new L_prz_Klasyczne(o.Poczatek - t.Koniec, o.Koniec - t.Poczatek);
        }
        public static L_prz_Klasyczne operator -( double ou, L_prz_Klasyczne t)
        {
            L_prz_Klasyczne o = new L_prz_Klasyczne(ou, ou);
            return new L_prz_Klasyczne(o.Poczatek - t.Koniec, o.Koniec - t.Poczatek);
        }
        public static L_prz_Klasyczne operator*(L_prz_Klasyczne o,L_prz_Klasyczne t)
        {double minpoczatek;           double maxkoniec;
        minpoczatek = o.Poczatek * t.Poczatek;     maxkoniec = minpoczatek;
        double tymczasowa = o.Poczatek * t.Koniec;
        if (minpoczatek > tymczasowa){minpoczatek = tymczasowa;}
        else{maxkoniec = tymczasowa;}
        tymczasowa = o.Koniec * t.Poczatek;
        if (minpoczatek > tymczasowa){minpoczatek = tymczasowa;}
        if (maxkoniec < tymczasowa){maxkoniec = tymczasowa;}
        tymczasowa = o.Koniec * t.Koniec;
        if (minpoczatek > tymczasowa){minpoczatek = tymczasowa;}
        if (maxkoniec < tymczasowa){maxkoniec = tymczasowa;}
        return new L_prz_Klasyczne(minpoczatek, maxkoniec);}
        public static L_prz_Klasyczne operator *(L_prz_Klasyczne o, double tu)
        {
            L_prz_Klasyczne t = new L_prz_Klasyczne(tu, tu);
            double minpoczatek;
            double maxkoniec;
            minpoczatek = o.Poczatek * t.Poczatek;
            maxkoniec = minpoczatek;
            double tymczasowa = o.Poczatek * t.Koniec;
            if (minpoczatek > tymczasowa)
            {
                minpoczatek = tymczasowa;
            }
            else
            {
                maxkoniec = tymczasowa;
            }
            tymczasowa = o.Koniec * t.Poczatek;
            if (minpoczatek > tymczasowa)
            {
                minpoczatek = tymczasowa;
            }
            if (maxkoniec < tymczasowa)
            {
                maxkoniec = tymczasowa;
            }
            tymczasowa = o.Koniec * t.Koniec;
            if (minpoczatek > tymczasowa)
            {
                minpoczatek = tymczasowa;
            }
            if (maxkoniec < tymczasowa)
            {
                maxkoniec = tymczasowa;
            }
            return new L_prz_Klasyczne(minpoczatek, maxkoniec);
        }
        public static L_prz_Klasyczne operator *(double ou,L_prz_Klasyczne  t)
        {
            L_prz_Klasyczne o = new L_prz_Klasyczne(ou, ou);
            double minpoczatek;
            double maxkoniec;
            minpoczatek = o.Poczatek * t.Poczatek;
            maxkoniec = minpoczatek;
            double tymczasowa = o.Poczatek * t.Koniec;
            if (minpoczatek > tymczasowa)
            {
                minpoczatek = tymczasowa;
            }
            else
            {
                maxkoniec = tymczasowa;
            }
            tymczasowa = o.Koniec * t.Poczatek;
            if (minpoczatek > tymczasowa)
            {
                minpoczatek = tymczasowa;
            }
            if (maxkoniec < tymczasowa)
            {
                maxkoniec = tymczasowa;
            }
            tymczasowa = o.Koniec * t.Koniec;
            if (minpoczatek > tymczasowa)
            {
                minpoczatek = tymczasowa;
            }
            if (maxkoniec < tymczasowa)
            {
                maxkoniec = tymczasowa;
            }
            return new L_prz_Klasyczne(minpoczatek, maxkoniec);
        }
        public static L_prz_Klasyczne operator /(L_prz_Klasyczne o, L_prz_Klasyczne t)
        {double minpoczatek;      double maxkoniec;
            minpoczatek = o.Poczatek / t.Poczatek;     maxkoniec = minpoczatek;
            double tymczasowa = o.Poczatek / t.Koniec;
            if (minpoczatek > tymczasowa){minpoczatek = tymczasowa;}
            else{maxkoniec = tymczasowa;}
            tymczasowa = o.Koniec / t.Poczatek;
            if (minpoczatek > tymczasowa){ minpoczatek = tymczasowa;}
            if (maxkoniec < tymczasowa) { maxkoniec = tymczasowa;}
            tymczasowa = o.Koniec / t.Koniec;
            if (minpoczatek > tymczasowa){minpoczatek = tymczasowa;}
            if (maxkoniec < tymczasowa) { maxkoniec = tymczasowa;}
            return new L_prz_Klasyczne(minpoczatek, maxkoniec);
        }
        public static L_prz_Klasyczne operator /(L_prz_Klasyczne o, double tu)
        {
            L_prz_Klasyczne t = new L_prz_Klasyczne(tu, tu);
            double minpoczatek;
            double maxkoniec;
            minpoczatek = o.Poczatek / t.Poczatek;
            maxkoniec = minpoczatek;
            double tymczasowa = o.Poczatek / t.Koniec;
            if (minpoczatek > tymczasowa)
            {
                minpoczatek = tymczasowa;
            }
            else
            {
                maxkoniec = tymczasowa;
            }
            tymczasowa = o.Koniec / t.Poczatek;
            if (minpoczatek > tymczasowa)
            {
                minpoczatek = tymczasowa;
            }
            if (maxkoniec < tymczasowa)
            {
                maxkoniec = tymczasowa;
            }
            tymczasowa = o.Koniec / t.Koniec;
            if (minpoczatek > tymczasowa)
            {
                minpoczatek = tymczasowa;
            }
            if (maxkoniec < tymczasowa)
            {
                maxkoniec = tymczasowa;
            }
            return new L_prz_Klasyczne(minpoczatek, maxkoniec);
        }
        public static L_prz_Klasyczne operator /(double  ou,L_prz_Klasyczne t)
        {
            L_prz_Klasyczne o = new L_prz_Klasyczne(ou, ou);
            double minpoczatek;
            double maxkoniec;
            minpoczatek = o.Poczatek / t.Poczatek;
            maxkoniec = minpoczatek;
            double tymczasowa = o.Poczatek / t.Koniec;
            if (minpoczatek > tymczasowa)
            {
                minpoczatek = tymczasowa;
            }
            else
            {
                maxkoniec = tymczasowa;
            }
            tymczasowa = o.Koniec / t.Poczatek;
            if (minpoczatek > tymczasowa)
            {
                minpoczatek = tymczasowa;
            }
            if (maxkoniec < tymczasowa)
            {
                maxkoniec = tymczasowa;
            }
            tymczasowa = o.Koniec / t.Koniec;
            if (minpoczatek > tymczasowa)
            {
                minpoczatek = tymczasowa;
            }
            if (maxkoniec < tymczasowa)
            {
                maxkoniec = tymczasowa;
            }
            return new L_prz_Klasyczne(minpoczatek, maxkoniec);
        }
    }
}
