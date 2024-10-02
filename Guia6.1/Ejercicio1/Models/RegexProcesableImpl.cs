using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class RegexProcesableImpl:IProcesable
    {
        public string Procesar(string patente, out string formateada)
        {
            Match match = null;

            formateada = "";

            #region Verificacion Vieja
            match = Regex.Match(patente, @"^[A-Z]{3}[\s-]*\d{3}$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                formateada = match.Value.Replace(" ", "").Replace("-", "").ToUpper();
                return "Automóviles y camionetas hasta 2016";
            }
            #endregion

            #region Verificacion Nueva
            match = Regex.Match(patente, @"^[A-Z]{2}\s*\d{3}\s*[A-Z]{2}$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                formateada = match.Value.Replace(" ", "").Replace("-", "").ToUpper();
                return "Automóviles y camionetas desde 2016";
            }
            #endregion

            #region Verificacion Moto
            match = Regex.Match(patente, @"^\d{2}\s*[A-Z]{3}\s*\d{3}$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                formateada = match.Value.Replace(" ", "").Replace("-", "").ToUpper();
                return "Motocicleta";
            }
            #endregion

            #region Verificacion Acoplado
            match = Regex.Match(patente, @"^[A-Z]{2}\s*\d{4}$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                formateada = match.Value.Replace(" ", "").Replace("-", "").ToUpper();
                return "Acoplado";
            }
            #endregion

            return "No encontrado";
        }

    }
}
