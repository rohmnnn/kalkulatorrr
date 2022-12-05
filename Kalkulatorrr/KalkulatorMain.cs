using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulatorrr
{
    public class KalkulatorMain
    {
        public string Hasil { get; set; }

        public static int Penambahan(int a, int b)
        {
            return a + b;
        }

        public static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        public static int Perkalian(int a, int b)
        {
            return a * b;
        }

        public static float Pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
