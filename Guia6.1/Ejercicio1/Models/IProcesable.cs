using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal interface IProcesable
    {
         string Procesar(string patente, out string formateada);
    }
}
