using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClsHora H = new ClsHora();
            ///llamada de un prodecimiento
           
            H.cargar(1, 36, 09);
            Console.WriteLine(H.Descargar());
            //Llamada de una funcion
            Console.WriteLine(H.HoraValida(72, 67, 76));
            Console.WriteLine(H.horaActual().Descargar());
            
            Console.ReadKey();
        }
    }
}
