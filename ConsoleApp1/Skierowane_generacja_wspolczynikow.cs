namespace ConsoleApp1
{
    class Gen_Skierowane_zmienne
    {public bool zi;        public bool direction_variable_r_a ;
    public bool zp;        public bool sign_variable_sig;
    public   Gen_Skierowane_zmienne(L_prz_Skierowane o)
    {if (o.Poczatek > o.Koniec){direction_variable_r_a = false;}
    else{direction_variable_r_a = true;}
    if (o.Poczatek > 0 && o.Koniec > 0){sign_variable_sig = true;}
    if (o.Poczatek < 0 && o.Koniec < 0){sign_variable_sig = false;}
    if (o.Poczatek<=0 && o.Koniec>=0){zp = true;}else{zp = false;}
    if (o.Poczatek >= 0 && o.Koniec <= 0){zi = true;}else{zi = false;}}}
}
