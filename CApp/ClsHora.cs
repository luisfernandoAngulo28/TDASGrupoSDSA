using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class ClsHora
    {
        //Atributos
        private int Hora;
        private int Minuto;
        private int Segundo;
        //Constructor
        public ClsHora()
        {
            this.Hora = 0;
            this.Minuto = 0;
            this.Segundo = 0;
        }
        //Constructor Parametrizado
        public ClsHora(int hora,int minuto,int segundo)
        {
            if(hora>=0 && hora<24 
                && minuto>=0 && minuto<60 
                && segundo >= 0 && segundo < 60)
            {
                this.Hora = hora;
                this.Minuto = minuto;
                this.Segundo = segundo;

            }
        }
        //Constructor de Copia
        public ClsHora(ClsHora t)
        {
            this.Hora = t.Hora;
            this.Minuto = t.Minuto;
            this.Segundo = t.Segundo;
        }

        ///properties
        public int Hora1
        {
            get { return Hora; }
            set { Hora = value; }
        }
        public int Minuto1
        {
            get { return Minuto; }
            set { Minuto = value; }
        }
        public int Segundo1
        {
            get { return this.Segundo; }
            set { this.Segundo = value; }
        }
        public void cargar(int h,int m,int s)
        {
            if (s < 60)
            {
                if (m <= 59)
                {
                    if (h < 24)
                    {
                        this.Hora = h;
                        this.Minuto = m;
                        this.Segundo = s;
                    }
                }
            }
        }

        public String Descargar()
        {
            String S = "";
            //Concatenando la Hora
            if (Hora < 10)
            {
                S = S +"0"+ Hora + ":";
            }
            else
            {
                S = S +Hora + ":";
            }
            //------Minutos
            if (this.Minuto < 10)
            {
                S = S + "0" + Minuto + ":";
            }
            else
            {
                S = S + Minuto + ":";
            }
            //-----segundos
            if (Segundo < 10)
            {
                S = S + "0" + Segundo + ":";
            }
            else
            {
                S = S + Segundo + ":";
            }
            return S;
        }

        public bool HoraValida(int h,int m,int s)
        {
            bool y = false;
            if (h >= 0 && h < 24
                && m >= 0 && m < 60
                && s >= 0 && s < 60)
            {
                y = true;
            }
            return y;
           /* return (h >= 0 && h < 24
                && m >= 0 && m < 60
                && s >= 0 && s < 60);*/
        }

        public ClsHora horaActual()
        {
            ClsHora horaa = new ClsHora();
            int h = 0;
            int m = 0;
            int s = 0;
            h = DateTime.Now.Hour;
            m = DateTime.Now.Minute;
            s = DateTime.Now.Second;
            horaa.cargar(h, m, s);
            return horaa;
        }
        
    }
}
