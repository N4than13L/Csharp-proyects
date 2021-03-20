using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Aritmetica_basica
    {
        public float suma(float a, float b)
        {
           float S = a + b;
            return S;
        }

        public float resta(float a, float b)
        {
            float R = a - b;
            return R;
        }
        public float multiplicacion(float a, float b)
        {
            float M = a * b;
            return M;
        }
        public float dividir(float a, float b)
        {
            float D = a / b;
            return D;
        }
    }
}
