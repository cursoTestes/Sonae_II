using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaVendas
{
    public class CalculadoraComissao
    {


        

        public decimal calcular(decimal valorVenda)
        {
            decimal result;

            if (valorVenda <= 10000)
            {
                result = valorVenda * 0.05m;
            }
            else
            {
                result = valorVenda * 0.06m;
            }

            return Math.Floor(result * 100) / 100.0m;
        }
    }
}
