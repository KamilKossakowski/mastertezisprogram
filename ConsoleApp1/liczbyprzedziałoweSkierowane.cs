namespace ConsoleApp1
{
    public class L_prz_Skierowane : Liczby_przedzialowe
    {
        public L_prz_Skierowane(double o,double t)
        {Poczatek = o;   Koniec = t;}
        public L_prz_Skierowane(Liczby_przedzialowe o)
        {Poczatek = o.Poczatek; Koniec = o.Koniec;}
        public static L_prz_Skierowane operator+(L_prz_Skierowane o,L_prz_Skierowane t)
        {return new L_prz_Skierowane(o.Poczatek + t.Poczatek, o.Koniec + t.Koniec);}
        public static L_prz_Skierowane operator +(L_prz_Skierowane o, double tu)
        {L_prz_Skierowane t = new L_prz_Skierowane(tu, tu);
            return new L_prz_Skierowane(o.Poczatek + t.Poczatek, o.Koniec + t.Koniec);}
        public static L_prz_Skierowane operator +( double ou,L_prz_Skierowane  t)
        { L_prz_Skierowane o = new L_prz_Skierowane(ou, ou);
            return new L_prz_Skierowane(o.Poczatek + t.Poczatek, o.Koniec + t.Koniec);}
        public static L_prz_Skierowane operator-(L_prz_Skierowane o,L_prz_Skierowane t)
        { return new L_prz_Skierowane(o.Poczatek - t.Poczatek, o.Koniec - t.Koniec); }
        public static L_prz_Skierowane operator -(L_prz_Skierowane o, double tu)
        {
            L_prz_Skierowane t = new L_prz_Skierowane(tu, tu);
            return new L_prz_Skierowane(o.Poczatek - t.Poczatek, o.Koniec - t.Koniec);
        }
        public static L_prz_Skierowane operator -( double ou,L_prz_Skierowane  t)
        {
            L_prz_Skierowane o = new L_prz_Skierowane(ou, ou);
            return new L_prz_Skierowane(o.Poczatek - t.Poczatek, o.Koniec - t.Koniec);
        }
        public static L_prz_Skierowane operator *(L_prz_Skierowane a, L_prz_Skierowane b)
        {double nowpoczatek= 0;            double nowkoniec = 0;
        Gen_Skierowane_zmienne a_zmiene = new Gen_Skierowane_zmienne(a);
        Gen_Skierowane_zmienne b_zmiene = new Gen_Skierowane_zmienne(b);
        if ((a_zmiene.zi==false && a_zmiene.zp==false)
        && (b_zmiene.zp==false && b_zmiene.zi==false))
        {if (a_zmiene.sign_variable_sig==true){if (b_zmiene.sign_variable_sig==true)
        {nowpoczatek = a.Poczatek * b.Poczatek; nowkoniec = a.Koniec * b.Koniec;}
        else{nowpoczatek = a.Koniec * b.Poczatek; nowkoniec = a.Koniec * b.Koniec;}
        }else{if (b_zmiene.sign_variable_sig==true){nowpoczatek = a.Poczatek * b.Koniec;
        nowkoniec = a.Koniec * b.Poczatek;}
        else{nowpoczatek = a.Koniec * b.Koniec;nowkoniec = a.Poczatek * b.Poczatek;}
        }}if((a_zmiene.zi==false && a_zmiene.zp==false)
        &&( b_zmiene.zp==true || b_zmiene.zi==true))
        {if (a_zmiene.sign_variable_sig == true){if (b_zmiene.direction_variable_r_a == true){
        nowpoczatek = a.Koniec * b.Poczatek; nowkoniec = a.Koniec * b.Koniec;}
        else{nowpoczatek = a.Poczatek * b.Poczatek; nowkoniec = a.Poczatek * b.Koniec;}
        }else{if (b_zmiene.direction_variable_r_a == true){
        nowpoczatek = a.Poczatek * b.Koniec; nowkoniec = a.Poczatek * b.Poczatek;}
        else{nowpoczatek = a.Koniec * b.Koniec; nowkoniec = a.Koniec * b.Poczatek;}} }
        if ((a_zmiene.zi == true || a_zmiene.zp == true) 
        && (b_zmiene.zp == false && b_zmiene.zi == false))
        {if (a_zmiene.direction_variable_r_a == true){ if (b_zmiene.sign_variable_sig == true){
        nowpoczatek = a.Poczatek * b.Koniec; nowkoniec = a.Koniec * b.Koniec;}
        else{nowpoczatek = a.Koniec * b.Poczatek; nowkoniec = a.Poczatek * b.Poczatek;}}
        else{if (b_zmiene.sign_variable_sig == true){nowpoczatek = a.Poczatek * b.Poczatek;
        nowkoniec = a.Koniec * b.Poczatek;} else
        { nowpoczatek = a.Koniec * b.Koniec; nowkoniec = a.Poczatek* b.Koniec;}}}
        if (a_zmiene.zp == true && b_zmiene.zp == true){
        double one = a.Poczatek * b.Koniec;   double two = a.Koniec * b.Poczatek;
        if (one > two){nowpoczatek = two;}else {nowpoczatek = one;}
        one = a.Poczatek * b.Poczatek; two = a.Koniec * b.Koniec;
        if (one > two){nowkoniec = one;}else{nowkoniec = two;}} 
        if (a_zmiene.zi == true && b_zmiene.zi == true){
        double one = a.Poczatek * b.Poczatek;double two = a.Koniec * b.Koniec;
        if (one > two){nowpoczatek = one;}else{nowpoczatek = two;}
        one = a.Poczatek * b.Koniec; two = a.Koniec * b.Poczatek;
        if (one > two){nowkoniec = two;}else{nowkoniec = one;}}
        return new L_prz_Skierowane(nowpoczatek, nowkoniec);}
        public static L_prz_Skierowane operator *(L_prz_Skierowane a, double tu)
        {
            L_prz_Skierowane b = new L_prz_Skierowane(tu, tu);
            double nowpoczatek = 0;
            double nowkoniec = 0;
            Gen_Skierowane_zmienne a_zmiene = new Gen_Skierowane_zmienne(a);
            Gen_Skierowane_zmienne b_zmiene = new Gen_Skierowane_zmienne(b);
            if ((a_zmiene.zi == false && a_zmiene.zp == false) && (b_zmiene.zp == false && b_zmiene.zi == false))
            {
                if (a_zmiene.sign_variable_sig == true)
                {
                    if (b_zmiene.sign_variable_sig == true)
                    {
                        nowpoczatek = a.Poczatek * b.Poczatek;
                        nowkoniec = a.Koniec * b.Koniec;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec * b.Poczatek;
                        nowkoniec = a.Koniec * b.Koniec;
                    }
                }
                else
                {
                    if (b_zmiene.sign_variable_sig == true)
                    {
                        nowpoczatek = a.Poczatek * b.Koniec;
                        nowkoniec = a.Koniec * b.Poczatek;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec * b.Koniec;
                        nowkoniec = a.Poczatek * b.Poczatek;
                    }
                }
            }
            if ((a_zmiene.zi == false && a_zmiene.zp == false) && (b_zmiene.zp == true || b_zmiene.zi == true))
            {
                if (a_zmiene.sign_variable_sig == true)
                {
                    if (b_zmiene.direction_variable_r_a == true)
                    {
                        nowpoczatek = a.Koniec * b.Poczatek;
                        nowkoniec = a.Koniec * b.Koniec;
                    }
                    else
                    {
                        nowpoczatek = a.Poczatek * b.Poczatek;
                        nowkoniec = a.Poczatek * b.Koniec;
                    }
                }
                else
                {
                    if (b_zmiene.direction_variable_r_a == true)
                    {
                        nowpoczatek = a.Poczatek * b.Koniec;
                        nowkoniec = a.Poczatek * b.Poczatek;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec * b.Koniec;
                        nowkoniec = a.Koniec * b.Poczatek;
                    }
                }
            }
            if ((a_zmiene.zi == true || a_zmiene.zp == true) && (b_zmiene.zp == false && b_zmiene.zi == false))
            {
                if (a_zmiene.direction_variable_r_a == true)
                {
                    if (b_zmiene.sign_variable_sig == true)
                    {
                        nowpoczatek = a.Poczatek * b.Koniec;
                        nowkoniec = a.Koniec * b.Koniec;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec * b.Poczatek;
                        nowkoniec = a.Poczatek * b.Poczatek;
                    }
                }
                else
                {
                    if (b_zmiene.sign_variable_sig == true)
                    {
                        nowpoczatek = a.Poczatek * b.Poczatek;
                        nowkoniec = a.Koniec * b.Poczatek;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec * b.Koniec;
                        nowkoniec = a.Poczatek * b.Koniec;
                    }
                }
            }
            if (a_zmiene.zp == true && b_zmiene.zp == true)
            {
                double one = a.Poczatek * b.Koniec;
                double two = a.Koniec * b.Poczatek;
                if (one > two)
                {
                    nowpoczatek = two;
                }
                else
                {
                    nowpoczatek = one;
                }
                one = a.Poczatek * b.Poczatek;
                two = a.Koniec * b.Koniec;
                if (one > two)
                {
                    nowkoniec = one;
                }
                else
                {
                    nowkoniec = two;
                }
            }
            if (a_zmiene.zi == true && b_zmiene.zi == true)
            {
                double one = a.Poczatek * b.Poczatek;
                double two = a.Koniec * b.Koniec;
                if (one > two)
                {
                    nowpoczatek = one;
                }
                else
                {
                    nowpoczatek = two;
                }
                one = a.Poczatek * b.Koniec;
                two = a.Koniec * b.Poczatek;
                if (one > two)
                {
                    nowkoniec = two;
                }
                else
                {
                    nowkoniec = one;
                }

            }

            return new L_prz_Skierowane(nowpoczatek, nowkoniec);
        }
        public static L_prz_Skierowane operator *( double tu,L_prz_Skierowane b)
        {
            L_prz_Skierowane a = new L_prz_Skierowane(tu, tu);
            double nowpoczatek = 0;
            double nowkoniec = 0;
            Gen_Skierowane_zmienne a_zmiene = new Gen_Skierowane_zmienne(a);
            Gen_Skierowane_zmienne b_zmiene = new Gen_Skierowane_zmienne(b);
            if ((a_zmiene.zi == false && a_zmiene.zp == false) && (b_zmiene.zp == false && b_zmiene.zi == false))
            {
                if (a_zmiene.sign_variable_sig == true)
                {
                    if (b_zmiene.sign_variable_sig == true)
                    {
                        nowpoczatek = a.Poczatek * b.Poczatek;
                        nowkoniec = a.Koniec * b.Koniec;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec * b.Poczatek;
                        nowkoniec = a.Koniec * b.Koniec;
                    }
                }
                else
                {
                    if (b_zmiene.sign_variable_sig == true)
                    {
                        nowpoczatek = a.Poczatek * b.Koniec;
                        nowkoniec = a.Koniec * b.Poczatek;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec * b.Koniec;
                        nowkoniec = a.Poczatek * b.Poczatek;
                    }
                }
            }
            if ((a_zmiene.zi == false && a_zmiene.zp == false) && (b_zmiene.zp == true || b_zmiene.zi == true))
            {
                if (a_zmiene.sign_variable_sig == true)
                {
                    if (b_zmiene.direction_variable_r_a == true)
                    {
                        nowpoczatek = a.Koniec * b.Poczatek;
                        nowkoniec = a.Koniec * b.Koniec;
                    }
                    else
                    {
                        nowpoczatek = a.Poczatek * b.Poczatek;
                        nowkoniec = a.Poczatek * b.Koniec;
                    }
                }
                else
                {
                    if (b_zmiene.direction_variable_r_a == true)
                    {
                        nowpoczatek = a.Poczatek * b.Koniec;
                        nowkoniec = a.Poczatek * b.Poczatek;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec * b.Koniec;
                        nowkoniec = a.Koniec * b.Poczatek;
                    }
                }
            }
            if ((a_zmiene.zi == true || a_zmiene.zp == true) && (b_zmiene.zp == false && b_zmiene.zi == false))
            {
                if (a_zmiene.direction_variable_r_a == true)
                {
                    if (b_zmiene.sign_variable_sig == true)
                    {
                        nowpoczatek = a.Poczatek * b.Koniec;
                        nowkoniec = a.Koniec * b.Koniec;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec * b.Poczatek;
                        nowkoniec = a.Poczatek * b.Poczatek;
                    }
                }
                else
                {
                    if (b_zmiene.sign_variable_sig == true)
                    {
                        nowpoczatek = a.Poczatek * b.Poczatek;
                        nowkoniec = a.Koniec * b.Poczatek;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec * b.Koniec;
                        nowkoniec = a.Poczatek * b.Koniec;
                    }
                }
            }
            if (a_zmiene.zp == true && b_zmiene.zp == true)
            {
                double one = a.Poczatek * b.Koniec;
                double two = a.Koniec * b.Poczatek;
                if (one > two)
                {
                    nowpoczatek = two;
                }
                else
                {
                    nowpoczatek = one;
                }
                one = a.Poczatek * b.Poczatek;
                two = a.Koniec * b.Koniec;
                if (one > two)
                {
                    nowkoniec = one;
                }
                else
                {
                    nowkoniec = two;
                }
            }
            if (a_zmiene.zi == true && b_zmiene.zi == true)
            {
                double one = a.Poczatek * b.Poczatek;
                double two = a.Koniec * b.Koniec;
                if (one > two)
                {
                    nowpoczatek = one;
                }
                else
                {
                    nowpoczatek = two;
                }
                one = a.Poczatek * b.Koniec;
                two = a.Koniec * b.Poczatek;
                if (one > two)
                {
                    nowkoniec = two;
                }
                else
                {
                    nowkoniec = one;
                }

            }

            return new L_prz_Skierowane(nowpoczatek, nowkoniec);
        }
        public static L_prz_Skierowane operator/(L_prz_Skierowane a,L_prz_Skierowane b)
        {double nowpoczatek = 0;      double nowkoniec = 0;
        Gen_Skierowane_zmienne a_zmiene = new Gen_Skierowane_zmienne(a);
        Gen_Skierowane_zmienne b_zmiene = new Gen_Skierowane_zmienne(b);
        if ((a_zmiene.zi == false && a_zmiene.zp == false)
         && (b_zmiene.zp == false && b_zmiene.zi == false))
        {if (a_zmiene.sign_variable_sig == true){if (b_zmiene.sign_variable_sig == true)
        {nowpoczatek = a.Poczatek/b.Poczatek;   nowkoniec = a.Koniec / b.Koniec;}
        else{nowpoczatek = a.Koniec/b.Poczatek; nowkoniec = a.Poczatek / b.Koniec;}}
        else{if (b_zmiene.sign_variable_sig == true){
        nowpoczatek = a.Poczatek / b.Koniec;  nowkoniec = a.Koniec / b.Poczatek;}
        else{nowpoczatek = a.Koniec / b.Koniec; nowkoniec = a.Poczatek / b.Poczatek;}}}
        if ((b_zmiene.zi == false && b_zmiene.zp == false)
         && (a_zmiene.zp == true || a_zmiene.zi == true))
        {if (b_zmiene.sign_variable_sig == true){nowpoczatek = a.Poczatek / b.Koniec;
        nowkoniec = a.Koniec / b.Koniec;}
        else{nowpoczatek = a.Koniec / b.Poczatek; nowkoniec = a.Poczatek / b.Poczatek;}}
        return new L_prz_Skierowane(nowpoczatek, nowkoniec);}
        

      
        public static L_prz_Skierowane operator /(L_prz_Skierowane a, double tu)
        {
            L_prz_Skierowane b = new L_prz_Skierowane(tu, tu);
            double nowpoczatek = 0;
            double nowkoniec = 0;
            Gen_Skierowane_zmienne a_zmiene = new Gen_Skierowane_zmienne(a);
            Gen_Skierowane_zmienne b_zmiene = new Gen_Skierowane_zmienne(b);
            if ((a_zmiene.zi == false && a_zmiene.zp == false) && (b_zmiene.zp == false && b_zmiene.zi == false))
            {
                if (a_zmiene.sign_variable_sig == true)
                {
                    if (b_zmiene.sign_variable_sig == true)
                    {
                        nowpoczatek = a.Poczatek / b.Poczatek;
                        nowkoniec = a.Koniec / b.Koniec;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec / b.Poczatek;
                        nowkoniec = a.Poczatek / b.Koniec;
                    }
                }
                else
                {
                    if (b_zmiene.sign_variable_sig == true)
                    {
                        nowpoczatek = a.Poczatek / b.Koniec;
                        nowkoniec = a.Koniec / b.Poczatek;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec / b.Koniec;
                        nowkoniec = a.Poczatek / b.Poczatek;
                    }
                }
            }
            if ((a_zmiene.zi == false && a_zmiene.zp == false) && (b_zmiene.zp == true || b_zmiene.zi == true))
            {
                if (b_zmiene.sign_variable_sig == true)
                {
                    nowpoczatek = a.Poczatek / b.Koniec;
                    nowkoniec = a.Koniec / b.Koniec;
                }
                else
                {
                    nowpoczatek = a.Koniec / b.Poczatek;
                    nowkoniec = a.Poczatek / b.Poczatek;
                }
            }
            return new L_prz_Skierowane(nowpoczatek, nowkoniec);
        }
        public static L_prz_Skierowane operator /(double tu,L_prz_Skierowane b)
        {
            L_prz_Skierowane a = new L_prz_Skierowane(tu, tu);
            double nowpoczatek = 0;
            double nowkoniec = 0;
            Gen_Skierowane_zmienne a_zmiene = new Gen_Skierowane_zmienne(a);
            Gen_Skierowane_zmienne b_zmiene = new Gen_Skierowane_zmienne(b);
            if ((a_zmiene.zi == false && a_zmiene.zp == false) && (b_zmiene.zp == false && b_zmiene.zi == false))
            {
                if (a_zmiene.sign_variable_sig == true)
                {
                    if (b_zmiene.sign_variable_sig == true)
                    {
                        nowpoczatek = a.Poczatek / b.Poczatek;
                        nowkoniec = a.Koniec / b.Koniec;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec / b.Poczatek;
                        nowkoniec = a.Poczatek / b.Koniec;
                    }
                }
                else
                {
                    if (b_zmiene.sign_variable_sig == true)
                    {
                        nowpoczatek = a.Poczatek / b.Koniec;
                        nowkoniec = a.Koniec / b.Poczatek;
                    }
                    else
                    {
                        nowpoczatek = a.Koniec / b.Koniec;
                        nowkoniec = a.Poczatek / b.Poczatek;
                    }
                }
            }
            if ((a_zmiene.zi == false && a_zmiene.zp == false) && (b_zmiene.zp == true || b_zmiene.zi == true))
            {
                if (b_zmiene.sign_variable_sig == true)
                {
                    nowpoczatek = a.Poczatek / b.Koniec;
                    nowkoniec = a.Koniec / b.Koniec;
                }
                else
                {
                    nowpoczatek = a.Koniec / b.Poczatek;
                    nowkoniec = a.Poczatek / b.Poczatek;
                }
            }
            return new L_prz_Skierowane(nowpoczatek, nowkoniec);
        }
    }
}
