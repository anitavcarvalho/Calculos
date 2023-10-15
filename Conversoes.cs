using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal static class Conversoes
    ///<summary>
    ///Implementa operações de conversão
    ///</summary>
    {
        public static enum ConversaoTemperatura
        {
            Nulo = 0
            CelsiusFarenheit,
            FarenheitCelsius
        }
        ///<summary>
        ///Conversão de temperaturas
        ///</summary>
        public static double Converter(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFarenheit)
            {
                return (temperatura *1.8 + 32);
            }
            else if (conversao == ConversaoTemperatura.FarenheitCelsius)
            {
                return ((temperatura - 32)/1.8);
            }
            return -1;
        }
    }
}