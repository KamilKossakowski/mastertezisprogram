using System;

namespace ConsoleApp1
{
    class kwadratura_generic
    {
        static int ile_zer(double promien)
        {int ile=0; if(promien!=0){  while(promien<1){promien*=10;ile++;}} return ile;   }

        static double[,] kwadratura(int Ni)
        {double EPS = 3.0e-10; double z1, z, xm, xl, pp, p3, p2, p1;
        double[,] xi = new double[Ni,2];         int m, jj, ii;  
        double an=-1.0,bn=1.0;     m=(Ni+1)/2; xm=0.5*(bn + an); 
        xl=0.5*(bn - an);     for (ii = 1; ii <= m; ii++){
        z=Math.Cos(Math.PI*(ii-0.25)/(Ni+0.5)); 
        do{p1=1.0; p2=0.0;     for (jj=1;jj<=Ni;jj++){p3=p2; p2=p1;
        p1=((2.0*jj-1.0)*z*p2-(jj-1.0)*p3)/jj;}
        pp=Ni*(z*p1-p2)/(z*z-1.0);         z1=z; z=z1-p1/pp;} 
        while(Math.Abs(z-z1)>EPS);        xi[ii-1,0]=xm-xl*z; 
        xi[Ni+1-(ii+1),0]=xm+xl*z;   xi[ii-1,1]=2.0*xl/((1.0-z*z)*pp*pp);
        xi[Ni+1-(ii+1),1]=xi[ii-1,1];}        return xi;}
        
        static public L_prz_Skierowane[,] kwadratura_in_Skierowane(int N,
        double promienprzedzialu)
        {L_prz_Skierowane[,] kwadratura_in_B= new L_prz_Skierowane[N,2];
        double[,] to_jest = kwadratura(N);
        for (int i=0; i<N; i++){         int poprzecinek;
        double czy_weszlo = to_jest[i,0] + promienprzedzialu;
        double czy_weszlo_dol= to_jest[i, 0] - promienprzedzialu; 
        if (promienprzedzialu != 0) {poprzecinek=ile_zer(promienprzedzialu);
        if (czy_weszlo >= 0) { 
        czy_weszlo=Math.Round(czy_weszlo,poprzecinek,MidpointRounding.AwayFromZero);}
        else {czy_weszlo=Math.Round(czy_weszlo,poprzecinek,MidpointRounding.ToEven);}
        if (czy_weszlo_dol >= 0) {
        czy_weszlo_dol=Math.Round(czy_weszlo_dol,poprzecinek,MidpointRounding.ToEven);}
        else {
        czy_weszlo_dol=Math.Round(czy_weszlo_dol,poprzecinek,MidpointRounding.AwayFromZero);}
        if (czy_weszlo>1){czy_weszlo=1;}      if (czy_weszlo_dol<-1){czy_weszlo_dol=-1;}}
        kwadratura_in_B[i,0] = new L_prz_Skierowane(czy_weszlo_dol, czy_weszlo);
        czy_weszlo=to_jest[i,1]+promienprzedzialu; czy_weszlo_dol=to_jest[i,1]-promienprzedzialu;
        if (promienprzedzialu != 0){poprzecinek = ile_zer(promienprzedzialu);
        if (czy_weszlo >= 0) {
         czy_weszlo = Math.Round(czy_weszlo, poprzecinek, MidpointRounding.AwayFromZero); }
        else { czy_weszlo = Math.Round(czy_weszlo, poprzecinek, MidpointRounding.ToEven); }
        if (czy_weszlo_dol >= 0) {
        czy_weszlo_dol = Math.Round(czy_weszlo_dol, poprzecinek, MidpointRounding.ToEven); }
        else {
        czy_weszlo_dol=Math.Round(czy_weszlo_dol,poprzecinek,MidpointRounding.AwayFromZero); }
        if (czy_weszlo>1){czy_weszlo=1;}      if(czy_weszlo_dol<-1){czy_weszlo_dol=-1;}}
        kwadratura_in_B[i, 1]=new L_prz_Skierowane(czy_weszlo_dol, czy_weszlo);}
         return kwadratura_in_B;}
        
        
        
        static public L_prz_Klasyczne[,] kwadratura_in_Klasyczne(int N, double promienprzedzialu)
        {L_prz_Klasyczne[,] kwadratura_in_S = new L_prz_Klasyczne[N, 2]; double[,] to_jest= kwadratura(N);
        for(int i = 0; i < N; i++){     double czy_weszlo = to_jest[i, 0] + promienprzedzialu;
        double czy_weszlo_dol = to_jest[i,0]-promienprzedzialu; int poprzecinek ;
        if (promienprzedzialu != 0) { poprzecinek = ile_zer(promienprzedzialu);
        if (czy_weszlo > 1){czy_weszlo = 1;}   if (czy_weszlo_dol < -1){czy_weszlo_dol = -1;}
        if (czy_weszlo >= 0) { czy_weszlo = Math.Round(czy_weszlo, poprzecinek, MidpointRounding.AwayFromZero); }
        else { czy_weszlo = Math.Round(czy_weszlo, poprzecinek, MidpointRounding.ToEven); }
        if (czy_weszlo_dol >= 0) { czy_weszlo_dol = Math.Round(czy_weszlo_dol, poprzecinek, MidpointRounding.ToEven); }
        else { czy_weszlo_dol = Math.Round(czy_weszlo_dol, poprzecinek, MidpointRounding.AwayFromZero); }
        if (czy_weszlo > 1) { czy_weszlo = 1; } if (czy_weszlo_dol < -1) { czy_weszlo_dol = -1; }}
        kwadratura_in_S[i,0] = new L_prz_Klasyczne(czy_weszlo_dol, czy_weszlo);
        czy_weszlo=to_jest[i,1]+promienprzedzialu;   czy_weszlo_dol=to_jest[i,1]-promienprzedzialu;
        if (promienprzedzialu != 0) { poprzecinek = ile_zer(promienprzedzialu);
        if (czy_weszlo >= 0) { czy_weszlo = Math.Round(czy_weszlo, poprzecinek, MidpointRounding.AwayFromZero); } 
        else { czy_weszlo = Math.Round(czy_weszlo, poprzecinek, MidpointRounding.ToEven); }
        if (czy_weszlo_dol >= 0) { czy_weszlo_dol = Math.Round(czy_weszlo_dol, poprzecinek, MidpointRounding.ToEven); }
        else { czy_weszlo_dol = Math.Round(czy_weszlo_dol, poprzecinek, MidpointRounding.AwayFromZero); }
        if (czy_weszlo > 1) { czy_weszlo = 1; } if (czy_weszlo_dol < -1) { czy_weszlo_dol = -1; }}
        kwadratura_in_S[i, 1] = new L_prz_Klasyczne(czy_weszlo_dol, czy_weszlo);} return kwadratura_in_S;}
    }
    
}
