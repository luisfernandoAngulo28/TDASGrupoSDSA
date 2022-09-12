using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class ClsNatu
    {
        //Atributo
        private int n;
        //Constructor
        public ClsNatu()
        {
            n = 0;
        }

        public void cargar(int ele)
        {
            this.n = ele;
        }
        public bool esCero(int x)
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

        public int Sucesor(int x)
        {
            x = x + 1;
            return x;
        }
        public int suma(int a,int b)
        {
            int s = 0;
            if(a<0 || b < 0)
            {
                throw new Exception("Error de numero Invalido");
            }
            else
            {
                s = a + b;
            }
            return s;
        }

        public int Resta(int a, int b)
        {
            int r = 0;
            if (a < 0 || b < 0)
            {
                throw new Exception("Error de numero Invalido");
            }
            else
            {
                if (a > b)
                {
                    r = a - b;
                }
                else
                {
                    r = b - a;
                }
            }
            return r;
        }
        public int multiplicacion(int a, int b)
        {
            int s = 0;
            if (a < 0 || b < 0)
            {
                throw new Exception("Error de numero Invalido");
            }
            else
            {
                s = a * b;
            }
            return s;
        }
    }
}
