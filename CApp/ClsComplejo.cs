using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class ClsComplejo
    {
        private float n;

        public ClsComplejo()
        {
            n = 0;
        }

        //properties
        public float GetSet
        {
            get { return n; }
            set { n = value; }
        }
        public void cargar(float ele)
        {
            this.n = ele;
        }
        public bool esCero(float x)
        {
            //return x == 0;
            if (x == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public float Sucesor(float x)
        {
            x = x + 1;
            return x;
        }
        public float suma(float a, float b)
        {
            float s = 0;
            s = a + b;
            return s;
        }

        public float Resta(float a, float b)
        {
            float r = 0;
            r = a - b;
            return r;
        }
        public float multiplicacion(float a, float b)
        {
            float s = 0;

            s = a * b;

            return s;
        }

        public int parteEntera(String x)
        {
            String cad = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != ',')
                {
                    cad = cad + x[i];
                }
                else
                {
                    i = x.Length + 1;
                }

            }
            return int.Parse(cad);

        }

    }
}
