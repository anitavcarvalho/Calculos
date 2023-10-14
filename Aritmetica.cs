using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Aritmetica
    ///Implementa operações aritméticas
    {
        public enum ConversaoTemperatura
        {
            Nulo = 0
            CelsiusFarenheit,
            FarenheitCelsius
        }
        public int Somar(int x, int y)
        /// Operação Soma
        {
            return x+y;
        }
        public int Sub(int x, int y)
        /// Operação Subtração
        {
            return x-y;
        }
        public double Converter(ConversaoTemperatura conversao, double temperatura)
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