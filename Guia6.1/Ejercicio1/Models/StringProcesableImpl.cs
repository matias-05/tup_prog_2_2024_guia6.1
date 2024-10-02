using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class StringProcesableImpl : IProcesable
    {
        public string Procesar(string patente, out string formateada)
        {
            formateada = patente.Replace(" ", "").Replace("-", "").ToUpper();

            #region Verificacion Vieja
            bool vieja = formateada.Length >= 6;
            for (int i = 0; i < formateada.Length && vieja == true; i++)
            {
                char d = formateada[i];
                vieja &= (char.IsLetter(d) && i < 3) || (char.IsDigit(d) && i <= 6 && i >= 3);
            }
            if (vieja)
            {
                return "Automóviles y camionetas hasta 2016";
            }
            #endregion

            #region Verificacion Nueva
            bool nueva = formateada.Length >= 7;
            for (int i = 0; i < formateada.Length && nueva == true; i++)
            {
                char d = formateada[i];
                nueva &= (char.IsLetter(d) && i < 2) || (char.IsDigit(d) && i < 5 && i >= 2) || (char.IsLetter(d) && i >= 5 && i <= 6);
            }
            if (nueva) 
            {
                return "Automóviles y camionetas desde 2016";
            }
            #endregion

            #region Verificacion Moto
            bool moto = formateada.Length >= 8;
            for (int i = 0; i < formateada.Length && moto == true; i++)
            {
                char d = formateada[i];
                moto &= (char.IsLetter(d) && i < 2) || (char.IsDigit(d) && i < 5 && i >= 2 || (char.IsLetter(d) && i >= 5 && i <= 7));
            }
            if (moto)
            {
                return "Motocicleta";
            }
            #endregion

            #region Verificacion Acoplado
            bool acoplado = formateada.Length >= 6;
            for (int i = 0; i < formateada.Length && acoplado == true; i++)
            {
                char d = formateada[i];
                acoplado &= (char.IsLetter(d) && i < 2) || (char.IsDigit(d) && i <= 5 && i >= 2);
            }
            if (acoplado)
            {
                return "Acoplado";
            }
            #endregion

            return "No reconocido";
        }
    }
}
