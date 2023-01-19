using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuito_electrico
{
    public class calculos
    {


        // resistores en paralelo r8-r10
        public double req1(double r8, double r10)
        {
            double X = (r8 * r10) / (r8 + r10);
            return X;
        }



        // resistores en serie rq8-10  , r6 , r7 , r9 
        public double req2(double x, double r6, double r7, double r9)
        {
            double y = x + r6 + r7 + r9;
            return y;

        }


        // resistores en paralelo rq 8-10-6-7-9 y r5
        public double req3(double y, double r5)
        {
            double z = (y * r5) / (y + r5);
            return z;
        }


        // resistores en paralelo r1-r2
        public double req4(double r1, double r2)
        {
            double x = (r1 * r2) / (r1 + r2);
            return x;
        }

        // resistores en paralelo r3-r4
        public double req5(double r3, double r4)
        {
            double x = (r3 * r4) / (r3 + r4);
            return x;
        }


        // resistores en serie  rq1-2  y rq6-7-8-9-10    y rq 3-4
        public double reqtotal(double req4, double req5, double req3) {
            double y = req4 + req5 + req3;
            return y;
        }
        // corriente total 
        public double ctotal(double bateria, double rtotal)
        {
            double c = bateria / rtotal;
            return c;

        }

                                    // voltajes // 
        //voltaje en r1 y r2
        public double r12x(double ctotal, double req4)
        {
            double x = ctotal * req4;

            return x;
        }


        // voltaje r3 y r4
        public double r34x(double ctotal, double req5)
        {
            double x = ctotal * req5;
            return x;
        }

        // voltaje r5
        public double r5x(double ctotal, double req3)
        {
            double x = ctotal * req3;
            return x;
        }

        // corriente despues de req3
        public double vreq3 (double r5x, double req2)
        {
            double x = r5x / req2;
            return x;

        }

        // voltaje r6
        public double r6x (double vreq3, double r6)
        {
            double x = vreq3 * r6;
            return x;
        }
        // voltaje r7
        public double r7x(double vreq3, double r7)
        {
            double x = vreq3 * r7;
            return x;
        }
      

        // voltaje r9 
        public double r9x(double vreq3, double r9)
        {
            double x = vreq3 * r9;
            return x;
        }

        // voltaje r8-10 
        public double r810 (double vreq3, double req1)
        {
            double x = vreq3 * req1;
            return x;
        }

    }
}
