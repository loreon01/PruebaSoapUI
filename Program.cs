using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaSoapUI.Soap1;

namespace PruebaSoapUI
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Soap1.TipoCambio cliente = new Soap1.TipoCambio();

            var respuesta = cliente.TipoCambioDia();
            Console.WriteLine(respuesta.CambioDolar.First().fecha);
            Console.WriteLine(respuesta.CambioDolar.First().referencia);
            Console.Read();







        }
    }
}
